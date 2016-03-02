namespace WTeaTime
{
    partial class AnonymousForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.chkBeep = new System.Windows.Forms.CheckBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numSecs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMessage);
            this.panel3.Controls.Add(this.chkMessage);
            this.panel3.Controls.Add(this.chkBeep);
            this.panel3.Controls.Add(this.txtAction);
            this.panel3.Controls.Add(this.chkAction);
            this.panel3.Location = new System.Drawing.Point(16, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 120);
            this.panel3.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.numMinutes);
            this.panel2.Controls.Add(this.numSecs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 52);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds:";
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(49, 16);
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(45, 20);
            this.numMinutes.TabIndex = 4;
            this.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numSecs
            // 
            this.numSecs.Location = new System.Drawing.Point(184, 14);
            this.numSecs.Name = "numSecs";
            this.numSecs.Size = new System.Drawing.Size(45, 20);
            this.numSecs.TabIndex = 3;
            this.numSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutes:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 196);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Run!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // AnonymousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 232);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnonymousForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anonymous Tea";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkMessage;
        private System.Windows.Forms.CheckBox chkBeep;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.CheckBox chkAction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numSecs;
        private System.Windows.Forms.Label label2;
    }
}