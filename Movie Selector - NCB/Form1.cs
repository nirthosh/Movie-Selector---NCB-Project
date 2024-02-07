using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Movie_Selector___NCB
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(txtAge.Text);
                if (age > 0)
                {
                    if (age >= 25)
                    {
                        lblResult.Text = "All Movies";
                        lblResult.BackColor = Color.Lime;
                    }
                    else if ((age == 24) | (age >= 14))
                    {
                        lblResult.Text = "Kids Movies";
                        lblResult.BackColor = Color.Gold;
                    }
                    else if ((age == 13) | (age >= 2))
                    {
                        lblResult.Text = "Cartoons";
                        lblResult.BackColor = Color.Pink;
                    }
                    else
                    {
                        lblResult.Text = "no screen time for the babies";
                        lblResult.BackColor = Color.Red;

                    }

                }
                else
                {
                    lblResult.Text = "Invalid number";
                    lblResult.BackColor = Color.Gainsboro;
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblResult.Text = " ";
            txtAge.Text = "";
            lblResult.BackColor = Color.Gainsboro;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}