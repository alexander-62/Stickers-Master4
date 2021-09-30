using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stickers.Core.Mappers;
using Stickers.Data.Context;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;

namespace Stickers.Core.Services
{
    public class WorkReportService
    {
        private readonly WorkReportMapper _workReportMapper;

        public WorkReportService()
        {
            _workReportMapper = new WorkReportMapper();
        }

        public WorkReport AddReport(WorkReport report)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<WorkReport>(context);
            return repository.Add(report);
        }

        public List<WorkReport> GetReports()
        {
            using var context = new StickersDbContext();
            var repository = new Repository<WorkReport>(context);
            return repository.GetAll();
        }

        public List<WorkReport> GetReportsForOrder(int orderId)
        {
            using var context = new StickersDbContext();
            return context.WorkReports
                .Where(x => x.OrderId == orderId)
                .Include(x => x.User)
                .ToList();
        }

        public WorkReport GetConfirmationReport(int orderId)
        {
            using var context = new StickersDbContext();
            return context.WorkReports
                .Where(x => x.OrderId == orderId && x.WorkType == WorkType.OrderConfirmation)
                .OrderByDescending(w => w.Date)
                .Include(x => x.User)
                .FirstOrDefault();
        }

        public List<WorkReport> GetReportsByWorkType(WorkType workType)
        {
            using var context = new StickersDbContext();
            return context.WorkReports
                .Where(x => x.WorkType == workType)
                .ToList();
        }

        public List<WorkReportView> GetReportViewsForUser(User user)
        {
            using var context = new StickersDbContext();
            var reports = context.WorkReports
                .Include(x => x.OrderItem).ThenInclude(x => x.Order).ThenInclude(x => x.Client)
                .Include(x => x.OrderItem).ThenInclude(x => x.Film)
                .Include(x => x.User)
                .Where(x => user.UserRole == UserRole.Administrator || x.User.Name == user.Name)
                .ToList();
            return _workReportMapper.MapList(reports);
        }

        public WorkReport GetReportById(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<WorkReport>(context);
            return repository.Get(id);
        }

        public WorkReport UpdateReport(WorkReport report)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<WorkReport>(context);
            return repository.Update(report);
        }

        public void DeleteReport(int id)
        {
            using var context = new StickersDbContext();
            var repository = new Repository<WorkReport>(context);
            var result = repository.Delete(id);
            if (result == null)
            {
                throw new Exception("Рулон уже удален.");
            }
        }
    }
}
