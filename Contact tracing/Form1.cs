namespace Contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\JULIA-ANN\source\repos\Contact Tracing Information\" + fnametxtbox.Text + " " + mnametxtbox.Text + " " + lnametxtbox.Text + " "+ snametxtbox.Text + ".txt");
            file.WriteLine("CONTACT TRACING");
            file.WriteLine("Date: " + datetimetxt.Text);
            file.WriteLine("");
            file.WriteLine("BASIC INFORMATION");
            file.WriteLine("Name: " + fnametxtbox.Text + " " + mnametxtbox.Text + " " + lnametxtbox.Text + " " + snametxtbox.Text);
            file.WriteLine("Age: " + agenumericud.Text);
            file.WriteLine("Sex: " + sextxtbox.Text);
            file.WriteLine("Phone Number: " + pnumtxtbox.Text);
            file.WriteLine("Personal Email: " + pemailltxtbox.Text);
            file.WriteLine("Home Address: " + sttxtbox.Text + ", " + citytxtbox.Text + ", " + sprovtxtbox.Text + ", " + pzipctxtbox.Text);
            file.WriteLine("");
            file.WriteLine("Have you been to one of the COVID-19 affected city in the last 14 days?");
            file.WriteLine("Answer: " + q1txtbox.Text);
            file.WriteLine("Have you been in a close contact with a confirmes case of coronavirus?");
            file.WriteLine("Answer: " + q2txtbox.Text);
            file.WriteLine("Are you currently experiencing symptoms (cough,shortness of breath, fever)");
            file.WriteLine("Answer: " + q3txtbox.Text);
            file.WriteLine("");
            file.WriteLine("EMERGENCY CONTACT");
            file.WriteLine("Emergency Contact Name: " + ecfnametxtbox.Text + " " + ecmnametxtbox.Text + " " + eclnametxtbox.Text + " " + ecsnametxtbox.Text);
            file.WriteLine("Contact Number: " + ephonecontxtbox.Text);
            file.WriteLine("Relationship: " + ecrelationtxtbox.Text);
            file.WriteLine("");
            file.WriteLine("We will not, in any circumstances, share your personal information with other individuals or ");
            file.WriteLine("organizations without your permission, including public organizations, corporations or individuals,");
            file.WriteLine("except when applicable by law. Agree or Disagree?");
            file.WriteLine("Answer: " + ansconsenttxtbox.Text);
            file.WriteLine("______________________________________________________________________");
            file.Close();
            MessageBox.Show("Thank you for filling out your information!");
            fnametxtbox.Text = "";
            snametxtbox.Text = "";
            mnametxtbox.Text = "";
            lnametxtbox.Text = "";
            agenumericud.Text = "0";
            sextxtbox.Text = "";
            pnumtxtbox.Text = "";
            pemailltxtbox.Text = "";
            sttxtbox.Text = "";
            citytxtbox.Text = "";
            sprovtxtbox.Text = "";
            pzipctxtbox.Text = "";
            q1txtbox.Text = "";
            q2txtbox.Text = "";
            q3txtbox.Text = "";
            ecfnametxtbox.Text = "";
            ecmnametxtbox.Text = "";
            eclnametxtbox.Text = "";
            ecsnametxtbox.Text = "";
            ephonecontxtbox.Text = "";
            ecrelationtxtbox.Text = "";
            ansconsenttxtbox.Text = "";
        }

        private void AdminLoginbutton_Click(object sender, EventArgs e)
        {
            if (Admintxtbox.Text == "Contact Information")
            {
                this.Hide();
                Form2 accessadmin = new Form2();
                accessadmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
                Admintxtbox.Text = "";
            } 
        }

        private void snametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QRCbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 qrgenerate = new Form4();
            qrgenerate.ShowDialog();
            this.Show();
        }

        private void QRSbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 qrscan = new Form5();
            qrscan.ShowDialog();
            this.Show();
        }
    }
}