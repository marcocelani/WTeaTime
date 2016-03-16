namespace WTeaTime
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaEntityRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.chkBeep = new System.Windows.Forms.CheckBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSecs = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teaEntityRowBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.secDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teaEntityRowBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 82);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secDataGridViewTextBoxColumn
            // 
            this.secDataGridViewTextBoxColumn.DataPropertyName = "Sec";
            this.secDataGridViewTextBoxColumn.HeaderText = "Sec";
            this.secDataGridViewTextBoxColumn.Name = "secDataGridViewTextBoxColumn";
            this.secDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaEntityRowBindingSource
            // 
            this.teaEntityRowBindingSource.DataSource = typeof(WTeaTime.Model.TeaEntityRow);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 82);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtMessage);
            this.panel3.Controls.Add(this.chkMessage);
            this.panel3.Controls.Add(this.chkBeep);
            this.panel3.Controls.Add(this.txtAction);
            this.panel3.Controls.Add(this.chkAction);
            this.panel3.Location = new System.Drawing.Point(13, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 120);
            this.panel3.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(70, 52);
            this.txtMessage.MaxLength = 512;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(509, 65);
            this.txtMessage.TabIndex = 4;
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(4, 52);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(72, 17);
            this.chkMessage.TabIndex = 3;
            this.chkMessage.Text = "Message:";
            this.chkMessage.UseVisualStyleBackColor = true;
            // 
            // chkBeep
            // 
            this.chkBeep.AutoSize = true;
            this.chkBeep.Location = new System.Drawing.Point(4, 28);
            this.chkBeep.Name = "chkBeep";
            this.chkBeep.Size = new System.Drawing.Size(51, 17);
            this.chkBeep.TabIndex = 2;
            this.chkBeep.Text = "Beep";
            this.chkBeep.UseVisualStyleBackColor = true;
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(70, 4);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(509, 20);
            this.txtAction.TabIndex = 1;
            // 
            // chkAction
            // 
            this.chkAction.AutoSize = true;
            this.chkAction.Location = new System.Drawing.Point(4, 4);
            this.chkAction.Name = "chkAction";
            this.chkAction.Size = new System.Drawing.Size(59, 17);
            this.chkAction.TabIndex = 0;
            this.chkAction.Text = "Action:";
            this.chkAction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 4);
            this.txtName.MaxLength = 256;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutes:";
            // 
            // numSecs
            // 
            this.numSecs.Location = new System.Drawing.Point(184, 28);
            this.numSecs.Name = "numSecs";
            this.numSecs.Size = new System.Drawing.Size(45, 20);
            this.numSecs.TabIndex = 3;
            this.numSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(49, 32);
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(45, 20);
            this.numMinutes.TabIndex = 4;
            this.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 55);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Add or Modify";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.numMinutes);
            this.panel2.Controls.Add(this.numSecs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(366, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 81);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(153, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chkStartUp);
            this.panel4.Location = new System.Drawing.Point(13, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 25);
            this.panel4.TabIndex = 4;
            // 
            // chkStartUp
            // 
            this.chkStartUp.AutoSize = true;
            this.chkStartUp.Location = new System.Drawing.Point(4, 3);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(143, 17);
            this.chkStartUp.TabIndex = 0;
            this.chkStartUp.Text = "Run on Windows startup";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.chkStartUp_CheckedChanged);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(610, 260);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teaEntityRowBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teaEntityRowBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.CheckBox chkBeep;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.CheckBox chkAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSecs;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkStartUp;
    }
}