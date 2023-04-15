using System.Xml.Linq;

namespace asiignment4lecture13second_attempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnationalnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string name;
            int nationalnum;

            if (string.IsNullOrEmpty(txtfullname.Text) || string.IsNullOrEmpty(txtnationalnum.Text))
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                name = txtfullname.Text;
                nationalnum = int.Parse(txtnationalnum.Text);
                MessageBox.Show("Name: " + name + "\n" + "Age: " + nationalnum.ToString());
            }
        }
    }
}