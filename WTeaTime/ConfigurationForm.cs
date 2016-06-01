using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTeaTime.Model;

namespace WTeaTime
{
    public partial class ConfigurationForm : Form
    {
        private StartForm mainForm;
        TeaContext context;
        private const string REGISTRY_KEY_RUN = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public ConfigurationForm(TeaContext ctx, StartForm parent)
        {
            context = ctx;
            InitializeComponent();
            Icon = Resources.Resources.icon1;
            dataGridView1.DataSource = ctx.lstTeas;
            mainForm = parent;
            this.FormClosing += new FormClosingEventHandler(formClosingEvent);

            chkStartUp.Checked =
                Registry.CurrentUser
                    .OpenSubKey(REGISTRY_KEY_RUN, true).GetValue(Application.ProductName) == null ? false : true;
        }

        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            mainForm.updateMenu(this);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TeaEntity entity = context.lstTeas[((DataGridView)sender).CurrentRow.Index];
            txtName.Text = entity.Title;
            numSecs.Value = entity.Sec;
            numMinutes.Value = entity.Min;
            chkAction.Checked = entity.RunAction;
            txtAction.Text = entity.Action ?? "";
            chkBeep.Checked = entity.Beep;
            chkMessage.Checked = entity.ShowMex;
            txtMessage.Text = entity.Message;
            ((DataGridView)sender).CurrentRow.Selected = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool isNew = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(this, "No name inserted!", "Error");
                txtName.Focus();
                return;
            }

            if (numMinutes.Value == 0 && numSecs.Value == 0)
            {
                MessageBox.Show(this, "Neither minutes, nor seconds inserted!", "Error");
                numMinutes.Focus();
                return;
            }

            TeaEntity tea = context.Find(txtName.Text.Trim());
            if (tea == null)
            {
                isNew = true;
                tea = new TeaEntity();
            }

            tea.Title = txtName.Text.Trim();
            tea.Min = (int)numMinutes.Value;
            tea.Sec = (int)numSecs.Value;
            tea.Message = txtMessage.Text.Trim();
            tea.ShowMex = chkMessage.Checked;
            tea.Beep = chkBeep.Checked;
            tea.Action = txtAction.Text;
            tea.RunAction = chkAction.Checked;

            if (isNew)
                context.lstTeas.Add(tea);
            context.SaveChanges();

            reloadEntities();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Name is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TeaEntity tea = context.Find(txtName.Text.Trim());
            if (tea == null)
            {
                MessageBox.Show("Tea exists or is newer?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Do you want delete \"" + tea.Title + "\"", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            context.lstTeas.Remove(tea);
            context.SaveChanges();

            reloadEntities();
        }

        private void reloadEntities()
        {
            teaEntityRowBindingSource.Clear();
            teaEntityRowBindingSource.DataSource = context.lstTeas;
            dataGridView1.DataSource = teaEntityRowBindingSource;
            mainForm.updateMenu(this);
        }

        private void chkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkStartUp.Checked)
                {
                    Registry.CurrentUser
                        .OpenSubKey(REGISTRY_KEY_RUN, true)
                        .SetValue(Application.ProductName, Application.ExecutablePath.ToString());
                }
                else
                {
                    Registry.CurrentUser
                       .OpenSubKey(REGISTRY_KEY_RUN, true)
                       .DeleteValue(Application.ProductName, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
