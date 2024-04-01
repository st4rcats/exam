namespace WindowsFormsApplication5
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnpercent = new System.Windows.Forms.Button();
            this.cbselect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(317, 227);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(139, 29);
            this.txtnum.TabIndex = 0;
            // 
            // txtanswer
            // 
            this.txtanswer.Location = new System.Drawing.Point(317, 262);
            this.txtanswer.Multiline = true;
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(139, 29);
            this.txtanswer.TabIndex = 1;
            // 
            // btnpercent
            // 
            this.btnpercent.Location = new System.Drawing.Point(348, 297);
            this.btnpercent.Name = "btnpercent";
            this.btnpercent.Size = new System.Drawing.Size(75, 27);
            this.btnpercent.TabIndex = 2;
            this.btnpercent.Text = "button1";
            this.btnpercent.UseVisualStyleBackColor = true;
            this.btnpercent.Click += new System.EventHandler(this.btnpercent_Click);
            // 
            // cbselect
            // 
            this.cbselect.FormattingEnabled = true;
            this.cbselect.Items.AddRange(new object[] {
            "10%",
            "20%",
            "50%",
            "75%"});
            this.cbselect.Location = new System.Drawing.Point(317, 200);
            this.cbselect.Name = "cbselect";
            this.cbselect.Size = new System.Drawing.Size(139, 21);
            this.cbselect.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 594);
            this.Controls.Add(this.cbselect);
            this.Controls.Add(this.btnpercent);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnpercent;
        private System.Windows.Forms.ComboBox cbselect;
    }
}

