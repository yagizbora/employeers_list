namespace İş_yeri_Kullanıcı_Girişleri
{
    partial class Form1
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
            AddEmployeerButton = new Button();
            DeleteEmployeerRecord = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            EmployeerNameandSurname = new TextBox();
            label2 = new Label();
            EmployeerDepartmant = new TextBox();
            label3 = new Label();
            DataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // AddEmployeerButton
            // 
            AddEmployeerButton.Location = new Point(352, 39);
            AddEmployeerButton.Name = "AddEmployeerButton";
            AddEmployeerButton.Size = new Size(114, 74);
            AddEmployeerButton.TabIndex = 0;
            AddEmployeerButton.Text = "Çalışan Ekleme";
            AddEmployeerButton.UseVisualStyleBackColor = true;
            AddEmployeerButton.Click += AddEmployeerButton_Click;
            // 
            // DeleteEmployeerRecord
            // 
            DeleteEmployeerRecord.Location = new Point(352, 199);
            DeleteEmployeerRecord.Name = "DeleteEmployeerRecord";
            DeleteEmployeerRecord.Size = new Size(114, 91);
            DeleteEmployeerRecord.TabIndex = 1;
            DeleteEmployeerRecord.Text = "Çalışan Sil";
            DeleteEmployeerRecord.UseVisualStyleBackColor = true;
            DeleteEmployeerRecord.Click += DeleteEmployeerRecord_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 47);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 3;
            label1.Text = "Çalışanın Sicil Numarası";
            // 
            // EmployeerNameandSurname
            // 
            EmployeerNameandSurname.Location = new Point(12, 127);
            EmployeerNameandSurname.Multiline = true;
            EmployeerNameandSurname.Name = "EmployeerNameandSurname";
            EmployeerNameandSurname.Size = new Size(302, 58);
            EmployeerNameandSurname.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 5;
            label2.Text = "Çalışanın ismi soy ismi";
            // 
            // EmployeerDepartmant
            // 
            EmployeerDepartmant.Location = new Point(12, 217);
            EmployeerDepartmant.Multiline = true;
            EmployeerDepartmant.Name = "EmployeerDepartmant";
            EmployeerDepartmant.Size = new Size(302, 58);
            EmployeerDepartmant.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 7;
            label3.Text = "Çalışanın Departmanı";
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(12, 302);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(342, 150);
            DataGrid.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 455);
            Controls.Add(DataGrid);
            Controls.Add(label3);
            Controls.Add(EmployeerDepartmant);
            Controls.Add(label2);
            Controls.Add(EmployeerNameandSurname);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(DeleteEmployeerRecord);
            Controls.Add(AddEmployeerButton);
            Name = "Form1";
            Text = "Çalışan Ekleme";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddEmployeerButton;
        private Button DeleteEmployeerRecord;
        private TextBox textBox1;
        private Label label1;
        private TextBox EmployeerNameandSurname;
        private Label label2;
        private TextBox EmployeerDepartmant;
        private Label label3;
        private DataGridView DataGrid;
    }
}
