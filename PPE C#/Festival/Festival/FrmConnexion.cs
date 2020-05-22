using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FestivalBLL; // Référence la couche BLL
using FestivalBO; // Référence la couche BO

namespace Festival
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            txtMdp.PasswordChar = '*';

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string pseudo = txtPseudo.Text;
            string mdp = txtMdp.Text;
            if (pseudo == "" || mdp =="")
            {
                MessageBox.Show("Veuillez remplir les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPseudo.Clear();
                txtMdp.Clear();
                txtPseudo.Focus();
                
            }
            else
            {

                // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
                GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

                // Création d'un objet List d'Utilisateur à afficher dans le datagridview
                List<Utilisateur> liste = new List<Utilisateur>();
                liste = GestionUtilisateurs.GetUtilisateurs();
                foreach (Utilisateur unUtilisateur in liste)
                {
                    if(pseudo == unUtilisateur.Pseudo && mdp == unUtilisateur.Mdp)
                    {
                        
                        // Création d'un nouvel objet formulaire
                        FrmMenu FrmMenu = new FrmMenu();

                        // Affichage de cet objet formulaire
                        this.Hide();
                        FrmMenu.ShowDialog();
                       


                    }
                    else
                    {
                        txtPseudo.Clear();
                        txtMdp.Clear();
                        txtPseudo.Focus();
                        MessageBox.Show("Identfiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            
        }

       
    }
}
