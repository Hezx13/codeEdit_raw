using System;
using System.Windows.Forms;
using EasyTabs;


namespace NotepadApplication
{
    public partial class Parent : TitleBarTabs
    {
        public Parent()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1()
                {
                    Text = "New File"
                }
            };
        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }
    }
}
