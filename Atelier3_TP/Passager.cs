using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Atelier3_TP
{
    public partial class Passager : Form
    {
        SqlConnection oConnection;
        SqlCommand cmd;
        public Passager()
        {
            InitializeComponent();
            string strConnection = @"data source =DESKTOP-7TC9CTO\SQLEXPRESS;database=VolAvion;Integrated Security=True";
            oConnection = new SqlConnection(strConnection);
        }
        void Reset()
        {
            textPas.Text = textNom.Text = textPrenom.Text = textVille.Text  = "";
            textPas.Focus();
        }
        private void Passager_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string pas = textPas.Text;
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string ville = textVille.Text;
            try
            {
                string strRequete = string.Format("insert into Passager values({0} ,'{1}','{2}','{3}')", pas, nom, prenom, ville);
                cmd = new SqlCommand(strRequete, oConnection);
                oConnection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion effectuée...");
                oConnection.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("l'erreur suivante a été rencontrée : " + exp.Message);
            }
            Reset();

        }
    }
}
