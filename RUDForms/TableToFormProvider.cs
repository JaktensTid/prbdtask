using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DatabasesProjectingTask1.Controller;

namespace DatabasesProjectingTask1.RUDForms
{
    internal class TableToFormProvider
    {
        private readonly int elementsHeight = 30;
        private readonly int elementsWidth = 80;
        private readonly IRUDDatabaseWorker RUDDatabaseWorker;
        private string lastTableName;
        private string[] lastColumns;
        public event EventHandler<string> insertIsOver;

        public TableToFormProvider(IRUDDatabaseWorker RUDDatabaseWorker)
        {
            this.RUDDatabaseWorker = RUDDatabaseWorker;
        }

        public Form GetFormWithInsert(string tableName)
        {
            lastTableName = tableName;
            var form = new Form();
            form.Text = tableName;
            var columnNames = RUDDatabaseWorker.ColumnsNames(tableName);
            lastColumns = columnNames;
            var columnsCount = columnNames.Length;
            form.Height = columnsCount*elementsHeight + columnsCount*10 + 60;
            form.Width = 200;
            var labels = GetLabels(columnNames);
            Point lastPoint = labels[labels.Count - 1].Location;
            var textBoxes = GetTextBoxes(columnNames.Length);
            var insertButton = CreateInsertButton(lastPoint);
            form.Controls.AddRange(labels.ToArray());
            form.Controls.AddRange(textBoxes.ToArray());
            form.Controls.Add(insertButton);
            return form;
        }

        private Button CreateInsertButton(Point lastLocation)
        {
            var insertButton = new Button();
            insertButton.Height = elementsHeight;
            insertButton.Width = elementsWidth + 40;
            insertButton.Text = "Insert new Row";

            insertButton.Location = new Point(lastLocation.X, lastLocation.Y + 30);
            insertButton.Click += InsertButton_Click;

            return insertButton;
        }

        private void InsertButton_Click(object sender, System.EventArgs e)
        {
            Form form = (Form)((Button) sender).Parent;
            var textBoxes = new List<TextBox>();
            var labels = new List<Label>();

            foreach (var child in form.Controls)
            {
                if (child is Label)
                {
                    labels.Add((Label)child);
                }
                if (child is TextBox)
                {
                    textBoxes.Add((TextBox)child);
                }
            }

            var values = new List<string>();

            foreach (var tb in textBoxes)
            {
                values.Add(tb.Text);
            }

            try
            {
                RUDDatabaseWorker.InsertRow(lastTableName, lastColumns, values.ToArray());
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error", sqlException.Message);
            }

            insertIsOver(this, lastTableName);
        }

        private List<Label> GetLabels(string[] columnNames)
        {
            var labels = new List<Label>();

            for (var i = 0; i < columnNames.Length; i++)
            {
                Label label = new Label();
                var columnName = columnNames[i];
                label.Text = columnName;
                label.Height = elementsHeight;
                label.Width = elementsWidth;
                label.Location = new Point(10, i * elementsHeight + 10);
                labels.Add(label);
            }

            return labels;
        }

        private List<TextBox> GetTextBoxes(int columnCount)
        {
            var textBoxes = new List<TextBox>();

            for (var i = 0; i < columnCount; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Height = elementsHeight;
                textBox.Width = elementsWidth;
                textBox.Location = new Point(10 + elementsWidth + 10, i * elementsHeight + 10);
                textBoxes.Add(textBox);
            }

            return textBoxes;
        }
    }
}