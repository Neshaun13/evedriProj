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
            //

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
    }
}
