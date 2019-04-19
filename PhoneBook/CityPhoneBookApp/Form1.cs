using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CityPhoneBookApp
{
    public partial class Form1 : Form
    {
        string currentCityName;
        string currentNumber;
        int currentCode;
        string currentOwnerName;
        City currentCity = new City();

        public Form1()
        {
            InitializeComponent();
            SelectCity();
        }

        private void SelectCity()
        {
            PhoneBookContext context = new PhoneBookContext();
            foreach (var city in context.Cities)
            {
                comboBox1.Items.Add(city.Name);
            }

            context.Dispose();

        }
        private void richTextBoxTextChanged(object sender, EventArgs e)
        {

            PhoneBookContext context = new PhoneBookContext();
            currentNumber = label4.Text + richTextBox1.Text;
            context.Dispose();

        }
        private void comboBoxTextChanged(object sender, EventArgs e)
        {
            PhoneBookContext context = new PhoneBookContext();
            currentCityName = comboBox1.Text;
            currentCity = context.Cities.Where(x => x.Name == currentCityName).FirstOrDefault();
            currentCode = currentCity.Code;
            SetCode();
        }

        private void SetCode()
        {
            label4.Text = "+7" + "(" + currentCode.ToString() + ") ";
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            currentOwnerName = textBox1.Text;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            PhoneBookContext context = new PhoneBookContext();
            context.PhoneNumbers.Add(new PhoneNumber
            {
                CityId = currentCity.Id,
                Number = currentNumber,
                OwnerName = currentOwnerName
            });
            context.SaveChanges();
            context.Dispose();

            MessageBox.Show("Успешно добавлено!");
        }
    }
}
