using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Stickers.Core.Services;
using Stickers.Data.Context;
using Stickers.Data.Entities;
using Stickers.WinForms.UserForms;

namespace Stickers.WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using var context = new StickersDbContext();
                context.Database.Migrate();
                FileSystemManager.Root = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule?.FileName);
                var fileService = new OrderFilesService();
                fileService.CreateOrdersFolder();
                fileService.CreateArchiveFolder();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DialogResult result;
                User user;
#if DEBUG
                user = context.Users.Find(1);
                Application.Run(new MainForms.MainForm(user));
#else

                using (var loginForm = new LoginForm())
                {
                    result = loginForm.ShowDialog();
                    user = loginForm.User;
                }
                
                if (result == DialogResult.OK)
                {
                    Application.Run(new MainForms.MainForm(user));
                }
#endif

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
