﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace FA29
{
    public partial class Form1 : Form
    {
        private int ItemNum = 2;

        private readonly IXLWorkbook wb;
        private readonly IXLWorksheet ws;

        public Form1(bool Cnpj)
        {

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


            if (Cnpj)
            {
                lblFilCnpj.Text = "CNPJ";
                Controls.Add(lblFilCnpj);
            }
            else
            {



                lblGestor = new Label
                {
                    AutoSize = true,
                    ForeColor = System.Drawing.SystemColors.ControlLight,
                    Location = new System.Drawing.Point(186, 353),
                    Name = "lblGestor",
                    Size = new System.Drawing.Size(38, 13),
                    TabIndex = 29,
                    Text = "Gestor",
                };


                TxtGestor = new TextBox
                {
                    BackColor = System.Drawing.SystemColors.ScrollBar,
                    Location = new System.Drawing.Point(153, 369),
                    Name = "TxtGestor",
                    Size = new System.Drawing.Size(106, 20),
                    TabIndex = 8,
                    Text = "Gestor Contrato",
                };


                lblFilCnpj.Text = "Filial";

                Controls.Add(lblFilCnpj);
                Controls.Add(lblGestor);
                Controls.Add(TxtGestor);

            }
            #endregion

            InitializeComponent();

            DatePick.Value = DateTime.Today;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
             if(TxtDesc.Text != "" | TxtQtd.Text != "" | TxtValueUnit.Text != "" | TxtAppPrev.Text != "")
            {
                Controler.AddLine(ws, TxtDesc.Text, TxtQtd.Text, TxtValueUnit.Text, TxtAppPrev.Text);
                TxtDesc.Text = "";
                TxtQtd.Text = "";
                TxtValueUnit.Text = "";
                TxtAppPrev.Text = "";
                ItemNumber.Text = "Item " + ItemNum++;
                ItemNum = 1;
            }
            else
            {
                MessageBox.Show("Algum dos campos está vazio");
            }
        }

        private void BtnCreate_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (TxtDestinatario.Text != "" | TxtGestor.Text != "" | TxtFilCnpj.Text != "" | TxtNumberFa.Text != "")
            {
                Controler.CreateArchive(ws, TxtDestinatario.Text, TxtGestor.Text, TxtFilCnpj.Text, TxtNumberFa.Text);
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
