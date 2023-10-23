namespace İş_yeri_kullanıcı_girişleri
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SicilNo = new System.Windows.Forms.TextBox();
            this.İsimSoyisim = new System.Windows.Forms.TextBox();
            this.Bölüm = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(1069, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "ShowClick";
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(1069, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sicil No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "İsim Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(188, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bölüm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SicilNo
            // 
            this.SicilNo.Location = new System.Drawing.Point(289, 28);
            this.SicilNo.Multiline = true;
            this.SicilNo.Name = "SicilNo";
            this.SicilNo.Size = new System.Drawing.Size(478, 94);
            this.SicilNo.TabIndex = 9;
            this.SicilNo.TextChanged += new System.EventHandler(this.SicilNo_TextChanged);
            // 
            // İsimSoyisim
            // 
            this.İsimSoyisim.Location = new System.Drawing.Point(289, 157);
            this.İsimSoyisim.Multiline = true;
            this.İsimSoyisim.Name = "İsimSoyisim";
            this.İsimSoyisim.Size = new System.Drawing.Size(485, 78);
            this.İsimSoyisim.TabIndex = 10;
            this.İsimSoyisim.TextChanged += new System.EventHandler(this.İsimSoyisim_TextChanged);
            // 
            // Bölüm
            // 
            this.Bölüm.Location = new System.Drawing.Point(289, 319);
            this.Bölüm.Multiline = true;
            this.Bölüm.Name = "Bölüm";
            this.Bölüm.Size = new System.Drawing.Size(485, 62);
            this.Bölüm.TabIndex = 11;
            this.Bölüm.TextChanged += new System.EventHandler(this.Bölüm_TextChanged);
            // 
            // listView1
            // 
            this.listView1.AccessibleDescription = "";
            this.listView1.AccessibleName = "Show_Listbox";
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(289, 485);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(485, 138);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(176, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kayıtlar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AccessibleDescription = "";
            this.DeleteButton.AccessibleName = "DeleteButton";
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteButton.Location = new System.Drawing.Point(1069, 317);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 62);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 631);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bölüm);
            this.Controls.Add(this.İsimSoyisim);
            this.Controls.Add(this.SicilNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SicilNo;
        private System.Windows.Forms.TextBox İsimSoyisim;
        private System.Windows.Forms.TextBox Bölüm;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteButton;
    }
}

