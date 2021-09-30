using System;

namespace Stickers.Data.Model.Views
{
    public class OrderFullView : OrderView
    {
        public DateTime? InsertedDate { get; set; }
        public string ConfirmedBy { get; set; }
        public DateTime? OrderDoneDate { get; set; }
        public string PaymentCheckedBy { get; set; }
        public DateTime? PaymentCheckedDate { get; set; }

        public OrderFullView(OrderView orderView)
        {
            Id = orderView.Id;
            OrderDate = orderView.OrderDate;
            ApproximalDeliveryDate = orderView.ApproximalDeliveryDate;
            ConfirmedDate = orderView.ConfirmedDate;
            DeliveryDate = orderView.DeliveryDate;
            Comment = orderView.Comment;
            DeliveryAddress = orderView.DeliveryAddress;
            ReceiverCredentials = orderView.ReceiverCredentials;
            PostIndex = orderView.PostIndex;
            DeliveryType = orderView.DeliveryType;
            OrderCost = orderView.OrderCost;
            DeliveryCost = orderView.DeliveryCost;
            StickersCost = orderView.StickersCost;
            TrackIdentifier = orderView.TrackIdentifier;
            IsPayed = orderView.IsPayed;
            PaymentMethod = orderView.PaymentMethod;
            IsUrgent = orderView.IsUrgent;
            Status = orderView.Status;
            IsArchived = orderView.IsArchived;
            ClientName = orderView.ClientName;
            DaysFromConfirmation = orderView.DaysFromConfirmation;
            InsertedBy = orderView.InsertedBy;
            OrderItems = orderView.OrderItems;
        }
    }
}
