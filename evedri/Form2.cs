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
    public partial class Form2 : Form
    {
        Workbook Book1 = new Workbook();
        public Form2()
        {
            InitializeComponent();
        }

        public void bookLoadFromFile()
        {
            Book1.LoadFromFile(@"C:\User\ACT-STUDENT\Desktop\Book1");
            Worksheet sheet = Book1.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dataGridView1.DataSource = dt;
            
        }

        public void insert(string data, string dataG, string hobbies, string color, string sayings)
        {
            int l = dataGridView1.Rows.Add();
            dataGridView1.Rows[l].Cells[0].Value = data;
            dataGridView1.Rows[l].Cells[1].Value = dataG;
            dataGridView1.Rows[l].Cells[2].Value = hobbies;
            dataGridView1.Rows[l].Cells[3].Value = color;
            dataGridView1.Rows[l].Cells[4].Value = sayings;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    dataGridView1.Rows.RemoveAt(row.Index);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int l = dataGridView1.CurrentCell.RowIndex;
            txtADDRESS form1 = (txtADDRESS)Application.OpenForms["Form"];

            form1.Name = dataGridView1.Rows[l].Cells[0].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
          
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
               
                MessageBox.Show("Please enter a search term.");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                      
                        if (cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                          
                            row.Selected = true; 
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            }
        }
    }
}
