using ClosedXML.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FA29
{
    public partial class Form1 : Form
    {
        private readonly bool Cnpj;
        private int ItemNum = 2;

        private readonly IXLWorkbook wb;
        private readonly IXLWorksheet ws;

        public Form1(bool Cnpj)
        {
            this.Cnpj = Cnpj;

            wb = new XLWorkbook();
            ws = wb.Worksheets.Add("Plan1");

            #region New Objects
            lblFilCnpj = new Label
            {
                AutoSize = true,
                ForeColor = SystemColors.ControlLight,
                Location = new Point(58, 353),
                Name = "lblFilCnpj",
                Size = new Size(27, 13)
            };


            lblFilCnpj.Text = Cnpj ? lblFilCnpj.Text = "CNPJ" : lblFilCnpj.Text = "Filial";

            Controls.Add(lblFilCnpj); ;
            #endregion

            InitializeComponent();

            DatePick.Value = DateTime.Today;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (TxtDesc.Text != "" && TxtQtd.Text != "" && TxtValueUnit.Text != "" && TxtAppPrev.Text != "")
            {
                Controler.AddLine(ws, TxtDesc.Text, TxtQtd.Text, TxtValueUnit.Text, TxtAppPrev.Text);
                TxtDesc.Text = "";
                TxtQtd.Text = "";
                TxtValueUnit.Text = "";
                TxtAppPrev.Text = "";
                ItemNumber.Text = "Item " + ItemNum++;
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio");
            }
        }

        private void BtnCreate_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (TxtDestinatario.Text != "" && TxtFilCnpj.Text != "" && TxtNumberFa.Text != "")
            {
                Controler.CreateArchive(Cnpj,ws, TxtDestinatario.Text, TxtFilCnpj.Text, TxtNumberFa.Text, DatePick.Text);
                TxtDestinatario.Text = "";
                TxtFilCnpj.Text = "";
                TxtNumberFa.Text = "";
                DatePick.Value = DateTime.Today;
                ItemNum = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(sfd.FileName + ".xlsx");
                };
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio");
            }


        }
    }
}
