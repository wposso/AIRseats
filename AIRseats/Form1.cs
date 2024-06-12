using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AIRseats
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=mydatabase; integrated security= true");
        Dictionary<string, Label> labelMap = new Dictionary<string, Label>();

        public Form1()
        {
            InitializeComponent();

            labelMap.Add("co01", lbl1);
            labelMap.Add("co02", lbl2);
            labelMap.Add("co03", lbl3);

            //Suscribe to events
            this.Load += new EventHandler(preLoad);
            btnasigne.Click += new EventHandler(preLoad);
            btnfree.Click += new EventHandler(preLoad);
            btnasigne.DoubleClick += new EventHandler(btnasigne_Dobleclick);
            this.Load += new EventHandler(txtload_Load);
            btnasigne.Click += new EventHandler(txtload_Load);
            btnfree.Click += new EventHandler(txtload_Load);
            this.Load += new EventHandler(txtname1_Load);
            btnasigne.Click += new EventHandler(txtname1_Load);
            btnfree.Click += new EventHandler(txtname1_Load);
            btnasigne.Click += new EventHandler(txtname2_Load);
            btnasigne.Click += new EventHandler(txtname3_Load);
            btnfree.Click += new EventHandler(txtname3_Load);
            btnfree.Click += new EventHandler(txtname2_Load);
            this.Load += new EventHandler(txtname3_Load);
            this.Load += new EventHandler(txtname2_Load);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preLoad(sender, e);
        }

        public void preLoad(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                string command = ("select code,isbusy from airplane");
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    string code = read["code"].ToString();
                    int isbusy = Convert.ToInt32(read["isbusy"]);

                    Label lbl = labelMap[code];
                    if (isbusy == 1)
                    {
                        lbl.ForeColor = Color.Red;
                        int result = 1;

                    }
                    else
                    {
                        lbl.ForeColor = Color.Green;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an critical error with database");
            }

            connection.Close();
        }

        private void btnasigne_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcode.Text))
            {
                MessageBox.Show("Please enter a valid code");
                return;
            }

            connection.Open();

            try
            {
                string command = ("update airplane set isbusy=1, passenger='"+txtname.Text+"' where code='" + txtcode.Text + "'");
                SqlCommand cmd2 = new SqlCommand(command, connection);
                cmd2.ExecuteNonQuery();
                txtname.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an critical error with database");
                txtname.Clear();
            }


            connection.Close();

        }

        private void btnfree_Click(object sender, EventArgs e)
        {


            connection.Open();

            try
            {
                if (!string.IsNullOrEmpty(txtcode.Text))
                {
                    string command = ("update airplane set isbusy=0, passenger = '' where code='" + txtcode.Text + "'");
                    SqlCommand cmd = new SqlCommand(command, connection);
                    cmd.ExecuteNonQuery();
                    txtname.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid code");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an critical error with database", ex.Message);
                txtname.Clear();
            }
            connection.Close();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            txtcode.Text = "co03";

        }
        private void lbl1_Click(object sender, EventArgs e)
        {
            txtcode.Text = "co01";

        }
        private void lbl2_Click(object sender, EventArgs e)
        {
            txtcode.Text = "co02";

        }

        private void btnasigne_Dobleclick(object sender, EventArgs e)
        {
            MessageBox.Show("Deje de dar tanto click");
        }

        private void txtload_Load(object sender, EventArgs e)
        {
            connection.Open();
            string command = "select count(*) from airplane where isbusy=1";
            SqlCommand cmd = new SqlCommand(command, connection);
            int count = (int)cmd.ExecuteScalar();

            connection.Close();
            txtload.Text = count.ToString();
        }

        private void txtname1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtname1_Load(object sender, EventArgs e) 
        {
            connection.Open();

            string command = ("select passenger from airplane where code ='co01'");
            SqlCommand cmd = new SqlCommand(command, connection);
            string name = (string)cmd.ExecuteScalar();
            connection.Close();
            txtname1.Text = name.ToString();
        }

        private void txtname2_Load(object sender, EventArgs e) 
        {
            connection.Open();
            string command = ("select passenger from airplane where code='co02'");
            SqlCommand cmd = new SqlCommand(command, connection);
            string name = (string)cmd.ExecuteScalar();
            connection.Close();
            txtname2.Text = name.ToString();
        }

        private void txtname3_Load(object sender, EventArgs e) 
        {
            connection.Open();
            string command = ("select passenger from airplane where code='co03'");
            SqlCommand cmd = new SqlCommand(command, connection);
            string name = (string)cmd.ExecuteScalar();
            connection.Close();
            txtname3.Text = name.ToString();
        }
    }
}
