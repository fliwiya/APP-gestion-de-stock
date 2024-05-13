namespace WindowsFormsApp1
{
    partial class Form2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.buttonsharpright = new System.Windows.Forms.Button();
            this.buttonsharpleft = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonright = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonsupprimer = new System.Windows.Forms.Button();
            this.buttonajouter = new System.Windows.Forms.Button();
            this.buttonmodifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.texttosearch = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxprixtot = new System.Windows.Forms.TextBox();
            this.textBoxunit = new System.Windows.Forms.TextBox();
            this.textBoxprixuni = new System.Windows.Forms.TextBox();
            this.textBoxtot = new System.Windows.Forms.TextBox();
            this.textBoxqte = new System.Windows.Forms.TextBox();
            this.textBoxtva = new System.Windows.Forms.TextBox();
            this.textBoxttc = new System.Windows.Forms.TextBox();
            this.textBoxDesig = new System.Windows.Forms.TextBox();
            this.textboxPrix = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPosition);
            this.groupBox3.Controls.Add(this.buttonsharpright);
            this.groupBox3.Controls.Add(this.buttonsharpleft);
            this.groupBox3.Controls.Add(this.buttonleft);
            this.groupBox3.Controls.Add(this.buttonright);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 113);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigation";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(226, 52);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(38, 28);
            this.lblPosition.TabIndex = 38;
            this.lblPosition.Text = "uh";
            // 
            // buttonsharpright
            // 
            this.buttonsharpright.Location = new System.Drawing.Point(406, 50);
            this.buttonsharpright.Name = "buttonsharpright";
            this.buttonsharpright.Size = new System.Drawing.Size(63, 33);
            this.buttonsharpright.TabIndex = 37;
            this.buttonsharpright.Text = ">|";
            this.buttonsharpright.UseVisualStyleBackColor = true;
            this.buttonsharpright.Click += new System.EventHandler(this.buttonsharpright_Click);
            // 
            // buttonsharpleft
            // 
            this.buttonsharpleft.Location = new System.Drawing.Point(34, 50);
            this.buttonsharpleft.Name = "buttonsharpleft";
            this.buttonsharpleft.Size = new System.Drawing.Size(63, 33);
            this.buttonsharpleft.TabIndex = 34;
            this.buttonsharpleft.Text = "|<";
            this.buttonsharpleft.UseVisualStyleBackColor = true;
            // 
            // buttonleft
            // 
            this.buttonleft.Location = new System.Drawing.Point(103, 49);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(63, 33);
            this.buttonleft.TabIndex = 36;
            this.buttonleft.Text = "<";
            this.buttonleft.UseVisualStyleBackColor = true;
            // 
            // buttonright
            // 
            this.buttonright.Location = new System.Drawing.Point(332, 50);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(63, 33);
            this.buttonright.TabIndex = 35;
            this.buttonright.Text = ">";
            this.buttonright.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonsupprimer);
            this.groupBox2.Controls.Add(this.buttonajouter);
            this.groupBox2.Controls.Add(this.buttonmodifier);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 114);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mettre à jour";
            // 
            // buttonsupprimer
            // 
            this.buttonsupprimer.Location = new System.Drawing.Point(342, 51);
            this.buttonsupprimer.Name = "buttonsupprimer";
            this.buttonsupprimer.Size = new System.Drawing.Size(127, 31);
            this.buttonsupprimer.TabIndex = 35;
            this.buttonsupprimer.Text = "supprimer";
            this.buttonsupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonajouter
            // 
            this.buttonajouter.Location = new System.Drawing.Point(19, 50);
            this.buttonajouter.Name = "buttonajouter";
            this.buttonajouter.Size = new System.Drawing.Size(129, 32);
            this.buttonajouter.TabIndex = 33;
            this.buttonajouter.Text = "ajouter";
            this.buttonajouter.UseVisualStyleBackColor = true;
            // 
            // buttonmodifier
            // 
            this.buttonmodifier.Location = new System.Drawing.Point(180, 51);
            this.buttonmodifier.Name = "buttonmodifier";
            this.buttonmodifier.Size = new System.Drawing.Size(127, 31);
            this.buttonmodifier.TabIndex = 34;
            this.buttonmodifier.Text = "modifier";
            this.buttonmodifier.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.texttosearch);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(552, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 114);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "rechercher";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(510, 63);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 31);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "...";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // texttosearch
            // 
            this.texttosearch.Location = new System.Drawing.Point(6, 63);
            this.texttosearch.Name = "texttosearch";
            this.texttosearch.Size = new System.Drawing.Size(489, 31);
            this.texttosearch.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(429, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(156, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Désignation";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "N° du prix";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(552, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(612, 324);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "";
            // 
            // textBoxprixtot
            // 
            this.textBoxprixtot.Location = new System.Drawing.Point(266, 340);
            this.textBoxprixtot.Name = "textBoxprixtot";
            this.textBoxprixtot.Size = new System.Drawing.Size(245, 26);
            this.textBoxprixtot.TabIndex = 52;
            this.textBoxprixtot.TextChanged += new System.EventHandler(this.textBoxprixtot_TextChanged);
            // 
            // textBoxunit
            // 
            this.textBoxunit.Location = new System.Drawing.Point(266, 183);
            this.textBoxunit.Name = "textBoxunit";
            this.textBoxunit.Size = new System.Drawing.Size(245, 26);
            this.textBoxunit.TabIndex = 51;
            // 
            // textBoxprixuni
            // 
            this.textBoxprixuni.Location = new System.Drawing.Point(266, 288);
            this.textBoxprixuni.Name = "textBoxprixuni";
            this.textBoxprixuni.Size = new System.Drawing.Size(245, 26);
            this.textBoxprixuni.TabIndex = 50;
            // 
            // textBoxtot
            // 
            this.textBoxtot.Location = new System.Drawing.Point(684, 423);
            this.textBoxtot.Name = "textBoxtot";
            this.textBoxtot.Size = new System.Drawing.Size(135, 26);
            this.textBoxtot.TabIndex = 49;
            // 
            // textBoxqte
            // 
            this.textBoxqte.Location = new System.Drawing.Point(266, 236);
            this.textBoxqte.Name = "textBoxqte";
            this.textBoxqte.Size = new System.Drawing.Size(245, 26);
            this.textBoxqte.TabIndex = 48;
            // 
            // textBoxtva
            // 
            this.textBoxtva.Location = new System.Drawing.Point(684, 457);
            this.textBoxtva.Name = "textBoxtva";
            this.textBoxtva.Size = new System.Drawing.Size(135, 26);
            this.textBoxtva.TabIndex = 47;
            // 
            // textBoxttc
            // 
            this.textBoxttc.Location = new System.Drawing.Point(684, 491);
            this.textBoxttc.Name = "textBoxttc";
            this.textBoxttc.Size = new System.Drawing.Size(135, 26);
            this.textBoxttc.TabIndex = 46;
            // 
            // textBoxDesig
            // 
            this.textBoxDesig.Location = new System.Drawing.Point(266, 132);
            this.textBoxDesig.Name = "textBoxDesig";
            this.textBoxDesig.Size = new System.Drawing.Size(245, 26);
            this.textBoxDesig.TabIndex = 45;
            // 
            // textboxPrix
            // 
            this.textboxPrix.Location = new System.Drawing.Point(266, 80);
            this.textboxPrix.Name = "textboxPrix";
            this.textboxPrix.Size = new System.Drawing.Size(245, 26);
            this.textboxPrix.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 23);
            this.label10.TabIndex = 43;
            this.label10.Text = "Désignation        :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Total HT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "TVA      :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 46);
            this.label7.TabIndex = 40;
            this.label7.Text = "Prix total         :\r\n(HT en DH) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 46);
            this.label6.TabIndex = 39;
            this.label6.Text = "Prix unitaire      :\r\n(HT en DH)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total TTC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quantité           :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 46);
            this.label3.TabIndex = 36;
            this.label3.Text = "Unité de mesure    :\r\nou de compte  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "N° du prix         :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(649, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(515, 28);
            this.comboBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(605, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 26);
            this.textBox1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Lot:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1226, 749);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxprixtot);
            this.Controls.Add(this.textBoxunit);
            this.Controls.Add(this.textBoxprixuni);
            this.Controls.Add(this.textBoxtot);
            this.Controls.Add(this.textBoxqte);
            this.Controls.Add(this.textBoxtva);
            this.Controls.Add(this.textBoxttc);
            this.Controls.Add(this.textBoxDesig);
            this.Controls.Add(this.textboxPrix);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button buttonsharpright;
        private System.Windows.Forms.Button buttonsharpleft;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonsupprimer;
        private System.Windows.Forms.Button buttonajouter;
        private System.Windows.Forms.Button buttonmodifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox texttosearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxprixtot;
        private System.Windows.Forms.TextBox textBoxunit;
        private System.Windows.Forms.TextBox textBoxprixuni;
        private System.Windows.Forms.TextBox textBoxtot;
        private System.Windows.Forms.TextBox textBoxqte;
        private System.Windows.Forms.TextBox textBoxtva;
        private System.Windows.Forms.TextBox textBoxttc;
        private System.Windows.Forms.TextBox textBoxDesig;
        private System.Windows.Forms.TextBox textboxPrix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}