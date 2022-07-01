using System;
using System.Windows.Forms;


namespace FA29
{
    public partial class FormStarter : Form
    {

        public FormStarter()
        {
            InitializeComponent();
        }

        private void BtnCNPJ_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 Content = new Form1(true);
            Content.ShowDialog();
            Application.Exit();
        }

        private void BtnOBRA_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 Content = new Form1(false);
            Content.ShowDialog();
            Application.Exit();
        }
    }
}
