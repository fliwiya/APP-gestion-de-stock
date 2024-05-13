namespace WindowsFormsApp1
{
    partial class Form3
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
            this.backtoForm1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxunit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxprixuni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxqte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDesig = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxPrix = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.validadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backtoForm1
            // 
            this.backtoForm1.Font = new System.Drawing.Font("Consolas", 10F);
            this.backtoForm1.Location = new System.Drawing.Point(231, 428);
            this.backtoForm1.Name = "backtoForm1";
            this.backtoForm1.Size = new System.Drawing.Size(129, 51);
            this.backtoForm1.TabIndex = 8;
            this.backtoForm1.Text = "retour";
            this.backtoForm1.UseVisualStyleBackColor = true;
            this.backtoForm1.Click += new System.EventHandler(this.backtoForm1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxunit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxprixuni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxqte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDesig);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textboxPrix);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.groupBox1.Location = new System.Drawing.Point(215, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 333);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter produit";
            // 
            // textBoxunit
            // 
            this.textBoxunit.Location = new System.Drawing.Point(421, 144);
            this.textBoxunit.Name = "textBoxunit";
            this.textBoxunit.Size = new System.Drawing.Size(187, 31);
            this.textBoxunit.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "N° du prix         :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxprixuni
            // 
            this.textBoxprixuni.Location = new System.Drawing.Point(421, 249);
            this.textBoxprixuni.Name = "textBoxprixuni";
            this.textBoxprixuni.Size = new System.Drawing.Size(187, 31);
            this.textBoxprixuni.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 46);
            this.label3.TabIndex = 21;
            this.label3.Text = "Unité de mesure    :\r\nou de compte  ";
            // 
            // textBoxqte
            // 
            this.textBoxqte.Location = new System.Drawing.Point(421, 197);
            this.textBoxqte.Name = "textBoxqte";
            this.textBoxqte.Size = new System.Drawing.Size(187, 31);
            this.textBoxqte.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantité           :";
            // 
            // textBoxDesig
            // 
            this.textBoxDesig.Location = new System.Drawing.Point(421, 93);
            this.textBoxDesig.Name = "textBoxDesig";
            this.textBoxDesig.Size = new System.Drawing.Size(187, 31);
            this.textBoxDesig.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 46);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prix unitaire      :\r\n(HT en DH)";
            // 
            // textboxPrix
            // 
            this.textboxPrix.Location = new System.Drawing.Point(421, 41);
            this.textboxPrix.Name = "textboxPrix";
            this.textboxPrix.Size = new System.Drawing.Size(187, 31);
            this.textboxPrix.TabIndex = 25;
            this.textboxPrix.TextChanged += new System.EventHandler(this.textboxPrix_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Désignation        :";
            // 
            // validadd
            // 
            this.validadd.Font = new System.Drawing.Font("Consolas", 10F);
            this.validadd.Location = new System.Drawing.Point(847, 426);
            this.validadd.Name = "validadd";
            this.validadd.Size = new System.Drawing.Size(116, 53);
            this.validadd.TabIndex = 6;
            this.validadd.Text = "Ok.";
            this.validadd.UseVisualStyleBackColor = true;
            this.validadd.Click += new System.EventHandler(this.validadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.Location = new System.Drawing.Point(732, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "terminer:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 513);
            this.Controls.Add(this.backtoForm1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.validadd);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoForm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxunit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxprixuni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxqte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDesig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxPrix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button validadd;
        private System.Windows.Forms.Label label1;
    }
}