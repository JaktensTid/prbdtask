using System;
using System.Data;
using System.Windows.Forms;
using DatabasesProjectingTask1.Controller;
using DatabasesProjectingTask1.RUDForms;

namespace DatabasesProjectingTask1
{
    public partial class MainForm : Form
    {
        CDdatabase sqlWorker;
        DataTable currentDataTable;
        TableToFormProvider tableToFormProvider;

        public MainForm()
        {
            InitializeComponent();
            sqlWorker = new CDdatabase();
            tableToFormProvider = new TableToFormProvider(sqlWorker);
            tableToFormProvider.insertIsOver += TableToFormProvider_insertIsOver;
        }

        private void TableToFormProvider_insertIsOver(object sender, string e)
        {
            DataTable table = sqlWorker.GetTableByName(currentDataTable.TableName);
            currentDataTable = table;
            MainGrid.DataSource = table;
        }

        private void GetAllAddresses(object sender, EventArgs e)
        {
            DataTable addresses = sqlWorker.Addresses;
            currentDataTable = addresses;
            MainGrid.DataSource = addresses;
        }

        private void GetAllCandyTypes(object sender, EventArgs e)
        {
            DataTable candies = sqlWorker.CandyTypes;
            currentDataTable = candies;
            MainGrid.DataSource = candies;
        }

        private void GetAllCompanies(object sender, EventArgs e)
        {
            DataTable companies = sqlWorker.Companies;
            currentDataTable = companies;
            MainGrid.DataSource = companies;
        }

        private void GetAllFactores(object sender, EventArgs e)
        {
            DataTable factories = sqlWorker.Factories;
            currentDataTable = factories;
            MainGrid.DataSource = factories;
        }

        private void GetAllPersons(object sender, EventArgs e)
        {
            DataTable persons = sqlWorker.Persons;
            currentDataTable = persons;
            MainGrid.DataSource = persons;
        }

        private void GetCompaniesByCandyType(object sender, EventArgs e)
        {
            string candy = GetCompaniesByCandyTextBox.Text;
            if (candy != null)
            {
                DataTable companies = sqlWorker.GetCompaniesByCandyType(candy);
                MainGrid.DataSource = companies;
            }
        }

        private void GetCompanyByPerson(object sender, EventArgs e)
        {
            string person = GetCompanyByPersonTextBox.Text;
            if (person != null)
            {
                try
                {
                    DataTable company = sqlWorker.GetCompanyByPerson(person);
                    MainGrid.DataSource = company;
                }
                catch(ArgumentException)
                {
                    MessageBox.Show("Введите имя и фамилию сотрудника");
                }
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (currentDataTable != null)
            {
                if (MainGrid.SelectedRows.Count > 0)
                {
                    int selectedIndex = MainGrid.SelectedRows[0].Index;
                    int rowID = int.Parse(MainGrid[0, selectedIndex].Value.ToString());
                    sqlWorker.DeleteRow(currentDataTable.TableName, rowID);

                    MainGrid.Rows.RemoveAt(selectedIndex);
                }
            }
        }

        private void TryInsertButton_Click(object sender, EventArgs e)
        {
            if (currentDataTable != null)
            {
                Form insertForm = tableToFormProvider.GetFormWithInsert(currentDataTable.TableName);
                insertForm.Show();
            }
        }

      
    }
}
