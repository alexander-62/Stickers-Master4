using Stickers.Data.Model.Constants;
using System;
using System.Collections.Generic;

namespace Stickers.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ApproximalDeliveryDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Comment { get; set; }
        public string DeliveryAddress { get; set; }
        public string ReceiverCredentials { get; set; }
        public string PostIndex { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public decimal DeliveryCost { get; set; }
        public string TrackIdentifier { get; set; }
        public bool IsPayed { get; set; }
        public bool IsArchived { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool IsUrgent { get; set; }
        public OrderStatus Status { get; set; }
        public string InsertedBy { get; set; }
        public virtual BusinessClient Client { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
