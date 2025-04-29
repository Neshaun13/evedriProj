using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evedri
{
    public partial class Dashboard : Form
    {
        Workbook Book1 = new Workbook();
        Form3 form3 = new Form3();
        public Dashboard()
        {
            InitializeComponent();
            //Status
            lblActive.Text = ShowCount(12,"Active").ToString();
            lblInactive.Text = ShowCount(12, "Inactive").ToString();
            //Gender
            lblMaleCount.Text = ShowCount(2, "Male").ToString();
            lblFemaleCount.Text = ShowCount(2, "Female").ToString();
            //Color
            lblBlueCount.Text = ShowCount(4, "blue").ToString();
            lblRedCount.Text = ShowCount(4, "red").ToString();
            lblPinkCount.Text = ShowCount(4, "pink").ToString();
            //Hobbies
            lblBasketball.Text = ShowCount(3, "Basketball").ToString();
            lblVolleyball.Text = ShowCount(3, "VolleyBall").ToString();
            //Course
            lblBsit.Text = ShowCount(13, "IT").ToString();
            lblBeed.Text = ShowCount(13, "BEED").ToString();



        }


        public int ShowCount(int ID, string Active)
        {
            Book1.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Book1.xlsx");
            Worksheet Sheet = Book1.Worksheets[0];
            int row = Sheet.Rows.Length;
            int count = 0;
            for (int i = 2; i <= row; i++)
            {
                if (Sheet.Range[i,ID].Value == Active)
                {
                    count++;
                }
            }
            return count;
                
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblInactive_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
