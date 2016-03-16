using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTeaTime.Model;

namespace WTeaTime
{
    public partial class StartForm : Form
    {
        private TeaContext db = new TeaContext();
        private TeaEntityRow[] TeaEntities;
        private int seconds_elasped = 0;
        private int total_time = 0;
        private bool isStarted = false;
        private TeaEntityRow selected;
        private List<ToolStripMenuItem> toEnableMenus = new List<ToolStripMenuItem>();
        private List<ToolStripMenuItem> toDisableMenus = new List<ToolStripMenuItem>();
        private ToolStripMenuItem current;
        private ToolStripMenuItem mnuAnonymous;
        private AboutForm aboutForm;

        public StartForm()
        {
            InitializeComponent();
            InitializeData();
            InitializeMenu();

            notifyIcon1.BalloonTipText = Application.ProductName;
            notifyIcon1.BalloonTipTitle = Application.ProductName;
        }

        private void InitializeData()
        {
            try {
                TeaEntities = (from t in db.TeaEntity
                               select t).ToArray();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeMenu()
        {
            contextMenu.Items.Clear();
            toEnableMenus.Clear();
            toDisableMenus.Clear();

            ToolStripMenuItem mnuName = new ToolStripMenuItem(Application.ProductName);
            mnuName.Click += new EventHandler(mnuNameAction_Click);
            mnuName.Image = Resources.Resources.info;
            contextMenu.Items.Add(mnuName);
            contextMenu.Items.Add(new ToolStripSeparator());

            foreach (TeaEntityRow t in TeaEntities)
            {
                ToolStripMenuItem mnuItem = new ToolStripMenuItem();
                mnuItem.Name = t.Title;
                mnuItem.Text = (t.Sec == 0) ?
                    t.Title + " (" + t.Min + " min.)" :
                    t.Title + " (" + t.Min + " min. " + t.Sec + " sec.)";
                mnuItem.Click += new EventHandler(mnuItemAction_Click);
                mnuItem.Tag = t;
                contextMenu.Items.Add(mnuItem);
            }

            contextMenu.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem mnuStop = new ToolStripMenuItem()
            {
                Name = "Stop",
                Text = "Stop"
            };
            mnuStop.Click += new EventHandler(mnuStopAction_Click);
            mnuStop.Enabled = false;
            mnuStop.Image = Resources.Resources.stop;
            toEnableMenus.Add(mnuStop);
            contextMenu.Items.Add(mnuStop);

            ToolStripMenuItem mnuAnonymous = new ToolStripMenuItem()
            {
                Name = "Anonymous",
                Text = "Anonymous..."
            };
            mnuAnonymous.Click += new EventHandler(mnuAnonymousAction_Click);
            mnuAnonymous.Image = Resources.Resources.anonymous;
            contextMenu.Items.Add(mnuAnonymous);
            //toDisableMenus.Add(mnuAnonymous);
            this.mnuAnonymous = mnuAnonymous;

            contextMenu.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem mnuConfigure = new ToolStripMenuItem()
            {
                Name = "Configure",
                Text = "Configure..."
            };
            mnuConfigure.Click += new EventHandler(mnuConfigureAction_Click);
            mnuConfigure.Image = Resources.Resources.configuration;
            contextMenu.Items.Add(mnuConfigure);
            toDisableMenus.Add(mnuConfigure);

            contextMenu.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem mnuExit = new ToolStripMenuItem();
            mnuExit.Text = "Exit";
            mnuExit.Image = Resources.Resources.close;
            mnuExit.Click += new EventHandler(mnuExit_Click);
            contextMenu.Items.Add(mnuExit);
        }

        private void mnuNameAction_Click(object sender, EventArgs e)
        {
            if (aboutForm != null) return;
            aboutForm = new AboutForm(this);
            aboutForm.Show();
        }

        public void resetAboutForm()
        {
            aboutForm = null;
        }

        private void switchMenus()
        {
            foreach (var menu in toEnableMenus)
            {
                menu.Enabled = !menu.Enabled;
            }
            foreach (var menu in toDisableMenus)
            {
                menu.Enabled = !menu.Enabled;
            }
        }

        public void updateMenu(ConfigurationForm configurationForm)
        {
            if (configurationForm != null)
                InitializeMenu();
        }

        private void mnuConfigureAction_Click(object sender, EventArgs e)
        {
            new ConfigurationForm(TeaEntities, db, this).ShowDialog();
        }

        private void mnuAnonymousAction_Click(object sender, EventArgs e)
        {
            if (isStarted) return;
            new AnonymousForm(this).ShowDialog();
        }

        private void mnuStopAction_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isStarted = false;
            seconds_elasped = 0;
            total_time = 0;
            selected = null;
            current = null;
            InitializeMenu();
        }

        private void mnuItemAction_Click(object sender, EventArgs e)
        {
            if (isStarted) return;
            current = (ToolStripMenuItem)sender;
            selected = (TeaEntityRow)current.Tag;
            current.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            switchMenus();
            timer.Interval = 1000;
            total_time = convertToMills(selected.Min, selected.Sec);
            seconds_elasped = 0;
            isStarted = true;
            timer.Start();
        }

        public void AnonymousAction(AnonymousForm form, TeaEntityRow entity)
        {
            if (form == null) return;
            if (entity == null) return;
            mnuAnonymous.Tag = entity;
            mnuItemAction_Click(mnuAnonymous, null);
        }

        private int convertToMills(int min, int sec)
        {
            return (int)TimeSpan.FromMinutes(min)
                   .Add(TimeSpan.FromSeconds(sec))
                   .TotalMilliseconds;
        }

        private string convertToMinSec(int elasped)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(elasped);
            return (t.Minutes == 0) ?
                " (" + t.Seconds + " sec. left)" :
                " (" + t.Minutes + " min. " + t.Seconds + " sec. left)";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seconds_elasped == total_time)
            {
                timer.Stop();
                isStarted = false;
                seconds_elasped = 0;
                total_time = 0;
                RunAction(selected);
                selected = null;
                current = null;
                InitializeMenu();
                return;
            }
            seconds_elasped += 1000;
            current.Text = selected.Title + convertToMinSec(total_time - seconds_elasped);
        }

        private void RunAction(TeaEntityRow tea)
        {
            if (tea == null) return;
            if (tea.Beep)
                System.Media.SystemSounds.Beep.Play();
            if (tea.ShowMex)
                MessageBox.Show(
                    tea.Message,
                    tea.Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            if (tea.RunAction)
            {
                if (!string.IsNullOrEmpty(tea.Action.Trim()))
                {
                    string[] command = tea.Action.Split(new char[] { ' ' }, 2);
                    new Process()
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            FileName = command[0],
                            Arguments = (command.Count() > 1) ? command[1] : ""
                        }
                    }.Start();
                }
            }
        }

        //private void resetMenu()
        //{
        //    contextMenu.Items.Clear();
        //    InitializeMenu();
        //}
    }
}
