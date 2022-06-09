
namespace FA29
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumberFa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDestinatario = new System.Windows.Forms.TextBox();
            this.TxtFilCnpj = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtValueUnit = new System.Windows.Forms.TextBox();
            this.TxtQtd = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.ItemNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtAppPrev = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Numero da FA:";
            // 
            // TxtNumberFa
            // 
            this.TxtNumberFa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtNumberFa.Location = new System.Drawing.Point(117, 8);
            this.TxtNumberFa.Name = "TxtNumberFa";
            this.TxtNumberFa.Size = new System.Drawing.Size(76, 20);
            this.TxtNumberFa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(297, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Destinatário";
            // 
            // TxtDestinatario
            // 
            this.TxtDestinatario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtDestinatario.Location = new System.Drawing.Point(273, 369);
            this.TxtDestinatario.Name = "TxtDestinatario";
            this.TxtDestinatario.Size = new System.Drawing.Size(113, 20);
            this.TxtDestinatario.TabIndex = 9;
            // 
            // TxtFilCnpj
            // 
            this.TxtFilCnpj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtFilCnpj.Location = new System.Drawing.Point(21, 369);
            this.TxtFilCnpj.Name = "TxtFilCnpj";
            this.TxtFilCnpj.Size = new System.Drawing.Size(117, 20);
            this.TxtFilCnpj.TabIndex = 7;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelDate.Location = new System.Drawing.Point(506, 29);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(91, 13);
            this.LabelDate.TabIndex = 104;
            this.LabelDate.Text = "Data de liberação";
            // 
            // DatePick
            // 
            this.DatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick.Location = new System.Drawing.Point(509, 45);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(103, 20);
            this.DatePick.TabIndex = 10;
            this.DatePick.Value = new System.DateTime(2021, 3, 15, 0, 0, 0, 0);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.Location = new System.Drawing.Point(511, 221);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtValueUnit
            // 
            this.TxtValueUnit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtValueUnit.Location = new System.Drawing.Point(11, 171);
            this.TxtValueUnit.Name = "TxtValueUnit";
            this.TxtValueUnit.Size = new System.Drawing.Size(67, 20);
            this.TxtValueUnit.TabIndex = 4;
            // 
            // TxtQtd
            // 
            this.TxtQtd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtQtd.Location = new System.Drawing.Point(11, 122);
            this.TxtQtd.Name = "TxtQtd";
            this.TxtQtd.Size = new System.Drawing.Size(67, 20);
            this.TxtQtd.TabIndex = 3;
            // 
            // TxtDesc
            // 
            this.TxtDesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtDesc.Location = new System.Drawing.Point(11, 67);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(199, 20);
            this.TxtDesc.TabIndex = 2;
            // 
            // ItemNumber
            // 
            this.ItemNumber.AutoSize = true;
            this.ItemNumber.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNumber.ForeColor = System.Drawing.Color.White;
            this.ItemNumber.Location = new System.Drawing.Point(258, 11);
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Size = new System.Drawing.Size(100, 24);
            this.ItemNumber.TabIndex = 18;
            this.ItemNumber.Text = "Item 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(8, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Descrição";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(8, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(8, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Valor Unitário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(219, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Aplicação Prevista";
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreate.Location = new System.Drawing.Point(495, 382);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(117, 46);
            this.BtnCreate.TabIndex = 11;
            this.BtnCreate.Text = "Criar";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click_1);
            // 
            // TxtAppPrev
            // 
            this.TxtAppPrev.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtAppPrev.Location = new System.Drawing.Point(222, 67);
            this.TxtAppPrev.Name = "TxtAppPrev";
            this.TxtAppPrev.Size = new System.Drawing.Size(364, 124);
            this.TxtAppPrev.TabIndex = 5;
            this.TxtAppPrev.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.ItemNumber);
            this.panel1.Controls.Add(this.TxtAppPrev);
            this.panel1.Controls.Add(this.TxtDesc);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtQtd);
            this.panel1.Controls.Add(this.TxtValueUnit);
            this.panel1.Location = new System.Drawing.Point(11, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 270);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.DatePick);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.TxtFilCnpj);
            this.Controls.Add(this.TxtDestinatario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumberFa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 489);
            this.MinimumSize = new System.Drawing.Size(640, 489);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FA29 CREATOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumberFa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilCnpj;
        private System.Windows.Forms.TextBox TxtDestinatario;
        private System.Windows.Forms.TextBox TxtFilCnpj;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.DateTimePicker DatePick;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtValueUnit;
        private System.Windows.Forms.TextBox TxtQtd;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label ItemNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label lblGestor;
        private System.Windows.Forms.TextBox TxtGestor;
        private System.Windows.Forms.RichTextBox TxtAppPrev;
        private System.Windows.Forms.Panel panel1;
    }
}

