using ProModeConnecte;
using System;

using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;
//using System.ServiceModel.Channels;
using System.Reflection;
//using Newtonsoft.Json.Linq;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using WindowsFormsApp1;

namespace ProModeConnecte
{
    public partial class Form1 : Form
    {
        SqlConnection cx = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        DataTable dt;
        int pos = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cx = new SqlConnection("Data Source=.;Initial Catalog=dbStock;Integrated Security=True");
            cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, QteStock, PrixU, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau", cx);
            adapter = new SqlDataAdapter(cmd);
            Affichage(pos);
            TotalMontant();



            //try
            //{
            //    cx.Open();
            //    dt = new DataTable();
            //    adapter.Fill(dt);
            //    pos = 0;

            //    textboxPrix.Text = dt.Rows[pos][0].ToString();
            //    textBoxDesig.Text = dt.Rows[pos][1].ToString();
            //    textBoxunit.Text = dt.Rows[pos][2].ToString();
            //    textBoxqte.Text = dt.Rows[pos][3].ToString();
            //    textBoxprixuni.Text = dt.Rows[pos][4].ToString();
            //    textBoxprixtot.Text = dt.Rows[pos][5].ToString();
            //    dataGridView1.DataSource = dt;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
            //finally
            //{
            //    cx.Close();
            //}
        }
        private bool existe(int code)
        {

            cmd = new SqlCommand("select*from stockBureau", cx);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable(); adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                if (code == int.Parse(row[0].ToString()))
                    return true;

            } 

            return false;
        }
        private void btnInserer_Click_1(object sender, EventArgs e)
        {
            //int code;
            //int res = 0;
            //if (!int.TryParse(textboxPrix.Text, out code))
            //{
            //    MessageBox.Show("Le code doit être numérique ");
            //    textboxPrix.Focus();
            //    return;


            //}
            //if (existe(code))
            //{

            //    MessageBox.Show("code existe déjà");
            //    textboxPrix.Focus();
            //    return;
            //}
            //else
            //{
            //    cx.Open();
            //    cmd = new SqlCommand("insert into stock(NumPrd,Designation,PrixU,QteStock) values(@code,@desig, @uni ,@pu,@qte)");
            //    cmd.Connection = cx;
            //    cmd.Parameters.AddWithValue("@code", int.Parse(textboxPrix.Text));
            //    cmd.Parameters.AddWithValue("@desig", textBoxDesig.Text);
            //    cmd.Parameters.AddWithValue("@uni", float.Parse(textBoxunit.Text));
            //    cmd.Parameters.AddWithValue("@pu", float.Parse(textBoxprixuni.Text));
            //    cmd.Parameters.AddWithValue("@qte", int.Parse(textBoxqte.Text));
            //    res = cmd.ExecuteNonQuery();
            //}
            //if ((res > 0))
            //{
            //    MessageBox.Show("Insertion réussie");
            //}
            //else
            //{
            //    MessageBox.Show("Insertion echouée");
            //}
            //btnActualiser_Click(this, null);
            //cx.Close();



        }
        private void Affichage(int pos)
        {
            cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, QteStock, PrixU, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau", cx);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);


            textboxPrix.Text = dt.Rows[pos][0].ToString();
            textBoxDesig.Text = dt.Rows[pos][1].ToString();
            textBoxunit.Text = dt.Rows[pos][2].ToString();
            textBoxqte.Text = dt.Rows[pos][3].ToString();
            textBoxprixuni.Text = dt.Rows[pos][4].ToString();
            textBoxprixtot.Text = dt.Rows[pos][5].ToString();
            dataGridView1.DataSource = dt;
            lblPosition.Text = (pos + 1).ToString() + "/" + (dt.Rows.Count).ToString();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[pos].Selected = true;

            

        }
        private void TotalMontant()
        {
            double total = 0;
            foreach (DataRow line in dt.Rows)
            {
                total += Convert.ToDouble(line[5]);
            }
            textBoxtot.Text = total.ToString("0.00");
        }

        private void selectionDataGrid(int colonne, string textbox)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[colonne].Value.ToString().Equals(textbox))
                {
                    rowIndex = row.Index;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    break;
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //if (withcode.Checked)
            //{
            //    int code;
            //    if (!int.TryParse(btnRecherch.Text, out code))
            //    {
            //        MessageBox.Show("Code incorrect ou nul");
            //        btnRecherch.Focus();
            //        return;
            //    }

            //    cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, PrixU, QteStock, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau WHERE NumPrd = @code", cx);
            //    cmd.Parameters.AddWithValue("@code", code);
            //}
            //else if (withdesgn.Checked)
            //{
            //    string desig = btnRecherch.Text;
            //    if (string.IsNullOrEmpty(desig))
            //    {
            //        MessageBox.Show("Designation is empty");
            //        btnRecherch.Focus();
            //        return;
            //    }

            //    cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, PrixU, QteStock, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau WHERE Designation = @desig", cx);
            //    cmd.Parameters.AddWithValue("@desig", desig);
            //}
            //else
            //{
            //    MessageBox.Show("Please select either 'with code' or 'with designation'.");
            //    return;
            //}

            //adapter = new SqlDataAdapter(cmd);
            //cmd.Connection = cx;
            //cx.Open();
            //dt = new DataTable();
            //adapter.Fill(dt);
            //cx.Close();

            //if (dt.Rows.Count > 0)
            //{


            //    textboxPrix.Text = dt.Rows[0]["NumPrd"].ToString();
            //    textBoxDesig.Text = dt.Rows[1]["Designation"].ToString();
            //    textBoxunit.Text = dt.Rows[2]["uniteMesure"].ToString();
            //    textBoxprixuni.Text = dt.Rows[3]["PrixU"].ToString();
            //    textBoxqte.Text = dt.Rows[4]["QteStock"].ToString();
            //    textBoxprixtot.Text = dt.Rows[5]["PrixTot"].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Produit introuvable");
            //}
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsharpleft_Click(object sender, EventArgs e)
        {
            pos = 0;
            Affichage(pos);
            lblPosition.Text = pos.ToString() + "/" + (dt.Rows.Count).ToString();
        }

        private void buttonleft_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                Affichage(pos);
            }
            else
            {
                MessageBox.Show("Début" + " de la table");
                pos++;
            }


            //pos--;
            //if (pos >= 0)
            //{
            //    Affichage(pos);
            //}
            //else
            //{
            //    MessageBox.Show("Fin de la table");
            //    return;
            //}
            lblPosition.Text = pos.ToString() + "/" + (dt.Rows.Count).ToString();
        }

        private void buttonright_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < dt.Rows.Count)
            {
                Affichage(pos);
            }
            else
            {
                MessageBox.Show("Fin de la table");
                pos--;
            }
            lblPosition.Text = pos.ToString() + "/" + (dt.Rows.Count).ToString();
        }

        private void buttonsharpright_Click(object sender, EventArgs e)
        {
            pos = dt.Rows.Count - 1;
            Affichage(pos);
            lblPosition.Text = pos.ToString() + "/" + (dt.Rows.Count).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxPrix.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDesig.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxunit.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxqte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxprixuni.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxprixtot.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

            textboxPrix.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDesig.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxunit.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxqte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxprixuni.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxprixtot.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
            private void withcode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textboxPrix_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonclear_Click(object sender, EventArgs e)

        {

            textboxPrix.Text = string.Empty;
            textBoxDesig.Text = string.Empty;
            textBoxunit.Text = string.Empty;
            textBoxprixuni.Text = string.Empty;
            textBoxqte.Text = string.Empty;
            textBoxprixtot.Text = string.Empty;
            textboxPrix.Focus();

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void withcode_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRecherch_Click(object sender, EventArgs e)
        {
            
                try
                {
                    cx.Open();
                    SqlCommand cmd;
                    SqlDataAdapter adapter;
                    DataTable dt = new DataTable();

                    if (withcode.Checked)
                    {
                        int code;
                        if (!int.TryParse(texttosearch.Text, out code))
                        {
                            MessageBox.Show("Invalid or empty code.");
                            return;
                        }

                        cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, QteStock, PrixU, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau WHERE NumPrd = @code", cx);
                        cmd.Parameters.AddWithValue("@code", code);
                    }
                    else if (withdesgn.Checked)
                    {
                        string desig = texttosearch.Text;
                        if (string.IsNullOrWhiteSpace(desig))
                        {
                            MessageBox.Show("Designation is empty.");
                            return;
                        }

                        cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, QteStock, PrixU, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau WHERE Designation = @desig", cx);
                        cmd.Parameters.AddWithValue("@desig", desig);
                    }
                    else
                    {
                        MessageBox.Show("Please select either 'with code' or 'with designation'.");
                        return;
                    }

                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textboxPrix.Text = dt.Rows[0]["NumPrd"].ToString();
                        textBoxDesig.Text = dt.Rows[0]["Designation"].ToString();
                        textBoxunit.Text = dt.Rows[0]["uniteMesure"].ToString();
                        textBoxprixuni.Text = dt.Rows[0]["PrixU"].ToString();
                        textBoxqte.Text = dt.Rows[0]["QteStock"].ToString();
                        textBoxprixtot.Text = dt.Rows[0]["PrixTot"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cx.Close();
                }
            


        }

        private void buttonclear_Click_1(object sender, EventArgs e)
        {

        }

        private void withdesgn_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnActualiser_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT NumPrd, Designation, uniteMesure, PrixU, QteStock, CAST(PrixU * QteStock AS decimal(8,2)) AS PrixTot FROM stockBureau WHERE Designation = @desig", cx);
            dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                TotalMontant();
            }
        }

        private void buttonajouter_Click(object sender, EventArgs e)
        {
            // Create an instance of Form3
            Form3 form3 = new Form3();

            // Show Form3
            form3.Show();

            // Optionally, you can hide the current form if needed
            this.Hide();
        }



        private void buttonmodifier_Click(object sender, EventArgs e)
        {
            if (!existe(int.Parse(textboxPrix.Text)))
            {
                MessageBox.Show("ce code n'existe pas");
                textboxPrix.Focus();
                return;
            }
            else
            {
                cx.Open();
                cmd = new SqlCommand("insert into stock(NumPrd,Designation, uniteMesure,PrixU,QteStock) values(@code,@desig, @uni ,@qte,@pu)");
                cmd.Connection = cx;
                cmd.Parameters.AddWithValue("@code", int.Parse(textboxPrix.Text));
                cmd.Parameters.AddWithValue("@desig", textBoxDesig.Text);
                cmd.Parameters.AddWithValue("@uni", textBoxunit.Text);
                cmd.Parameters.AddWithValue("@qte", int.Parse(textBoxqte.Text));
                cmd.Parameters.AddWithValue("@pu", float.Parse(textBoxprixuni.Text));
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Modification réussie");
                }
                else
                {
                    MessageBox.Show("Modification echouée");
                }
            }
            cx.Close();
            btnActualiser_Click(this, null);
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cx.Open();
                cmd = new SqlCommand("delete from stock where NumPrd=@code");
                cmd.Connection = cx;
                cmd.Parameters.AddWithValue("@code", int.Parse( textboxPrix.Text));
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Suppression réussie");
                }
                else
                {
                    MessageBox.Show("Suppression echouée");
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
            finally
            {
                cx.Close();
            }
            btnActualiser_Click(this, null);



        }

        private void texttosearch_TextChanged(object sender, EventArgs e)
        {
    
            
        }

        private void textBoxqte_TextChanged(object sender, EventArgs e)
        {
            if (textBoxprixuni.Text != "" && textBoxqte.Text != "")
            {
                float pu = float.Parse(textBoxprixuni.Text);
                int qte = int.Parse(textBoxqte.Text);
                double mnt = pu * qte;
                textBoxprixtot.Text = mnt.ToString();
            }
        }

        private void textBoxprixuni_TextChanged(object sender, EventArgs e)
        {
            if (textBoxprixuni.Text != "" && textBoxqte.Text != "")
            {
                float pu = float.Parse(textBoxprixuni.Text);
                int qte = int.Parse(textBoxqte.Text);
                double mnt = pu * qte;
                textBoxprixtot.Text = mnt.ToString();
            }
        }

        private void addDB_Click(object sender, EventArgs e)
        {

            // Create an instance of Form0
            Form0 form0 = new Form0();

            // Show Form0
            form0.Show();

            // Optionally, you can hide the current form if needed
            this.Hide();

        }
    }



}


