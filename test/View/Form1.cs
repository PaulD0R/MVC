using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public event Action<Airport> AirportAdded;
        public event Action<int> AirportDeleted;

        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;

            _airportList = new AirportList(new List<Airport> {
                new Airport("Белинского", 123, 467, 2, true, "Пенза", 1960),
                new Airport("Домодедово", 883, 4967, 159, true, "Москва", 1962)
                });

            InitializeComponent();
            createTable();
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBoxName.Text;
                var countFlight = numericCountFlight.Value;
                var countTicket = numericCountTicket.Value;
                var area = numericArea.Value;
                var isOpen = checkBoxIsOpen.Checked;
                var city = textBoxCity.Text;
                var year = numericYear.Value;

                if (_airportList.Hubs.FirstOrDefault(x => x.Name.ToLower().Equals(name.ToLower())) != null)
                {
                    throw new MyException("Название уже существует");
                }

                Airport hub;

                if (name != string.Empty && city != string.Empty)
                {
                    hub = new Airport(name, Convert.ToInt32(countFlight), Convert.ToInt32(countTicket), Convert.ToInt32(area), isOpen, city, Convert.ToInt16(year));
                    
                    _airportList.Add(hub);

                    addRow();

                    textBoxName.Text = string.Empty;
                    numericCountFlight.Value = 0;
                    numericCountTicket.Value = 0;
                    numericArea.Value = 0;
                    checkBoxIsOpen.Checked = false;
                    textBoxCity.Text = string.Empty;
                    numericYear.Value = 1900;
                }
                else
                {
                    showEmpty();
                    throw new MyException("Заполните все поля");
                }

                textBoxName.BackColor = Color.White;
                textBoxCity.BackColor = Color.White;
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Неверный набор параметров");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка");
            }
        }

        private void showEmpty()
        {
            if (textBoxName.Text.Length == 0) textBoxName.BackColor = Color.Red;
            if (textBoxCity.Text.Length == 0) textBoxCity.BackColor = Color.Red;
        }

        private void createTable()
        {
            var number = 0;

            airoportsTable.Rows.Clear();

            foreach (var i in _airportList.Hubs)
            {
                var airport = i;

                airoportsTable.Rows.Add();

                airoportsTable.Rows[number].Cells[0].Value = airport.Name ?? string.Empty;
                airoportsTable.Rows[number].Cells[1].Value = airport.CountFlight.ToString() ?? "0";
                airoportsTable.Rows[number].Cells[2].Value = airport.CountTicket.ToString() ?? "0";
                airoportsTable.Rows[number].Cells[3].Value = airport.Area.ToString() ?? "0";
                airoportsTable.Rows[number].Cells[4].Value = airport.IsOpen.ToString() ?? string.Empty;
                airoportsTable.Rows[number].Cells[5].Value = airport.City ?? string.Empty;
                airoportsTable.Rows[number].Cells[6].Value = airport.YearOfConstruction.ToString() ?? "1900";

                number++;
            }
        }

        private void updateRow(Airport hub)
        {
            var row = airoportsTable.Rows.Cast<DataGridViewRow>().First(x => x.Cells[0].Value.Equals(hub.Name));

            hub.Name = hub.CheckName;

            row.Cells[0].Value = hub.Name ?? string.Empty;
            row.Cells[1].Value = hub.CountFlight.ToString() ?? "0";
            row.Cells[2].Value = hub.CountTicket.ToString() ?? "0";
            row.Cells[3].Value = hub.Area.ToString() ?? "0";
            row.Cells[4].Value = hub.IsOpen.ToString() ?? string.Empty;
            row.Cells[5].Value = hub.City ?? string.Empty;
            row.Cells[6].Value = hub.YearOfConstruction.ToString() ?? "1900";
        }

        private void removeRow(Airport hub)
        {
            var row = airoportsTable.Rows.Cast<DataGridViewRow>().First(x => x.Cells[0].Value.Equals(hub.Name));

            airoportsTable.Rows.Remove(row);
        }

        private void addRow()
        {
            var number = airoportsTable.RowCount;

            airoportsTable.Rows.Add();

            airoportsTable.Rows[number].Cells[0].Value = _airportList[_airportList.Length - 1].Name ?? string.Empty;
            airoportsTable.Rows[number].Cells[1].Value = _airportList[_airportList.Length - 1].CountFlight.ToString() ?? "0";
            airoportsTable.Rows[number].Cells[2].Value = _airportList[_airportList.Length - 1].CountTicket.ToString() ?? "0";
            airoportsTable.Rows[number].Cells[3].Value = _airportList[_airportList.Length - 1].Area.ToString() ?? "0";
            airoportsTable.Rows[number].Cells[4].Value = _airportList[_airportList.Length - 1].IsOpen.ToString() ?? string.Empty;
            airoportsTable.Rows[number].Cells[5].Value = _airportList[_airportList.Length - 1].City ?? string.Empty;
            airoportsTable.Rows[number].Cells[6].Value = _airportList[_airportList.Length - 1].YearOfConstruction.ToString() ?? string.Empty;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            var hub = _airportList.Remove(findNameTextbox.Text);

            if (hub != null)
            {
                removeRow(hub);
                findNameTextbox.Text = string.Empty;

                return;
            }

            MessageBox.Show("Не найден");
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var hub = _airportList.Hubs.FirstOrDefault(x => x.Name.ToLower() == findNameTextbox.Text.ToLower());

            if (hub != null)
            {
                Form2 form2 = new Form2(hub)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

                form2.ShowDialog();

                while (!hub.Name.Equals(hub.CheckName) && _airportList.Hubs.FirstOrDefault(x => x.Name.ToLower() == hub.CheckName.ToLower()) != null)
                {
                    MessageBox.Show("Название уже существует");

                    form2.ShowDialog();
                }

                updateRow(hub);

                findNameTextbox.Text = string.Empty;

                return;
            }

            MessageBox.Show("Не найден");
        }

        private void airoportsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            var name = airoportsTable.Rows[rowIndex].Cells[0].Value.ToString();
            var hub = _airportList.Hubs.First(x => x.Name == name);

            hub.CountFlight = Convert.ToInt32(airoportsTable.Rows[rowIndex].Cells[1].Value);
            hub.CountTicket = Convert.ToInt32(airoportsTable.Rows[rowIndex].Cells[2].Value);
            hub.Area = Convert.ToInt32(airoportsTable.Rows[rowIndex].Cells[3].Value);
            hub.IsOpen = Convert.ToBoolean(airoportsTable.Rows[rowIndex].Cells[4].Value);
            hub.City = airoportsTable.Rows[rowIndex].Cells[5].Value.ToString();
            hub.YearOfConstruction = Convert.ToInt16(airoportsTable.Rows[rowIndex].Cells[6].Value);
        }

        private void airoportsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var hub = _airportList.Hubs[e.RowIndex];
                updateRow(hub);
            }
        }
    }
}

