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
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Submit")
            {
                /*if (txtCustomerName.Text != "")
                {
                    if (txtCustomerNumber.Text != "")
                    {
                        if (txtEmail.Text != "")*/
                        /*{*/
                            Customer obj = new Customer();
                            obj.CustomerName = txtCustomerName.Text;
                            obj.ContactNumber = txtCustomerNumber.Text;
                            obj.Email = txtEmail.Text;
                            obj.FoodRating =  RatingFoodQuality();
                            obj.StaffRating  = RatingStaffFriendliness();
                            obj.CleanRating  =RatingCleanliness();
                            obj.OrderRating  = RatingOrder();
                            obj.AmbienceRating  = RatingAmbience();
                            obj.ValueRating  = RatingValue();
                            obj.Feedbackdate = DateTime.Now;
                            obj.Add(obj);
                            Clear();
                            MessageBox.Show("Feedback Submitted Successfully");
                        }
                        /*else
                        {
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                }
            }
            else
            {
                Customer obj = new Customer();
                obj.CustomerName = txtCustomerName.Text;
                obj.ContactNumber = txtCustomerNumber.Text;
                obj.Email = txtEmail.Text;
            }*/
        }

        public void Clear()
        {
            txtCustomerName.Text = "";
            txtCustomerNumber.Text = "";
            txtEmail.Text = "";
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            groupBox2.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            groupBox4.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            groupBox5.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            groupBox6.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            groupBox7.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
        }


        public int RatingFoodQuality()
        {
            if (ExcGrpFood.Checked)
            {
                return 4;
            }
            if (GoGrpFood.Checked)
            {
                return 3;
            }
            if (AvgGrpFood.Checked)
            {
                return 2;
            }
            if (DisGrpFood.Checked)
            {
                return 1;
            }
            return 0;
        }

        public int RatingStaffFriendliness()
        {
            if (ExGrpStaff.Checked)
            {
                return 4;
            }
            if (GoGrpStaff.Checked)
            {
                return 3;
            }
            if (AvgGrpStaff.Checked)
            {
                return 2;
            }
            if (DisGrpStaff.Checked)
            {
                return 1;
            }
            return 0;
        }

        public int RatingCleanliness()
        {
            if (ExGrpClean.Checked)
            {
                return 4;
            }
            if (GoGrpClean.Checked)
            {
                return 3;
            }
            if (AvgGrpClean.Checked)
            {
                return 2;
            }
            if (DisGrpClean.Checked)
            {
                return 1;
            }
            return 0;
        }

        public int RatingOrder()
        {
            if (ExGrpOrder.Checked)
            {
                return 4;
            }
            if (GoGrpOrder.Checked)
            {
                return 3;
            }
            if (AvgGrpOrder.Checked)
            {
                return 2;
            }
            if (DisGrpOrder.Checked)
            {
                return 1;
            }
            return 0;
        }

        public int RatingAmbience()
        {
            if (ExGrpAmb.Checked)
            {
                return 4;
            }
            if (GoGrpAmb.Checked)
            {
                return 3;
            }
            if (AvgGrpAmb.Checked)
            {
                return 2;
            }
            if (DisGrpAmb.Checked)
            {
                return 1;
            }
            return 0;
        }

        public int RatingValue()
        {
            if (ExGrpValue.Checked)
            {
                return 4;
            }
            if (GoGrpValue.Checked)
            {
                return 3;
            }
            if (AvgGrpValue.Checked)
            {
                return 2;
            }
            if (DisGrpValue.Checked)
            {
                return 1;
            }
            return 0;
        }


        public String RatingValue(int rating)
        {
            if (rating == 4)
            {
                return "Excellent";
            }

            if (rating == 3)
            {
                return "Good";
            }

            if (rating == 2)
            {
                return "Average";
            }

            if (rating == 1)
            {
                return "Dissatisifed";
            }
            return "";
        }

        

        private void backtologin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login backtologin = new Login();
            backtologin.ShowDialog();
        }
    }

}
