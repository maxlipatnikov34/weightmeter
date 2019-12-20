namespace _1712WeightMeter
{
    partial class AddMan
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddManName = new System.Windows.Forms.TextBox();
            this.AddManAccept = new System.Windows.Forms.Button();
            this.AddManDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AddManName
            // 
            this.AddManName.Location = new System.Drawing.Point(18, 45);
            this.AddManName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddManName.Name = "AddManName";
            this.AddManName.Size = new System.Drawing.Size(276, 26);
            this.AddManName.TabIndex = 1;
            // 
            // AddManAccept
            // 
            this.AddManAccept.Location = new System.Drawing.Point(18, 84);
            this.AddManAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddManAccept.Name = "AddManAccept";
            this.AddManAccept.Size = new System.Drawing.Size(138, 37);
            this.AddManAccept.TabIndex = 2;
            this.AddManAccept.Text = "Ok";
            this.AddManAccept.UseVisualStyleBackColor = true;
            this.AddManAccept.Click += new System.EventHandler(this.AddManAccept_Click);
            // 
            // AddManDecline
            // 
            this.AddManDecline.Location = new System.Drawing.Point(165, 85);
            this.AddManDecline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddManDecline.Name = "AddManDecline";
            this.AddManDecline.Size = new System.Drawing.Size(130, 35);
            this.AddManDecline.TabIndex = 3;
            this.AddManDecline.Text = "Cancel";
            this.AddManDecline.UseVisualStyleBackColor = true;
            this.AddManDecline.Click += new System.EventHandler(this.AddManDecline_Click);
            // 
            // AddMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 140);
            this.Controls.Add(this.AddManDecline);
            this.Controls.Add(this.AddManAccept);
            this.Controls.Add(this.AddManName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMan";
            this.Text = "AddMan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddMan_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddManName;
        private System.Windows.Forms.Button AddManAccept;
        private System.Windows.Forms.Button AddManDecline;
    }
}