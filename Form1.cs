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

        private void QuickLaunch_Load(object sender, EventArgs e)
        {
            Rectangle scrn = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(scrn.Width - this.Width, scrn.Height - this.Height);
            this.WindowState = FormWindowState.Minimized;

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
            //trayIcon.Visible = true;
        }

        private void launchApp(string app, string appParams)
        {
            this.WindowState = FormWindowState.Minimized;
            Process.Start(app, appParams);
        }

        private void QuickLaunch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnClickTrayIcon(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Minimized ? FormWindowState.Normal : FormWindowState.Minimized;
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

        private void OnClickFolderLocation(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if( DialogResult.OK == fbd.ShowDialog())
            {
                string cmd = "/K node %userprofile%\\documents\\github\\swagserver\\index.js " + fbd.SelectedPath;
                launchApp("cmd.exe", cmd);
                wsFolder.Text = fbd.SelectedPath;
            }
        }
    }
}
