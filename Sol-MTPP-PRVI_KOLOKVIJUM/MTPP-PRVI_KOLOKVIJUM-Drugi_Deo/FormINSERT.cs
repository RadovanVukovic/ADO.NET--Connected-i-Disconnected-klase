using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPP_PRVI_KOLOKVIJUM_Drugi_Deo
{
    public partial class FormINSERT : Form
    {
        public FormINSERT()
        {
            InitializeComponent();
        }


        private void btnINSERT_Click(object sender, EventArgs e)
        {
            //potrebne validacije ovde

            try
            {
                string naziv = txtNaziv.Text;
                string zemlja = txtZemlja.Text;
                string grad = txtGrad.Text;
                string kontakt = txtKontakt.Text;

                if (naziv.Trim().Length > 40 || naziv.Trim().Length == 0) throw new Exception("Naziv klijenta nije unesen u odgovarajucem obliku");
                if (zemlja.Trim().Length > 30 || zemlja.Trim().Length == 0) throw new Exception("Naziv zemlje nije unesen u odgovarajucem obliku");
                if (grad.Trim().Length > 15 || grad.Trim().Length == 0) throw new Exception("Naziv grada nije unesen u odgovarajucem obliku");
                if (kontakt.Trim().Length > 15 || kontakt.Trim().Length == 0) throw new Exception("Kontakt nije unesen u odgovarajucem obliku");

                clsDataAccess data = new clsDataAccess();

                int return_value = data.Klijenti_INSERT(naziv, kontakt, grad, zemlja);

                if (return_value == 0)
                {
                    MessageBox.Show("Klijent je uspesno dodat u tabelu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Greska prilikom dodavanja klijenta, broj greske :" + return_value);

                }

                this.Close();
                
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNaziv.Clear();
                txtGrad.Clear();
                txtKontakt.Clear();
                txtZemlja.Clear();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
