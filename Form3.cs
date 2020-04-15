using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб2._1._2._3
{
    public partial class Form3 : Form
    {
        public Model1 db { get; set; }
        public Company tr { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            iDTextBox.Text = tr.ID.ToString();
            nameTextBox.Text = tr.Name.ToString();
            tradeTextBox.Text = tr.Trade.ToString();
            cityTextBox.Text = tr.City.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr.Name = nameTextBox.Text;
            tr.City = cityTextBox.Text;
            tr.Trade = tradeTextBox.Text;
            

            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}
