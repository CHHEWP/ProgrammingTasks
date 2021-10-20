using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            // Add code here
        }
        private void btnTask2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var list1 = new int[] { 1, 2, 3, 6, 8, 3, 9 };
            var list2 = new int[] { 3, 2, 9, 3, 7 };
            // Add code here
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var list1 = new int[] { 1, 2, 3, 6, 8, 3, 9 };
            var list2 = new int[] { 3, 2, 9, 3, 7 };
            // Add code here
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string str1 = "Hello";
            string str2 = "There";
            AddALine(string.Format("string1={0}, string2={1}", str1, str2));
            // Add code here
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var list1 = new int[] { 52, 21, 27, 3, 62, 9 };
            // Add code here
        }

        private void btnTask6_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var list1 = new int[] { 52, 21, 27, 3, 62, 9 };
            // Add code here
        }

        private void btnTask7_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var Products = new List<Product>();

            var newprod = new Product()
            {
                ProductId = 123,
                Description = "Widget1",
                StockOnHand = 23,
            };
            Products.Add(newprod);

            newprod = new Product()
            {
                ProductId = 146,
                Description = "Widget2",
                StockOnHand = 3
            };
            Products.Add(newprod);

            newprod = new Product()
            {
                ProductId = 161,
                Description = "Widget3",
                StockOnHand = 59
            };
            Products.Add(newprod);

            newprod = new Product()
            {
                ProductId = 201,
                Description = "Widget4",
                StockOnHand = 1
            };
            Products.Add(newprod);

            //Hint, Sort a List<T> by property
            foreach (var prod in Products)
                AddALine(prod.ToString());
        }
        private void btnTask8_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            var Supplier1 = new Supplier(123, "Supplier 1", "123 Main Street");
            var Supplier2 = new Supplier(456, "Supplier 2", "456 Main Street");
            var Products = new List<Product>();

            var newprod = new Product()
            {
                ProductId = 123,
                Description = "Widget1",
                StockOnHand = 23,
                ProductSupplier = Supplier1
            };
            Products.Add(newprod);

            newprod = new Product()
            {
                ProductId = 146,
                Description = "Widget2",
                StockOnHand = 3
            };
            Products.Add(newprod);

            newprod = new Product()
            {
                ProductId = 161,
                Description = "Widget3",
                StockOnHand = 59,
                ProductSupplier = Supplier2
            };
            Products.Add(newprod);

            newprod = new Product()
            {
                ProductId = 201,
                Description = "Widget4",
                StockOnHand = 1,
                ProductSupplier = Supplier1
            };
            Products.Add(newprod);

            foreach (var prod in Products)
                AddALine(prod.FullDetails());

        }
        private void btnTask9_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            Person NewPerson = new Person();
            NewPerson.SetPerson(123, "Smith", "123 Main Street");
        }
        private void AddALine(string NewRow)
        {
            listBox.Items.Add(NewRow);
        }
        private void AddALine(int NewRow)
        {
            listBox.Items.Add(NewRow.ToString());
        }
    }
}
