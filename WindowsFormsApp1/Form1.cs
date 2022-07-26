using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Car
    {
        public string CarId { get; set; } = Guid.NewGuid().ToString().Substring(0, 6);
        public string Vendor { get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }

        public override string ToString()
        {
            return $"{CarId}\n{Vendor}\n{Model}\n{Engine}";
        }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> cars = new List<string>
            //{
            //    "Audi",
            //    "BMW",
            //    "Chevrolet"
            //};
            ////listBox1.DataSource = cars;

            //listBox1.Items.Add("Maserati");
            //listBox1.Items.Add("Ferrari");
            //listBox1.Items.Add("Mercedes");

            //listBox1.SelectedIndex = 1;


            List<Car> cars = new List<Car>
            {
                new Car
                {
                     Engine=2.5,
                      Model="E250",
                       Vendor="Lexus"
                },
                new Car
                {
                     Engine=3,
                      Model="Malibu",
                       Vendor="Chevrolet"
                },
                new Car
                {
                     Engine=4,
                      Model="La Ferrari",
                       Vendor="Ferrari"
                }
            };

            listBox1.DisplayMember = nameof(Car.Model);
            listBox1.DataSource = cars;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var data = listBox1.SelectedItem as string;
            //MessageBox.Show(data);
            //label1.Text = data;

            //var car= listBox1.SelectedItem as Car;
            //label1.Text = car.ToString();

            //var sb=new StringBuilder();
            //var cars=listBox1.SelectedItems;
            //foreach (var car in cars)
            //{
            //    sb.Append((car as Car).ToString()+"\n");
            //}

            //label1.Text=sb.ToString();

            ////with multiple   
            //var sb = new StringBuilder();
            //foreach (var item in listBox1.SelectedItems)
            //{
            //    sb.Append($"\n{item as string}");
            //}
            //label1.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = String.Empty;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
