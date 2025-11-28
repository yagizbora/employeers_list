using System.Data;

namespace İş_yeri_Kullanıcı_Girişleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OperationsClass.OperationsClass operations = new OperationsClass.OperationsClass();


        public void getdata()
        {
            try
            {
                DataGrid.DataSource = null;
                var data = operations.GetEmployeer();
                DataGrid.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private async void AddEmployeerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = EmployeerNameandSurname.Text.Trim();
                string departmant = EmployeerDepartmant.Text.Trim();


                var operasyon = await operations.CreateEmployeer(name, departmant);
                if (operasyon != null)
                {
                    MessageBox.Show(operasyon);
                    getdata();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void DeleteEmployeerRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    int employeerId = Convert.ToInt32(DataGrid.SelectedRows[0].Cells["Sicil_Numarasi"].Value);
                    Console.WriteLine(Convert.ToInt32(DataGrid.SelectedRows[0].Cells["Sicil_Numarasi"].Value));
                    var operasyon = operations.DeleteEmployeer(employeerId);
                    if (operasyon)
                    {
                        MessageBox.Show("Çalışan silindi!");
                        getdata();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
