using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
            BindGrid();
        }
        
        public void BindGrid() 
        {
             Customer c = new Customer();
            List<Customer> listCustomer = c.List();
            DataTable tableData = Utility.ConvertToDataTable(listCustomer);
            CustomerInfoTable.DataSource = tableData;
            CustomerInfoTable.Columns[0].Width = 60;
            CustomerInfoTable.Columns[1].Width = 60;
            CustomerInfoTable.Columns[2].Width = 200;
            CustomerInfoTable.Columns[3].Width = 150;
            CustomerInfoTable.Columns[4].Width = 180;
            BindChart(listCustomer,"");
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CustomerInfoTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Customer obj = new Customer();
            int index = e.RowIndex;
            if (!(index < 0)) 
            {
                if (e.ColumnIndex == 0) 
                {
                    string message = "Are you sure you want to delete this Record?";
                    string title = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult res = MessageBox.Show(message, title, buttons);
                    if (res == DialogResult.OK)
                    {
                        //get the value of the clicked rows id column
                        string value = CustomerInfoTable[1, e.RowIndex].Value.ToString();
                        obj.Delete(int.Parse(value));
                        BindGrid();
                        string title2 = "Message";
                        MessageBox.Show("Record Deleted Successfully.", title2);
                    }
                }
            }
        }



        private void BindChart(List<Customer> list,String Criteria)
        {

            DataTable dt = null;
            if (list != null)
            { 
                               
                if (Criteria == "Food Quality") {
                   var  result = list
                       .GroupBy(l => l.FoodRating)
                       .Select(cl => new
                       {
                           Rating = cl.First().FoodRating,
                           Count = cl.Count().ToString()
                       }).ToList();

                     dt = Utility.ConvertToDataTable(result);
                }
                if (Criteria == "Staff Friendliness") { 
                    var result = list
                        .GroupBy(l => l.StaffRating)
                        .Select(cl => new
                        {
                            Rating = cl.First().StaffRating,
                            Count = cl.Count().ToString()
                        }).ToList();

                    dt = Utility.ConvertToDataTable(result);
                }
                if (Criteria == "Cleanliness")
                {
                    var result = list
                        .GroupBy(l => l.CleanRating)
                        .Select(cl => new
                        {
                            Rating = cl.First().CleanRating,
                            Count = cl.Count().ToString()
                        }).ToList();

                    dt = Utility.ConvertToDataTable(result);
                }
                if (Criteria == "Order Accuracy")
                {
                    var result = list
                        .GroupBy(l => l.OrderRating)
                        .Select(cl => new
                        {
                            Rating = cl.First().OrderRating,
                            Count = cl.Count().ToString()
                        }).ToList();

                    dt = Utility.ConvertToDataTable(result);
                }
                if (Criteria == "Resturant Ambiance")
                {
                    var result = list
                        .GroupBy(l => l.AmbienceRating)
                        .Select(cl => new
                        {
                            Rating = cl.First().AmbienceRating,
                            Count = cl.Count().ToString()
                        }).ToList();

                    dt = Utility.ConvertToDataTable(result);
                }
                if (Criteria == "Value for Money")
                {
                    var result = list
                        .GroupBy(l => l.ValueRating)
                        .Select(cl => new
                        {
                            Rating = cl.First().ValueRating,
                            Count = cl.Count().ToString()
                        }).ToList();

                    dt = Utility.ConvertToDataTable(result);
                }
                RatingChart.DataSource = dt;
                RatingChart.Name = "Criteria";
                RatingChart.Series["Series1"].XValueMember = "Rating";
                RatingChart.Series["Series1"].YValueMembers = "Count";
                RatingChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                RatingChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                this.RatingChart.Titles.Remove(this.RatingChart.Titles.FirstOrDefault());
                this.RatingChart.Titles.Add("Customer Rating Chart");
                RatingChart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }  

        private void EnrolledChart_Click(object sender, EventArgs e)
        {

        }

        private void backtologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login backtologin = new Login();
            backtologin.ShowDialog();
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            Customer obj = new Customer();
            List<Customer> listCustomer = obj.List();

            BindChart(listCustomer, comboBoxcriteria.SelectedItem.ToString());
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
