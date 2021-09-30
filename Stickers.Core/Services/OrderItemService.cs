using Stickers.Data.Context;
using Stickers.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stickers.Core.Mappers;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;

namespace Stickers.Core.Services
{
    public class OrderItemService
    {
        private readonly OrderItemMapper _orderItemMapper;

        public OrderItemService()
        {
            _orderItemMapper = new OrderItemMapper();
        }

        public OrderItem AddOrderItem(OrderItem item)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<OrderItem>(context);
            return repository.Add(item);
        }

        public List<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            using var context = new StickersDbContext();
            return context.OrderItems
                .Include(x => x.Order).ThenInclude(x => x.Client)
                .Include(x => x.Film)
                .Include(x => x.WorkReports).ThenInclude(x => x.User)
                .Where(x => x.OrderId == orderId).ToList();
        }

        public OrderItem GetOrderItemById(int id)
        {
            using var context = new StickersDbContext();
            return context.OrderItems
                .Include(x => x.Order).ThenInclude(x => x.Client)
                .Include(x => x.Film)
                .Include(x => x.WorkReports).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == id);
        }

        public OrderItemView UpdateOrderItem(OrderItem orderItem)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<OrderItem>(context);
            return _orderItemMapper.Map(repository.Update(orderItem));
        }

        public List<OrderItemView> GetOrderItemViewsForProduction()
        {
            using var context = new StickersDbContext();
            return _orderItemMapper.MapList(context.OrderItems
                .Include(x => x.Order).ThenInclude(x => x.Client)
                .Include(x => x.Film)
                .Include(x => x.WorkReports).ThenInclude(x => x.User)
                .Where(x => x.Status == OrderItemStatus.ReadyForProduction || x.Status == OrderItemStatus.InProduction)
                .ToList());
        }

        public List<OrderItemView> GetOrderItemViewsForDesigner()
        {
            using var context = new StickersDbContext();
            return _orderItemMapper.MapList(context.OrderItems
                .Include(x => x.Order).ThenInclude(x => x.Client)
                .Include(x => x.Film)
                .Include(x => x.WorkReports).ThenInclude(x => x.User)
                .Where(x => x.Order.Status == OrderStatus.NotStarted || x.Order.Status == OrderStatus.ContoursOnRevision || x.Order.Status == OrderStatus.ContoursDrawn)
                .ToList());
        }
    }
}
