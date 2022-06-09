using System;
using System.Windows.Forms;
using ClosedXML;

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
            Form1 Content = new Form1(true);
            Content.ShowDialog();
        }

        private void BtnOBRA_Click(object sender, EventArgs e)
        {
            Form1 Content = new Form1(false);
            Content.ShowDialog();
            
        }
    }
}
