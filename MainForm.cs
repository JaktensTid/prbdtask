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

        private void GetAllArtistButton_Click(object sender, EventArgs e)
        {
            DataTable artists = sqlWorker.Artists;
            currentDataTable = artists;
            MainGrid.DataSource = artists;
        }

        private void GetAllAlbumsButton_Click(object sender, EventArgs e)
        {
            DataTable albums = sqlWorker.Albums;
            currentDataTable = albums;
            MainGrid.DataSource = albums;
        }

        private void GetAllSongsButton_Click(object sender, EventArgs e)
        {
            DataTable songs = sqlWorker.Tracks;
            currentDataTable = songs;
            MainGrid.DataSource = songs;
        }

        private void GetAllLabelsButton_Click(object sender, EventArgs e)
        {
            DataTable labels = sqlWorker.Labels;
            currentDataTable = labels;
            MainGrid.DataSource = labels;
        }

        private void GetAlbumsByArtistButton_Click(object sender, EventArgs e)
        {
            string artist = GetAlbumsByArtistTextBox.Text;
            if (artist != null)
            {
                DataTable albums = sqlWorker.GetAlbumsByArtist(artist);
                MainGrid.DataSource = albums;
            }
        }

        private void GetSongsByAlbumButton_Click(object sender, EventArgs e)
        {
            string album = GetSongsByAlbumTextBox.Text;
            if (album != null)
            {
                DataTable albums = sqlWorker.GetSongsByAlbum(album);
                MainGrid.DataSource = albums;
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
