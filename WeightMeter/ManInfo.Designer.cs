namespace _1712WeightMeter
{
    partial class ManInfo
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
            this.ManName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddWeight = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ManNameInfo = new System.Windows.Forms.Label();
            this.CommentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ManName
            // 
            this.ManName.AutoSize = true;
            this.ManName.Location = new System.Drawing.Point(13, 13);
            this.ManName.Name = "ManName";
            this.ManName.Size = new System.Drawing.Size(35, 13);
            this.ManName.TabIndex = 0;
            this.ManName.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValueColumn,
            this.DataColumn,
            this.CommentCol});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 241);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 55;
            // 
            // DataColumn
            // 
            this.DataColumn.Text = "Data";
            this.DataColumn.Width = 120;
            // 
            // AddWeight
            // 
            this.AddWeight.Location = new System.Drawing.Point(16, 277);
            this.AddWeight.Name = "AddWeight";
            this.AddWeight.Size = new System.Drawing.Size(395, 23);
            this.AddWeight.TabIndex = 2;
            this.AddWeight.Text = "Add new Weight Info";
            this.AddWeight.UseVisualStyleBackColor = true;
            this.AddWeight.Click += new System.EventHandler(this.AddWeight_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Progression Chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManNameInfo
            // 
            this.ManNameInfo.AutoSize = true;
            this.ManNameInfo.Location = new System.Drawing.Point(55, 13);
            this.ManNameInfo.Name = "ManNameInfo";
            this.ManNameInfo.Size = new System.Drawing.Size(0, 13);
            this.ManNameInfo.TabIndex = 4;
            // 
            // CommentCol
            // 
            this.CommentCol.Text = "Comment";
            this.CommentCol.Width = 218;
            // 
            // ManInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 335);
            this.Controls.Add(this.ManNameInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddWeight);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ManName);
            this.Name = "ManInfo";
            this.Text = "ManInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManInfo_FormClosed);
            this.Load += new System.EventHandler(this.ManInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label ManName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button AddWeight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ManNameInfo;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.ColumnHeader DataColumn;
        private System.Windows.Forms.ColumnHeader CommentCol;
    }
}