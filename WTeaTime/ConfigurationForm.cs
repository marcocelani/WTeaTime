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
        private TeaEntityRow[] teaEntities;
        private StartForm mainForm;
        TeaContext context;

        public ConfigurationForm(TeaEntityRow[] te, TeaContext ctx, StartForm parent)
        {
            teaEntities = te;
            context = ctx;
            InitializeComponent();
            dataGridView1.DataSource = teaEntities;
            mainForm = parent;
            this.FormClosing += new FormClosingEventHandler(formClosingEvent);
        }

        private void formClosingEvent(object sender, FormClosingEventArgs e)
        {
            mainForm.updateMenu(this);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TeaEntityRow entity = teaEntities[((DataGridView)sender).CurrentRow.Index];
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

            TeaEntityRow tea = (from t in context.TeaEntity
                                                 .Where(x => x.Title.Equals(txtName.Text.Trim()))
                                select t).FirstOrDefault();
            if (tea == null)
            {
                isNew = true;
                tea = new TeaEntityRow();
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
                context.TeaEntity.Add(tea);
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
            
            TeaEntityRow tea = context.TeaEntity.Find(txtName.Text.Trim());
            if (tea == null)
            {
                MessageBox.Show("Tea exists or is newer?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Do you want delete \"" + tea.Title + "\"", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            context.TeaEntity.Remove(tea);
            context.SaveChanges();

            reloadEntities();
        }

        private void reloadEntities()
        {
            teaEntities = (from t in context.TeaEntity
                           select t).ToArray();
            dataGridView1.DataSource = teaEntities;
        }
    }
}
