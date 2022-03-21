namespace windows_shutdown
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.shutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(6, 22);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(126, 23);
            this.timePicker.TabIndex = 0;
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(6, 22);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(288, 136);
            this.outputTxt.TabIndex = 1;
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(138, 22);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 2;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // shutButton
            // 
            this.shutButton.Location = new System.Drawing.Point(219, 22);
            this.shutButton.Name = "shutButton";
            this.shutButton.Size = new System.Drawing.Size(75, 23);
            this.shutButton.TabIndex = 3;
            this.shutButton.Text = "Shutdown";
            this.shutButton.UseVisualStyleBackColor = true;
            this.shutButton.Click += new System.EventHandler(this.shutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shutButton);
            this.groupBox2.Controls.Add(this.timePicker);
            this.groupBox2.Controls.Add(this.abortButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(349, 315);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Shutdown Timer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker timePicker;
        private TextBox outputTxt;
        private Button abortButton;
        private Button shutButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}