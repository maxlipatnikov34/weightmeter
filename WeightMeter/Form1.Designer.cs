namespace _1712WeightMeter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewMan = new System.Windows.Forms.Button();
            this.ListOfMan = new System.Windows.Forms.ListView();
            this.RemoveMan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewMan
            // 
            this.AddNewMan.Location = new System.Drawing.Point(13, 13);
            this.AddNewMan.Name = "AddNewMan";
            this.AddNewMan.Size = new System.Drawing.Size(249, 39);
            this.AddNewMan.TabIndex = 0;
            this.AddNewMan.Text = "Add new man";
            this.AddNewMan.UseVisualStyleBackColor = true;
            this.AddNewMan.Click += new System.EventHandler(this.AddNewMan_Click);
            // 
            // ListOfMan
            // 
            this.ListOfMan.HideSelection = false;
            this.ListOfMan.Location = new System.Drawing.Point(13, 103);
            this.ListOfMan.MultiSelect = false;
            this.ListOfMan.Name = "ListOfMan";
            this.ListOfMan.ShowGroups = false;
            this.ListOfMan.Size = new System.Drawing.Size(249, 328);
            this.ListOfMan.TabIndex = 1;
            this.ListOfMan.UseCompatibleStateImageBehavior = false;
            this.ListOfMan.ItemActivate += new System.EventHandler(this.ListOfMan_ItemActivate);
            this.ListOfMan.SelectedIndexChanged += new System.EventHandler(this.ListOfMan_SelectedIndexChanged);
            // 
            // RemoveMan
            // 
            this.RemoveMan.Location = new System.Drawing.Point(13, 58);
            this.RemoveMan.Name = "RemoveMan";
            this.RemoveMan.Size = new System.Drawing.Size(249, 39);
            this.RemoveMan.TabIndex = 2;
            this.RemoveMan.Text = "Remove selected man";
            this.RemoveMan.UseVisualStyleBackColor = true;
            this.RemoveMan.Click += new System.EventHandler(this.RemoveMan_Click);
            // 
            // WeightMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(274, 443);
            this.Controls.Add(this.RemoveMan);
            this.Controls.Add(this.ListOfMan);
            this.Controls.Add(this.AddNewMan);
            this.Name = "WeightMeter";
            this.Text = "WeightMeter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeightMeter_FormClosed);
            this.Load += new System.EventHandler(this.WeightMeter_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button AddNewMan;
        private System.Windows.Forms.ListView ListOfMan;
        private System.Windows.Forms.Button RemoveMan;
    }
}

