using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İş_yeri_Kullanıcı_Girişleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OperationsClass.OperationsClass operations = new OperationsClass.OperationsClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result;
            float result2;
            if (!int.TryParse(textBox1.Text, out result))
            {
                // Geçersiz giriş
                MessageBox.Show("Lütfen geçerli bir tamsayı girin.");
                textBox1.Clear();
            }
            else
            {

                // Geçerli bir tamsayı girdisi
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;

               if (!int.TryParse(textBox1.Text, out result))
               {
                  MessageBox.Show("Lütfen geçerli bir tamsayı girin.");
                  return;
               }
               else
                { 
                    result = int.Parse(textBox1.Text);
                    dataGridView1.DataSource = null;
                    var data = operations.GetEmployeer(result);
                    Console.WriteLine(data);
                    dataGridView1.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
