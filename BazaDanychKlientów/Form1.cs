using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychKlientów
{
    public partial class Form1 : Form
    {
        List<Customer> customersList = new List<Customer>();
        private int customerNumber;
        
        public Form1()
        {
            customersList.Add(new Customer("Bartosz", "Ruszel", "22", "Polska", "798545", "Kraków"));
            customersList.Add(new Customer("Dominik", "Raczkowski", "22", "Polska", "2328545", "Kraków"));
            customersList.Add(new Customer("Krystian", "kobus", "23", "Polska", "798545", "Kraków"));
            InitializeComponent();
            button4.Enabled = false; button2.Enabled = false;
            for (int i = 0; i < customersList.Count; i++)
            {
                customerList.Items.Add(customersList[i].Name + ' ' + customersList[i].LastName);
            }
     
        }
        public bool AddCustomer(string CustomerName, string CustomerLastName, string CustomerAge, string CustomerNationality, string CustomerPhone, string CustomerAddress)
        {
            if (CustomerName.Length == 0 || CustomerLastName.Length == 0 || CustomerAge.Length == 0 || CustomerNationality.Length == 0 || CustomerPhone.Length == 0 || CustomerAddress.Length == 0) {
                return false;
            } else {
                Customer customer = new Customer(CustomerName, CustomerLastName, CustomerAge, CustomerNationality, CustomerPhone, CustomerAddress);
                customersList.Add(customer);
                customerList.Items.Clear();
                for (int i = 0; i < customersList.Count; i++)
                { 
                    customerList.Items.Add(customersList[i].Name + ' ' + customersList[i].LastName);
                }  
                return true;
            }
        }
        public String EditCustomer(string customer)
        {
            for (int i = 0; i < customersList.Count; i++)
            {
                if ((customersList[i].Name + " " + customersList[i].LastName) == customer)
                {          
                    Customer customerEdit = customersList[i];
                    textBox1.Text = customerEdit.Name;
                    textBox4.Text = customerEdit.LastName;
                    textBox2.Text = customerEdit.Age;
                    textBox3.Text = customerEdit.Nationality;
                    textBox6.Text = customerEdit.Phone;
                    textBox7.Text = customerEdit.Address;
                    customerNumber = i;
                }
            }
            button2.Enabled = true; button3.Enabled = false; button1.Enabled = false; button4.Enabled = true; show.Enabled = false;
            return "Edytujesz klienta";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            string customerName = textBox1.Text;
            string customerLastName = textBox4.Text;
            string customerNationality = textBox3.Text;
            string customerAge = textBox2.Text;
            string customerPhone = textBox6.Text;
            string customerAddress = textBox7.Text;
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            bool isTrue = AddCustomer(customerName, customerLastName, customerAge, customerNationality, customerPhone, customerAddress);
            string errorTitle = "Wystąpił błąd";
            string errorMessage = "Należy uzuepełnić wszystkie pola";
            if (!isTrue) {
                MessageBox.Show(errorMessage, errorTitle, messageBoxButtons);
            } else {
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox2.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customer = customerList.SelectedItem.ToString();
                for (int i = customerList.Items.Count - 1; i >= 0; i--)
                {
                    if (customerList.Items[i].ToString().Contains(customer))
                    {
                        customerList.Items.RemoveAt(i);

                        for (int j = 0; j < customersList.Count; j++)
                        {
                            if (customersList[j].Name == customer)
                                customersList.RemoveAt(j);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                string errorTitle = "Wystąpił błąd!";
                string errorMessage = "Przed usunięciem należy wybrać Klienta z listy";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(errorMessage, errorTitle, messageBoxButtons);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                string customer = customerList.SelectedItem.ToString();
                EditCustomer(customer);
            }
            catch (NullReferenceException)
            {
                string errorTitle = "Wystąpił błąd!";
                string errorMessage = "Przed edycją musisz wybrać klienta z listy";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;

                DialogResult result;
                result = MessageBox.Show(errorMessage, errorTitle, messageBoxButtons);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
            button3.Enabled = true; button1.Enabled = true; button4.Enabled = false; show.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersList[customerNumber].Name = textBox1.Text;
            customersList[customerNumber].LastName = textBox4.Text;
            customersList[customerNumber].Nationality = textBox3.Text;
            customersList[customerNumber].Age = textBox2.Text;
            customersList[customerNumber].Phone = textBox6.Text;
            customersList[customerNumber].Address = textBox7.Text;
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
            button1.Enabled = true; button2.Enabled = false; button3.Enabled = true; button4.Enabled = false; show.Enabled = true;
        }
    }
}
