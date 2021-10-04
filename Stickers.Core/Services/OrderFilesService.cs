using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Stickers.Data.Context;

namespace Stickers.Core.Services
{
    public class OrderFilesService
    {
        private const string OrdersFolderName = "Заказы";
        private const string ArchiveFolderName = "Архив";
        private const string SourceFilesFolderName = "Исходники";
        private const string ContourFilesFolderName = "Контуры";
        private readonly string _mainFolder;
        private readonly string _archiveFolder;

        public OrderFilesService()
        {
            _mainFolder = Path.Combine(FileSystemManager.Root, OrdersFolderName);
            _archiveFolder = Path.Combine(FileSystemManager.Root, ArchiveFolderName);
        }

        public void SaveOrderSourceFiles(int orderId, Dictionary<string, List<string>> sourceFiles)
        {
            CreateOrderFolder(orderId);
            foreach (var orderItemName in sourceFiles.Keys)
            {
                SaveOrderItemSourceFiles(orderId, orderItemName, sourceFiles[orderItemName]);
            }
        }

        public void SaveOrderItemSourceFiles(int orderId, string orderItemName, List<string> sourceFiles)
        {
            var sourceFolder = GetOrderSourceFolder(orderId);
            DeleteOrderItemFilesFromFolder(sourceFolder, orderItemName);
            foreach (var source in sourceFiles)
            {
                var fileName = Path.GetFileName(source);
                var newFileName = orderItemName + " " + fileName;
                File.Copy(source, Path.Combine(sourceFolder, newFileName), true);
            }
        }

        public void SaveOrderItemContourFiles(int orderId, string orderItemName, string contourFile)
        {
            var contourFolder = GetOrderContourFolder(orderId, false);
            DeleteOrderItemFilesFromFolder(contourFolder, orderItemName);
            var fileName = Path.GetFileName(contourFile);
            var newFileName = orderItemName + " " + fileName;
            if (fileName != null)
            File.Copy(contourFile, Path.Combine(contourFolder, newFileName), true);
        }

        public void DeleteOrderFolder(int orderId)
        {
            var orderFolder = Path.Combine(_mainFolder, orderId.ToString());
            Directory.Delete(orderFolder, true);
        }

        public void DeleteOrderItemFiles(int orderId, string orderItemName)
        {
            var sourceFolder = GetOrderSourceFolder(orderId);
            var contourFolder = GetOrderContourFolder(orderId, false);
            DeleteOrderItemFilesFromFolder(sourceFolder, orderItemName);
            DeleteOrderItemFilesFromFolder(contourFolder, orderItemName);
        }

        public void CreateOrdersFolder()
        {
            if (!Directory.Exists(_mainFolder))
            {
                Directory.CreateDirectory(_mainFolder);
            }
        }

        public void CreateArchiveFolder()
        {
            if (!Directory.Exists(_archiveFolder))
            {
                Directory.CreateDirectory(_archiveFolder);
            }
        }

        public void ArchiveOrder(int orderId)
        {
            var orderFolder = Path.Combine(_mainFolder, orderId.ToString());
            var archiveFolder = Path.Combine(_archiveFolder, orderId.ToString());
            Directory.Move(orderFolder, archiveFolder);
        }

        public void OpenContourFolders(List<int> orderIds)
        {
            foreach (var id in orderIds)
            {
                var folder = GetOrderContourFolder(id, false);
                Process.Start("explorer.exe", folder);
            }
        }

        public void OpenSourceFolder(int orderId)
        {
            var folder = GetOrderSourceFolder(orderId);
            Process.Start("explorer.exe", folder);
        }

        public void OpenContourFolder(int orderId, bool isArchived)
        {
            var folder = GetOrderContourFolder(orderId, isArchived);
            Process.Start("explorer.exe", folder);
        }

        private void CreateOrderFolder(int orderId)
        {
            var orderPath = Path.Combine(_mainFolder, orderId.ToString());
            Directory.CreateDirectory(orderPath);
            Directory.CreateDirectory(Path.Combine(orderPath, SourceFilesFolderName));
            Directory.CreateDirectory(Path.Combine(orderPath, ContourFilesFolderName));
        }

        private string GetOrderSourceFolder(int orderId)
        {
            return Path.Combine(_mainFolder, orderId.ToString(), SourceFilesFolderName);
        }

        private string GetOrderContourFolder(int orderId, bool isArchived)
        {
            var root = isArchived ? _archiveFolder : _mainFolder;
            return Path.Combine(root, orderId.ToString(), ContourFilesFolderName);
        }

        private void DeleteOrderItemFilesFromFolder(string folder, string orderItemName)
        {
            var files = Directory.GetFiles(folder).Select(Path.GetFileName).Where(x=> x.StartsWith($"{orderItemName} "));
            foreach (var file in files)
            {
                File.Delete(Path.Combine(folder, file));
            }
        }
    }
}
