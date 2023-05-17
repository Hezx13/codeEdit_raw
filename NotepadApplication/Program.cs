using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace NotepadApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Parent container = new Parent();

            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new Form1()
                    {
                        Text = "New File"
                    }
                }
                );
            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext context = new TitleBarTabsApplicationContext();
            context.Start(container);
            Application.Run(context);

        }
    }
}
