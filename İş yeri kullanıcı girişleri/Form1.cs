using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Windows.Forms;

namespace İş_yeri_kullanıcı_girişleri
{
    public partial class Form1 : Form
    {
        // EklemeSinifi ve DogrulamaSinifi nesnelerini tanımlayın.
        private AddUserData eklemeSinifi;
        private ShowUser veritabaniIslemleri = null;
        private DeleteUserData SilmeSinifi;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            // Form üzerindeki verileri alın
            if (int.TryParse(SicilNo.Text, out int sicilNo) && !string.IsNullOrWhiteSpace(İsimSoyisim.Text) && !string.IsNullOrWhiteSpace(Bölüm.Text))
            {
                string isimSoyisim = İsimSoyisim.Text;
                string bolum = Bölüm.Text;

                // Ekleme işlemi için EklemeSinifi sınıfını kullanın
                AddUserData eklemeSinifi = new AddUserData();

                try
                {
                    // Veriyi EklemeSinifi sınıfı aracılığıyla veritabanına ekleyin
                    eklemeSinifi.AddUser(sicilNo, isimSoyisim, bolum);

                    // Başarı mesajı gösterin
                    MessageBox.Show("Veri başarıyla eklendi!", "Başarılı");

                    // TextBox'ları temizleyin
                    SicilNo.Clear();
                    İsimSoyisim.Clear();
                    Bölüm.Clear();
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya bilgi verin
                    MessageBox.Show("Veri eklenirken bir hata oluştu: " + ex.Message, "Hata");
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurun.", "Hata");
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            int sicilNo;
            string isimSoyisim = İsimSoyisim.Text;
            string bolum = Bölüm.Text;

            if (int.TryParse(SicilNo.Text, out sicilNo) || (!string.IsNullOrWhiteSpace(isimSoyisim) && !string.IsNullOrWhiteSpace(bolum)))
            {
                // Veritabanı işlemleri sınıfını oluşturun
                ShowUser veritabaniIslemleri = new ShowUser("Server=HOME\\EMPLOYEER_LIST;Database=Employeer_List;Integrated Security=True");

                // Kullanıcıyı doğrulayın
                bool kullaniciDogrulandi = veritabaniIslemleri.CheckUserData(sicilNo, out isimSoyisim, out bolum);

                // Sonuçları ListBox kontrolüne gösterin
                if (kullaniciDogrulandi)
                {
                    listView1.Items.Clear(); // Önceki verileri temizleyin
                    listView1.Items.Add($"Sicil No: {sicilNo}");
                    listView1.Items.Add($"İsim Soyisim: {isimSoyisim}");
                    listView1.Items.Add($"Bölüm: {bolum}");
                }
                else
                {
                    listView1.Items.Clear();
                    MessageBox.Show("Kullanıcı Doğrulanamadı", "Hata");
                }

                // TextBox'ları temizleyin
                SicilNo.Clear();
                İsimSoyisim.Clear();
                Bölüm.Clear();
            }
            else
            {
                ////// SicilNumarası veya İsimSoyisim ve Bölüm girilmediği zaman tüm kayıtları çekmek için kullanıcıları Getir metoduyla çağıracaktır
                ShowUser veritabaniIslemleri = new ShowUser("Server=HOME\\EMPLOYEER_LIST;Database=Employeer_list;Integrated Security=True");
                DataTable dataTable = veritabaniIslemleri.ShowAllUserData();

                // DataTable'ı kullanarak kayıtları ListView veya diğer bir kontrolde gösterebilirsiniz
                // Örnek:
                listView1.Items.Clear(); // Önceki verileri temizleyin
                foreach (DataRow row in dataTable.Rows)
                {
                    listView1.Items.Add($"{row["ID"]} - {row["Name"]} - {row["Department"]}");
                }
            }
        }









        private void SicilNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void İsimSoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bölüm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Sil düğmesine tıklandığında yapılacak işlemler
            try
            {
                // Silme işlemi için gerekli verileri alın
                if (int.TryParse(SicilNo.Text, out int ID))
                {
                    string Name = İsimSoyisim.Text;
                    string Department = Bölüm.Text;

                    // Silme işlemi için SilmeSinifi sınıfını kullanın
                    DeleteUserData silmeSinifi = new DeleteUserData("Server=HOME\\EMPLOYEER_LIST;Database=Employeer_List;Integrated Security=True");
                    silmeSinifi.DeleteUser(ID);

                    // Başarı mesajı gösterin
                    MessageBox.Show("Veri başarıyla silindi!", "Başarılı");

                    // TextBox'ları temizleyin
                    SicilNo.Clear();
                    İsimSoyisim.Clear();
                    Bölüm.Clear();
                }
                else
                {
                    MessageBox.Show("Sicil Numarası bir sayı olmalıdır.", "Hata");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi verin
                MessageBox.Show("Veri silinirken bir hata oluştu: " + ex.Message, "Hata");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
