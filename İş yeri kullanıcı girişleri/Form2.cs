using System;
using System.Windows.Forms;

namespace İş_yeri_kullanıcı_girişleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Show3_Click(object sender, EventArgs e)
        {
            int sicilNo;
            string isimSoyisim = textBox1.Text; // TextBox'tan İsim Soyisim'i alın
            string bolum = textBox1.Text; // TextBox'tan Bölüm'ü alın

            // TextBox'tan sicil numarasını alın
            if (int.TryParse(textBox1.Text, out sicilNo))
            {
                // Veritabanı işlemleri sınıfını oluşturun
                ShowUser veritabaniIslemleri = new ShowUser("Server=HOME\\EMPLOYEER_LIST;Database=Employeer_List;Integrated Security=True");

                // Kullanıcıyı doğrula
                bool kullaniciDogrulandi = veritabaniIslemleri.CheckUserData(sicilNo, out isimSoyisim, out bolum);

                if (kullaniciDogrulandi)
                {
                    // ListView'a sonuçları ekleyin
                    listView1.Items.Clear();
                    MessageBox.Show("Kullanıcı doğrulandı.");
                    listView1.Items.Add($"Sicil Numarası: {sicilNo}");
                    listView1.Items.Add($"Name: {isimSoyisim}");
                    listView1.Items.Add($"Department: {bolum}");
                }
                else
                {
                    listView1.Items.Clear();
                    MessageBox.Show("Kullanıcı doğrulanamadı.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir Sicil No giriniz.", "Hata");
            }
        }

        private void SicilNo_TextChanged(object sender, EventArgs e)
        {
            // SicilNo değiştiğinde yapılacak işlemi burada gerçekleştirin
            // Örneğin, SicilNo'nun yeni değerini alabilirsiniz:
            string yeniSicilNo = textBox1.Text;
            // Şimdi yeniSicilNo değerini kullanarak istediğiniz işlemi gerçekleştirin.
        }

        private void Show_List(object sender, EventArgs e)
        {
            // listView1'de seçili öğelerin sayısını alın
            int selectedItemCount = listView1.SelectedItems.Count;

            // Seçili öğe yoksa veya birden fazla öğe seçildiyse, işlem yapma
            if (selectedItemCount != 1)
            {
                return;
            }

            // Sadece bir öğe seçildiyse bu öğeyi alın
            ListViewItem selectedItem = listView1.SelectedItems[0];

            // Öğenin metnini alın ve textBox1'e atayın
            textBox1.Text = selectedItem.Text;
        }


    }
}
