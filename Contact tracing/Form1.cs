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
            StreamWriter file = new StreamWriter(@"C:\Users\JULIA-ANN\source\repos\Contact Tracing Information\" + ".txt");
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
            file.WriteLine("We will not, in any circumstances, share your personal information with other individuals or organizations without your permission, including public organizations, corporations or individuals, except when applicable by law.");
            file.WriteLine("Agree or Disagree?");
            file.WriteLine("Answer: " + ansconsenttxtbox.Text);
            file.Close();
            MessageBox.Show("Thank you for filling out your information!");
        }

        private void AdminLoginbutton_Click(object sender, EventArgs e)
        {
            if (Admintxtbox.Text == "Contact Information")
            {
                Form2 accessadmin = new Form2();
                accessadmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            } 
        }
    }
}