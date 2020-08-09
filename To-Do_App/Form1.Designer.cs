namespace To_Do_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Yapılacaklar_List = new System.Windows.Forms.CheckedListBox();
            this.Yapılanlar_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Görev_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Görev_Ekle_btn = new System.Windows.Forms.Button();
            this.Görev_Sil_btn = new System.Windows.Forms.Button();
            this.Durum_label = new System.Windows.Forms.Label();
            this.Güncelle_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yapılacaklar_List
            // 
            this.Yapılacaklar_List.FormattingEnabled = true;
            this.Yapılacaklar_List.Location = new System.Drawing.Point(188, 175);
            this.Yapılacaklar_List.Name = "Yapılacaklar_List";
            this.Yapılacaklar_List.Size = new System.Drawing.Size(162, 139);
            this.Yapılacaklar_List.TabIndex = 0;
            // 
            // Yapılanlar_List
            // 
            this.Yapılanlar_List.FormattingEnabled = true;
            this.Yapılanlar_List.Location = new System.Drawing.Point(470, 175);
            this.Yapılanlar_List.Name = "Yapılanlar_List";
            this.Yapılanlar_List.Size = new System.Drawing.Size(162, 134);
            this.Yapılanlar_List.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılacaklar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yapılanlar:";
            // 
            // Görev_Text
            // 
            this.Görev_Text.Location = new System.Drawing.Point(180, 54);
            this.Görev_Text.Name = "Görev_Text";
            this.Görev_Text.Size = new System.Drawing.Size(452, 20);
            this.Görev_Text.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Görev Ekle:";
            // 
            // Görev_Ekle_btn
            // 
            this.Görev_Ekle_btn.Location = new System.Drawing.Point(638, 51);
            this.Görev_Ekle_btn.Name = "Görev_Ekle_btn";
            this.Görev_Ekle_btn.Size = new System.Drawing.Size(72, 25);
            this.Görev_Ekle_btn.TabIndex = 6;
            this.Görev_Ekle_btn.Text = "Görev Ekle";
            this.Görev_Ekle_btn.UseVisualStyleBackColor = true;
            this.Görev_Ekle_btn.Click += new System.EventHandler(this.Görev_Ekle_btn_Click);
            // 
            // Görev_Sil_btn
            // 
            this.Görev_Sil_btn.Location = new System.Drawing.Point(716, 51);
            this.Görev_Sil_btn.Name = "Görev_Sil_btn";
            this.Görev_Sil_btn.Size = new System.Drawing.Size(72, 25);
            this.Görev_Sil_btn.TabIndex = 7;
            this.Görev_Sil_btn.Text = "Görev Sil";
            this.Görev_Sil_btn.UseVisualStyleBackColor = true;
            this.Görev_Sil_btn.Click += new System.EventHandler(this.Görev_Sil_btn_Click);
            // 
            // Durum_label
            // 
            this.Durum_label.AutoSize = true;
            this.Durum_label.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durum_label.Location = new System.Drawing.Point(58, 361);
            this.Durum_label.Name = "Durum_label";
            this.Durum_label.Size = new System.Drawing.Size(248, 23);
            this.Durum_label.TabIndex = 9;
            this.Durum_label.Text = "Tamamlanan Görev Yüzdesi:";
            // 
            // Güncelle_Btn
            // 
            this.Güncelle_Btn.Location = new System.Drawing.Point(470, 359);
            this.Güncelle_Btn.Name = "Güncelle_Btn";
            this.Güncelle_Btn.Size = new System.Drawing.Size(72, 25);
            this.Güncelle_Btn.TabIndex = 10;
            this.Güncelle_Btn.Text = "Güncelle";
            this.Güncelle_Btn.UseVisualStyleBackColor = true;
            this.Güncelle_Btn.Click += new System.EventHandler(this.Güncelle_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Güncelle_Btn);
            this.Controls.Add(this.Durum_label);
            this.Controls.Add(this.Görev_Sil_btn);
            this.Controls.Add(this.Görev_Ekle_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Görev_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yapılanlar_List);
            this.Controls.Add(this.Yapılacaklar_List);
            this.Name = "Form1";
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Yapılacaklar_List;
        private System.Windows.Forms.ListBox Yapılanlar_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Görev_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Görev_Ekle_btn;
        private System.Windows.Forms.Button Görev_Sil_btn;
        private System.Windows.Forms.Label Durum_label;
        private System.Windows.Forms.Button Güncelle_Btn;
    }
}

