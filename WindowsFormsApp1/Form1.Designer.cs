namespace ProModeConnecte
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
            this.labellot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textboxPrix = new System.Windows.Forms.TextBox();
            this.textBoxDesig = new System.Windows.Forms.TextBox();
            this.textBoxttc = new System.Windows.Forms.TextBox();
            this.textBoxtva = new System.Windows.Forms.TextBox();
            this.textBoxqte = new System.Windows.Forms.TextBox();
            this.textBoxtot = new System.Windows.Forms.TextBox();
            this.textBoxprixuni = new System.Windows.Forms.TextBox();
            this.textBoxunit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonsupprimer = new System.Windows.Forms.Button();
            this.buttonajouter = new System.Windows.Forms.Button();
            this.buttonmodifier = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.buttonsharpright = new System.Windows.Forms.Button();
            this.buttonsharpleft = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonright = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.btnRecherch = new System.Windows.Forms.Button();
            this.texttosearch = new System.Windows.Forms.TextBox();
            this.withdesgn = new System.Windows.Forms.RadioButton();
            this.withcode = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxprixtot = new System.Windows.Forms.Label();
            this.addDB = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labellot
            // 
            this.labellot.AutoSize = true;
            this.labellot.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellot.Location = new System.Drawing.Point(600, 43);
            this.labellot.Name = "labellot";
            this.labellot.Size = new System.Drawing.Size(64, 28);
            this.labellot.TabIndex = 0;
            this.labellot.Text = "Lot:";
            this.labellot.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° du prix         :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unité de mesure    :\r\nou de compte  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantité           :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1370, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total TTC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prix unitaire      :\r\n(HT en DH)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1370, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "TVA      :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1370, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total HT :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Désignation        :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textboxPrix
            // 
            this.textboxPrix.Location = new System.Drawing.Point(266, 80);
            this.textboxPrix.Name = "textboxPrix";
            this.textboxPrix.Size = new System.Drawing.Size(245, 26);
            this.textboxPrix.TabIndex = 10;
            this.textboxPrix.TextChanged += new System.EventHandler(this.textboxPrix_TextChanged);
            // 
            // textBoxDesig
            // 
            this.textBoxDesig.Location = new System.Drawing.Point(266, 132);
            this.textBoxDesig.Name = "textBoxDesig";
            this.textBoxDesig.Size = new System.Drawing.Size(245, 26);
            this.textBoxDesig.TabIndex = 11;
            // 
            // textBoxttc
            // 
            this.textBoxttc.Location = new System.Drawing.Point(1498, 177);
            this.textBoxttc.Name = "textBoxttc";
            this.textBoxttc.Size = new System.Drawing.Size(135, 26);
            this.textBoxttc.TabIndex = 14;
            // 
            // textBoxtva
            // 
            this.textBoxtva.Location = new System.Drawing.Point(1498, 143);
            this.textBoxtva.Name = "textBoxtva";
            this.textBoxtva.Size = new System.Drawing.Size(135, 26);
            this.textBoxtva.TabIndex = 15;
            // 
            // textBoxqte
            // 
            this.textBoxqte.Location = new System.Drawing.Point(266, 236);
            this.textBoxqte.Name = "textBoxqte";
            this.textBoxqte.Size = new System.Drawing.Size(245, 26);
            this.textBoxqte.TabIndex = 16;
            this.textBoxqte.TextChanged += new System.EventHandler(this.textBoxqte_TextChanged);
            // 
            // textBoxtot
            // 
            this.textBoxtot.Location = new System.Drawing.Point(1498, 109);
            this.textBoxtot.Name = "textBoxtot";
            this.textBoxtot.Size = new System.Drawing.Size(135, 26);
            this.textBoxtot.TabIndex = 17;
            // 
            // textBoxprixuni
            // 
            this.textBoxprixuni.Location = new System.Drawing.Point(266, 288);
            this.textBoxprixuni.Name = "textBoxprixuni";
            this.textBoxprixuni.Size = new System.Drawing.Size(245, 26);
            this.textBoxprixuni.TabIndex = 18;
            this.textBoxprixuni.TextChanged += new System.EventHandler(this.textBoxprixuni_TextChanged);
            // 
            // textBoxunit
            // 
            this.textBoxunit.Location = new System.Drawing.Point(266, 183);
            this.textBoxunit.Name = "textBoxunit";
            this.textBoxunit.Size = new System.Drawing.Size(245, 26);
            this.textBoxunit.TabIndex = 19;
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
            this.groupBox2.TabIndex = 32;
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
            this.buttonajouter.Click += new System.EventHandler(this.buttonajouter_Click);
            // 
            // buttonmodifier
            // 
            this.buttonmodifier.Location = new System.Drawing.Point(180, 51);
            this.buttonmodifier.Name = "buttonmodifier";
            this.buttonmodifier.Size = new System.Drawing.Size(127, 31);
            this.buttonmodifier.TabIndex = 34;
            this.buttonmodifier.Text = "modifier";
            this.buttonmodifier.UseVisualStyleBackColor = true;
            this.buttonmodifier.Click += new System.EventHandler(this.buttonmodifier_Click);
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
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigation";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(226, 52);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(2, 28);
            this.lblPosition.TabIndex = 38;
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
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
            this.buttonsharpleft.Click += new System.EventHandler(this.buttonsharpleft_Click);
            // 
            // buttonleft
            // 
            this.buttonleft.Location = new System.Drawing.Point(103, 49);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(63, 33);
            this.buttonleft.TabIndex = 36;
            this.buttonleft.Text = "<";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.buttonleft_Click);
            // 
            // buttonright
            // 
            this.buttonright.Location = new System.Drawing.Point(332, 50);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(63, 33);
            this.buttonright.TabIndex = 35;
            this.buttonright.Text = ">";
            this.buttonright.UseVisualStyleBackColor = true;
            this.buttonright.Click += new System.EventHandler(this.buttonright_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(670, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(820, 28);
            this.comboBox2.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 405);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonclear);
            this.groupBox1.Controls.Add(this.btnRecherch);
            this.groupBox1.Controls.Add(this.texttosearch);
            this.groupBox1.Controls.Add(this.withdesgn);
            this.groupBox1.Controls.Add(this.withcode);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(605, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 114);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "rechercher";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(664, 63);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(74, 31);
            this.buttonclear.TabIndex = 4;
            this.buttonclear.Text = "clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click_1);
            // 
            // btnRecherch
            // 
            this.btnRecherch.Location = new System.Drawing.Point(599, 64);
            this.btnRecherch.Name = "btnRecherch";
            this.btnRecherch.Size = new System.Drawing.Size(59, 31);
            this.btnRecherch.TabIndex = 3;
            this.btnRecherch.Text = "...";
            this.btnRecherch.UseVisualStyleBackColor = true;
            this.btnRecherch.Click += new System.EventHandler(this.btnRecherch_Click);
            // 
            // texttosearch
            // 
            this.texttosearch.Location = new System.Drawing.Point(6, 63);
            this.texttosearch.Name = "texttosearch";
            this.texttosearch.Size = new System.Drawing.Size(587, 31);
            this.texttosearch.TabIndex = 2;
            this.texttosearch.TextChanged += new System.EventHandler(this.texttosearch_TextChanged);
            // 
            // withdesgn
            // 
            this.withdesgn.AutoSize = true;
            this.withdesgn.Location = new System.Drawing.Point(173, 30);
            this.withdesgn.Name = "withdesgn";
            this.withdesgn.Size = new System.Drawing.Size(156, 27);
            this.withdesgn.TabIndex = 1;
            this.withdesgn.TabStop = true;
            this.withdesgn.Text = "Désignation";
            this.withdesgn.UseVisualStyleBackColor = true;
            this.withdesgn.CheckedChanged += new System.EventHandler(this.withdesgn_CheckedChanged);
            // 
            // withcode
            // 
            this.withcode.AutoSize = true;
            this.withcode.Location = new System.Drawing.Point(8, 30);
            this.withcode.Name = "withcode";
            this.withcode.Size = new System.Drawing.Size(145, 27);
            this.withcode.TabIndex = 0;
            this.withcode.TabStop = true;
            this.withcode.Text = "N° du prix";
            this.withcode.UseVisualStyleBackColor = true;
            this.withcode.CheckedChanged += new System.EventHandler(this.withcode_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prix total         :\r\n(HT en DH) ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxprixtot
            // 
            this.textBoxprixtot.AutoSize = true;
            this.textBoxprixtot.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxprixtot.Location = new System.Drawing.Point(266, 339);
            this.textBoxprixtot.Name = "textBoxprixtot";
            this.textBoxprixtot.Size = new System.Drawing.Size(0, 23);
            this.textBoxprixtot.TabIndex = 39;
            // 
            // addDB
            // 
            this.addDB.Font = new System.Drawing.Font("Consolas", 10F);
            this.addDB.Location = new System.Drawing.Point(1498, 43);
            this.addDB.Name = "addDB";
            this.addDB.Size = new System.Drawing.Size(135, 31);
            this.addDB.TabIndex = 5;
            this.addDB.Text = "importer...";
            this.addDB.UseVisualStyleBackColor = true;
            this.addDB.Click += new System.EventHandler(this.addDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1751, 721);
            this.Controls.Add(this.addDB);
            this.Controls.Add(this.textBoxprixtot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.Controls.Add(this.labellot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textboxPrix;
        private System.Windows.Forms.TextBox textBoxDesig;
        private System.Windows.Forms.TextBox textBoxttc;
        private System.Windows.Forms.TextBox textBoxtva;
        private System.Windows.Forms.TextBox textBoxqte;
        private System.Windows.Forms.TextBox textBoxtot;
        private System.Windows.Forms.TextBox textBoxprixuni;
        private System.Windows.Forms.TextBox textBoxunit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonsupprimer;
        private System.Windows.Forms.Button buttonajouter;
        private System.Windows.Forms.Button buttonmodifier;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button buttonsharpright;
        private System.Windows.Forms.Button buttonsharpleft;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecherch;
        private System.Windows.Forms.TextBox texttosearch;
        private System.Windows.Forms.RadioButton withdesgn;
        private System.Windows.Forms.RadioButton withcode;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textBoxprixtot;
        private System.Windows.Forms.Button addDB;
    }
}

