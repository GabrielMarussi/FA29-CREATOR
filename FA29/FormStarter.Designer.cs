
namespace FA29
{
    partial class FormStarter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCNPJ = new System.Windows.Forms.Button();
            this.BtnOBRA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para quem vai sua FA29:";
            // 
            // BtnCNPJ
            // 
            this.BtnCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnCNPJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnCNPJ.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCNPJ.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCNPJ.Location = new System.Drawing.Point(313, 131);
            this.BtnCNPJ.Name = "BtnCNPJ";
            this.BtnCNPJ.Size = new System.Drawing.Size(75, 23);
            this.BtnCNPJ.TabIndex = 4;
            this.BtnCNPJ.Text = "CNPJ";
            this.BtnCNPJ.UseVisualStyleBackColor = false;
            this.BtnCNPJ.Click += new System.EventHandler(this.BtnCNPJ_Click);
            // 
            // BtnOBRA
            // 
            this.BtnOBRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnOBRA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnOBRA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(80)))), ((int)(((byte)(195)))));
            this.BtnOBRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOBRA.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOBRA.Location = new System.Drawing.Point(407, 131);
            this.BtnOBRA.Name = "BtnOBRA";
            this.BtnOBRA.Size = new System.Drawing.Size(75, 23);
            this.BtnOBRA.TabIndex = 5;
            this.BtnOBRA.Text = "OBRA";
            this.BtnOBRA.UseVisualStyleBackColor = false;
            this.BtnOBRA.Click += new System.EventHandler(this.BtnOBRA_Click);
            // 
            // FormStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOBRA);
            this.Controls.Add(this.BtnCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormStarter";
            this.ShowIcon = false;
            this.Text = "FormStarter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCNPJ;
        private System.Windows.Forms.Button BtnOBRA;
    }
}