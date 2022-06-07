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
            StreamWriter file = new StreamWriter(@"C:\Users\JULIA-ANN\Desktop\Contact Tracing.txt");
            file.WriteLine("CONTACT TRACING");
            file.WriteLine("Date: " + datetimetxt.Text);
            file.WriteLine("Name: " + fnametxtbox.Text + " " + mnametxtbox.Text + " " + lnametxtbox.Text + " " + snametxtbox.Text);
            file.WriteLine("Age: " + agenumericud.Text);
            file.WriteLine("Sex: " + sextxtbox.Text);
            file.WriteLine("Phone Number: " + pnumtxtbox.Text);
            file.WriteLine("Personal Email: " + pemailltxtbox.Text);
            file.Close();
        }
    }
}