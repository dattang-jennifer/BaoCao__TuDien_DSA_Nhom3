namespace TuDienAnhViet
{
    partial class Form2
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
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.bntSearch = new System.Windows.Forms.Button();
            this.txtVietnamese = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(40, 76);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(399, 22);
            this.txtEnglish.TabIndex = 0;
            this.txtEnglish.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(40, 37);
            this.lblEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(114, 16);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "Nhập từ tiếng Anh:";
            this.lblEnglish.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(467, 74);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(133, 37);
            this.bntSearch.TabIndex = 2;
            this.bntSearch.Text = "Tra cứu";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // txtVietnamese
            // 
            this.txtVietnamese.Location = new System.Drawing.Point(40, 164);
            this.txtVietnamese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVietnamese.Multiline = true;
            this.txtVietnamese.Name = "txtVietnamese";
            this.txtVietnamese.Size = new System.Drawing.Size(559, 184);
            this.txtVietnamese.TabIndex = 3;
            this.txtVietnamese.Text = "\r\n";
            this.txtVietnamese.TextChanged += new System.EventHandler(this.txtVietnamese_TextChanged);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(640, 37);
            this.lblList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(87, 16);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "Danh sách từ:";
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 16;
            this.lstWords.Location = new System.Drawing.Point(640, 74);
            this.lstWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(265, 244);
            this.lstWords.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 383);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 49);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm từ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(227, 383);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(160, 49);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Xóa từ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nghĩa tiếng Việt";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.txtVietnamese);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.txtEnglish);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anh-Viet Dictionary";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox txtVietnamese;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
    }
}
