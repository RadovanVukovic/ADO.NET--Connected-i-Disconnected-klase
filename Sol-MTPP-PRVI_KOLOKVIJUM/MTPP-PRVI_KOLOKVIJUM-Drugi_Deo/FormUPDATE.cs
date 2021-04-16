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
    public partial class FormUPDATE : Form
    {


        public FormUPDATE()
        {
            InitializeComponent();

            txtNaziv.Text = clsCustomerData.naziv;
            txtGrad.Text = clsCustomerData.grad;
            txtKontakt.Text = clsCustomerData.kontakt;
            txtZemlja.Text = clsCustomerData.zemlja;
        }


        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            //potrebne validacije ovde

            try
            {
                int id = clsCustomerData.id;
                string naziv = txtNaziv.Text;
                string zemlja = txtZemlja.Text;
                string grad = txtGrad.Text;
                string kontakt = txtKontakt.Text;

                if (naziv.Trim().Length > 40 || naziv.Trim().Length == 0) throw new Exception("Naziv klijenta nije unesen u odgovarajucem obliku");
                if (zemlja.Trim().Length > 30 || zemlja.Trim().Length == 0) throw new Exception("Naziv zemlje nije unesen u odgovarajucem obliku");
                if (grad.Trim().Length > 15 || grad.Trim().Length == 0) throw new Exception("Naziv grada nije unesen u odgovarajucem obliku");
                if (kontakt.Trim().Length > 15 || kontakt.Trim().Length == 0) throw new Exception("Kontakt nije unesen u odgovarajucem obliku");

                clsDataAccess data = new clsDataAccess();

                int return_value = data.Klijenti_UPDATE(id, naziv, kontakt, grad, zemlja);

                if (return_value == 0)
                {
                    MessageBox.Show("Podaci klijenta su uspesno promenjeni!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Greska prilikom izmene podataka klijenta klijenta, broj greske :" + return_value);

                }

                this.Close();

                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNaziv.Text = clsCustomerData.naziv;
                txtGrad.Text = clsCustomerData.grad;
                txtKontakt.Text = clsCustomerData.kontakt;
                txtZemlja.Text = clsCustomerData.zemlja;
                
                return;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
