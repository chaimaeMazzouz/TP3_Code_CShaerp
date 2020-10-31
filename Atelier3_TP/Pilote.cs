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
    public partial class Pilote : Form
    {
        SqlConnection oConnection;
        SqlCommand cmd;
        public Pilote()
        {
            InitializeComponent();
            string strConnection = @"data source =DESKTOP-7TC9CTO\SQLEXPRESS;database=VolAvion;Integrated Security=True";
            oConnection = new SqlConnection(strConnection);
        }

        private void Pilote_Load(object sender, EventArgs e)
        {

        }

        private void btnInserer_Click(object sender, EventArgs e)
        {
            string pil = textPil.Text;
            string nom = textNom.Text;
            string codePostal = textCdPostal.Text;
            string ville = textVille.Text;
            string salaireBrut = textSalaireBrut.Text;
            string dateNaissance = dTP_DateNaissance.Value.ToShortDateString();
            string dateDebutActivite = dTP_DateDbActivite.Value.ToShortDateString();
            string dateFinActivite = dTP_DateFinActivite.Value.ToShortDateString();
            try
            {
                string strRequete = string.Format("insert into pilote values({0} ,'{1}', {2},'{3}',convert(datetime,'{4}',5),convert(datetime,'{5}',5),convert(datetime,'{6}',5),{7})", pil, nom, codePostal, ville, dateNaissance, dateDebutActivite, dateFinActivite,salaireBrut);
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
        }
    }
}
