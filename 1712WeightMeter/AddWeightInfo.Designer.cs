namespace _1712WeightMeter
{
    partial class AddWeightInfo
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
            this.AddWeightInfoWeightValue = new System.Windows.Forms.TextBox();
            this.AddWeightInfoAccept = new System.Windows.Forms.Button();
            this.AddWeightInfoDecline = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // AddWeightInfoWeightValue
            // 
            this.AddWeightInfoWeightValue.Location = new System.Drawing.Point(16, 20);
            this.AddWeightInfoWeightValue.Name = "AddWeightInfoWeightValue";
            this.AddWeightInfoWeightValue.Size = new System.Drawing.Size(181, 20);
            this.AddWeightInfoWeightValue.TabIndex = 1;
            // 
            // AddWeightInfoAccept
            // 
            this.AddWeightInfoAccept.Location = new System.Drawing.Point(16, 90);
            this.AddWeightInfoAccept.Name = "AddWeightInfoAccept";
            this.AddWeightInfoAccept.Size = new System.Drawing.Size(83, 23);
            this.AddWeightInfoAccept.TabIndex = 2;
            this.AddWeightInfoAccept.Text = "Ok";
            this.AddWeightInfoAccept.UseVisualStyleBackColor = true;
            this.AddWeightInfoAccept.Click += new System.EventHandler(this.AddWeightInfoAccept_Click);
            // 
            // AddWeightInfoDecline
            // 
            this.AddWeightInfoDecline.Location = new System.Drawing.Point(105, 90);
            this.AddWeightInfoDecline.Name = "AddWeightInfoDecline";
            this.AddWeightInfoDecline.Size = new System.Drawing.Size(92, 23);
            this.AddWeightInfoDecline.TabIndex = 3;
            this.AddWeightInfoDecline.Text = "Cancel";
            this.AddWeightInfoDecline.UseVisualStyleBackColor = true;
            this.AddWeightInfoDecline.Click += new System.EventHandler(this.AddWeightInfoDecline_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comment";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(19, 64);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(178, 20);
            this.Comment.TabIndex = 5;
            // 
            // AddWeightInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 120);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddWeightInfoDecline);
            this.Controls.Add(this.AddWeightInfoAccept);
            this.Controls.Add(this.AddWeightInfoWeightValue);
            this.Controls.Add(this.label1);
            this.Name = "AddWeightInfo";
            this.Text = "AddWeightInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddWeightInfo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddWeightInfoWeightValue;
        private System.Windows.Forms.Button AddWeightInfoAccept;
        private System.Windows.Forms.Button AddWeightInfoDecline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Comment;
    }
}