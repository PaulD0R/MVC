using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2(Airport airport)
        {
            _airport = airport;

            InitializeComponent();

            textBoxName.Text = airport.Name ?? string.Empty;
            numericCountFlight.Value = airport.CountFlight ?? 0;
            numericCountTicket.Value = airport.CountTicket ?? 0;
            checkBoxIsOpen.Checked = airport.IsOpen ?? false;
            numericArea.Value = Convert.ToInt32(airport.Area ?? 0);
            textBoxCity.Text = airport.City ?? string.Empty;
            numericYear.Value = airport.YearOfConstruction ?? 1900;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {

                _airport.CheckName = textBoxName.Text;
                _airport.CountFlight = Convert.ToInt32(numericCountFlight.Value);
                _airport.CountTicket = Convert.ToInt32(numericCountTicket.Value);
                _airport.IsOpen = checkBoxIsOpen.Checked;
                _airport.Area = Convert.ToInt32(numericArea.Value);
                _airport.City = textBoxCity.Text;
                _airport.YearOfConstruction = Convert.ToInt16(numericYear.Value);

                this.Close();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
