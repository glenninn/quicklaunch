using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace quickLaunch
{
    public partial class QuickLaunch : Form
    {
        public QuickLaunch()
        {
            InitializeComponent();
        }

        private Array applications;

        //private string webServerPath = "node %userprofile%\\documents\\github\\https\\server.js";
        private string webServerPath = "node %userprofile%\\documents\\node\\https\\server.js";

        private void QuickLaunch_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            Visible = false;
            Rectangle scrn = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(scrn.Width - this.Width, scrn.Height - this.Height);

            Bitmap bmFolderWhere = new Bitmap(GetType(), "folderlocn.png");
            btnFolderWhere.BackgroundImage = bmFolderWhere;
            this.Icon = Icon.FromHandle(bmFolderWhere.GetHicon());

            setupforTray();
        }

        private ContextMenu trayMenu;

        private void setupforTray()
        {
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", QuickLaunch_Click);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon.Text = "Quick Launch";
            Bitmap bmIcon = new Bitmap(GetType(), "trayicon.png");
            trayIcon.Icon = Icon.FromHandle(bmIcon.GetHicon());

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
        }

        private void launchApp(string app, string appParams)
        {
            // this.WindowState = FormWindowState.Minimized;
            Process.Start(app, appParams);
            this.Visible = false;
        }

        private void QuickLaunch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnClickTrayIcon(object sender, EventArgs e)
        {

            Console.WriteLine("VIsible: " + this.Visible);
            // this.WindowState = FormWindowState.Normal;
            this.Visible = this.Visible ? false : true;
        }

        private void OnKeyUpMonitor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string mtgId = monMtgId.Text.Trim();
                if (mtgId == "")
                    mtgId = "4159908751";
                launchApp("cmd.exe", "/c em " + mtgId);
            }
        }

        private void startWebServer()
        {
            string cmd = "/K " + webServerPath + " " + wsFolder.Text;
            launchApp("cmd.exe", cmd);
        }

        private void OnClickFolderLocation(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if( DialogResult.OK == fbd.ShowDialog())
            {
                wsFolder.Text = fbd.SelectedPath;
                startWebServer();
            }
        }

        private void OnClickMyBJN(object sender, EventArgs e)
        {
            launchApp("https://bluejeans.com/4159908751","");
        }

        private void OnFirstShow(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void OnKeyUpWebServer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startWebServer();
            }
        }
    }
}
