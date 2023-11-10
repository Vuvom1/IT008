namespace Bai2_7
{
    partial class Form1
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
            this.tBHour = new System.Windows.Forms.TextBox();
            this.tBMinute = new System.Windows.Forms.TextBox();
            this.tBSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBAction = new System.Windows.Forms.ComboBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tBTimerCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBHour
            // 
            this.tBHour.Location = new System.Drawing.Point(127, 62);
            this.tBHour.Name = "tBHour";
            this.tBHour.Size = new System.Drawing.Size(100, 31);
            this.tBHour.TabIndex = 0;
            // 
            // tBMinute
            // 
            this.tBMinute.Location = new System.Drawing.Point(367, 62);
            this.tBMinute.Name = "tBMinute";
            this.tBMinute.Size = new System.Drawing.Size(100, 31);
            this.tBMinute.TabIndex = 1;
            // 
            // tBSecond
            // 
            this.tBSecond.Location = new System.Drawing.Point(609, 62);
            this.tBSecond.Name = "tBSecond";
            this.tBSecond.Size = new System.Drawing.Size(100, 31);
            this.tBSecond.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second";
            // 
            // cBAction
            // 
            this.cBAction.FormattingEnabled = true;
            this.cBAction.Items.AddRange(new object[] {
            "Shut down",
            "Restart",
            "Log out"});
            this.cBAction.Location = new System.Drawing.Point(127, 209);
            this.cBAction.Name = "cBAction";
            this.cBAction.Size = new System.Drawing.Size(165, 33);
            this.cBAction.TabIndex = 6;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(538, 174);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(128, 54);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(538, 256);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(128, 54);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tBTimerCount
            // 
            this.tBTimerCount.Location = new System.Drawing.Point(253, 371);
            this.tBTimerCount.Name = "tBTimerCount";
            this.tBTimerCount.Size = new System.Drawing.Size(276, 31);
            this.tBTimerCount.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBTimerCount);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.cBAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBSecond);
            this.Controls.Add(this.tBMinute);
            this.Controls.Add(this.tBHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBHour;
        private System.Windows.Forms.TextBox tBMinute;
        private System.Windows.Forms.TextBox tBSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBAction;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tBTimerCount;
    }
}

