using ProModeConnecte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textboxPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void validadd_Click(object sender, EventArgs e)
        {
          
                // Check if all textboxes are filled
                if (string.IsNullOrWhiteSpace(textboxPrix.Text) || string.IsNullOrWhiteSpace(textBoxDesig.Text) ||
                    string.IsNullOrWhiteSpace(textBoxunit.Text) || string.IsNullOrWhiteSpace(textBoxqte.Text) ||
                    string.IsNullOrWhiteSpace(textBoxprixuni.Text))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

            int productNumber = int.Parse(textboxPrix.Text);
            if (existe(productNumber))
            {
                MessageBox.Show("Product with this number already exists.");
                return;
            }

            // Insert new product into the database
            try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbStock;Integrated Security=True"))
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO stockBureau (NumPrd, Designation, uniteMesure, QteStock, PrixU) VALUES (@code, @desig, @uni, @qte, @pu)", connection);
                        cmd.Parameters.AddWithValue("@code", int.Parse(textboxPrix.Text));
                        cmd.Parameters.AddWithValue("@desig", textBoxDesig.Text);
                        cmd.Parameters.AddWithValue("@uni", textBoxunit.Text);
                        cmd.Parameters.AddWithValue("@qte", int.Parse(textBoxqte.Text));
                        cmd.Parameters.AddWithValue("@pu", float.Parse(textBoxprixuni.Text));
                        

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully.");
                            // Optionally, clear input fields or perform any other necessary actions
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        private bool existe(int productNumber)
        {
            
            throw new NotImplementedException();
        }

        private void backtoForm1_Click(object sender, EventArgs e)
        {

            this.Close();

            // Show Form1
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
