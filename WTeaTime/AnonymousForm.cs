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
    public partial class AnonymousForm : Form
    {
        private StartForm mainForm;

        public AnonymousForm(StartForm parent)
        {
            InitializeComponent();
            Icon = Resources.Resources.icon1;
            mainForm = parent;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (numMinutes.Value == 0 && numSecs.Value == 0)
            {
                MessageBox.Show(this, "Neither minutes, nor seconds inserted!", "Error");
                numMinutes.Focus();
                return;
            }

            TeaEntityRow tea = new TeaEntityRow();
            tea.Title = "Anonymous";
            tea.Min = (int)numMinutes.Value;
            tea.Sec = (int)numSecs.Value;
            tea.Message = txtMessage.Text.Trim();
            tea.ShowMex = chkMessage.Checked;
            tea.Beep = chkBeep.Checked;
            tea.Action = txtAction.Text;
            tea.RunAction = chkAction.Checked;

            mainForm.AnonymousAction(this, tea);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
