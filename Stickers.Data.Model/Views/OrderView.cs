using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stickers.Data.Model.Views
{
    public class OrderView
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ApproximalDeliveryDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Comment { get; set; }
        public string DeliveryAddress { get; set; }
        public string ReceiverCredentials { get; set; }
        public string PostIndex { get; set; }
        public string DeliveryType { get; set; }
        public decimal OrderCost { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal StickersCost { get; set; }
        public string TrackIdentifier { get; set; }
        public bool IsPayed { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsUrgent { get; set; }
        public string Status { get; set; }
        public bool IsArchived { get; set; }
        public string ClientName { get; set; }
        public int? DaysFromConfirmation { get; set; }
        public string InsertedBy { get; set; }
        public List<OrderItemView> OrderItems { get; set; }
        [NotMapped]
        public int OrdersCount { get; set; }
    }
}
