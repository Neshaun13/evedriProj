using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace evedri
{
    public partial class LOG_IN : Form
    {
        Dashboard dashboard = new Dashboard();

        public LOG_IN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Workbook Book1 = new Workbook();
            Book1.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Book1.xlsx");
            Worksheet Sheet = Book1.Worksheets[0];
            int row = Sheet.Rows.Length;
            bool IsAccess = true;

            for (int i = 2; i <= row; i++)
            {
                if (Sheet.Range[i, 10].Value == txtUSERNAME.Text && Sheet.Range[i, 11].Value == txtPASSWORD.Text)
                {
                    IsAccess = true;
                    break;
                }
                else
                {
                    IsAccess = false;

                }

            }
            if (IsAccess == true)
            {
                MessageBox.Show("Login Successfully!");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Invalid USERNAME or PASSWORD. Please try again!", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPASSWORD.PasswordChar = '\0';
            }
            else
            {
                txtPASSWORD.PasswordChar = '*';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUSERNAME.Clear();
            txtPASSWORD.Clear();
        }
    }
}
