using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace evedri
{
    public partial class txtADDRESS : Form
    {
        private Form2 Form2;
        public txtADDRESS()
        {
            InitializeComponent();
            Form2 = new Form2();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            string data = "";
            string dataG = "";
            string hobbies = "";
            string color = "";
            string sayings = "";

            data = data + txtName.Text + "";

            if (rdFemale.Checked)
            {
                dataG = dataG + rdFemale.Text + "";
            }
            else if (rdMale.Checked)
            {
                dataG = dataG + rdMale.Text + "";
            }
            if (ckBadminton.Checked)
            {
                hobbies = hobbies + ckBadminton.Text + " ";

            }
            if (ckBasketball.Checked)
            {
                hobbies = hobbies + ckBasketball.Text + " ";
            }
            if (ckVolleyball.Checked)
            {
                hobbies = hobbies + ckVolleyball.Text + " ";
            }
            color = cbColor.Text;
            sayings = txtSaying.Text;
            Form2 form2 = new Form2();
            Form2.insert(data, dataG, hobbies, color, sayings);
            Form2.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string data = "";
            string dataG = "";
            string hobbies = "";
            string color = "";
            string sayings = "";

            data = data + txtName.Text + "";

            if (rdFemale.Checked)
            {
                dataG = dataG + rdFemale.Text + "";
            }
            else if (rdMale.Checked)
            {
                dataG = dataG + rdMale.Text + "";
            }
            if (ckBadminton.Checked)
            {
                hobbies = hobbies + ckBadminton.Text + " ";

            }
            if (ckBasketball.Checked)
            {
                hobbies = hobbies + ckBasketball.Text + " ";
            }
            if (ckVolleyball.Checked)
            {
                hobbies = hobbies + ckVolleyball.Text + " ";
            }
            color = cbColor.Text;
            sayings = txtSaying.Text;
            Form2 form2 = new Form2();
            Form2.insert(data, dataG, hobbies, color, sayings);
            Form2.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
