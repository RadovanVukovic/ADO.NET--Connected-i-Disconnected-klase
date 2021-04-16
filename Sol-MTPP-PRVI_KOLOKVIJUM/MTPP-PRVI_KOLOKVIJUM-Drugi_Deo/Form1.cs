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

namespace MTPP_PRVI_KOLOKVIJUM_Drugi_Deo
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormINSERT form = new FormINSERT();
            form.Show();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgKlijenti.SelectedRows.Count == 0) return;

            clsCustomerData.id = (int)dgKlijenti.SelectedCells[0].Value;
            clsCustomerData.naziv = (string)dgKlijenti.SelectedCells[1].Value;
            clsCustomerData.kontakt = (string)dgKlijenti.SelectedCells[2].Value;
            clsCustomerData.grad = (string)dgKlijenti.SelectedCells[3].Value;
            clsCustomerData.zemlja = (string)dgKlijenti.SelectedCells[4].Value;

            FormUPDATE form = new FormUPDATE();
                      
            form.Show();

        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            clsDataAccess data = new clsDataAccess();
            dgKlijenti.DataSource = data.Klijenti_SELECT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult odgovor =  MessageBox.Show
            (
                "Da li ste sigurni da zelite da obrisete izabranog klijenta?",
                "Brisanje klijenta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if(odgovor == DialogResult.No)
            {
                return;
            }
            else if(odgovor == DialogResult.Yes)
            {
                clsDataAccess data = new clsDataAccess();
            
                if(dgKlijenti.SelectedRows.Count == 0)
                {
                    return;
                }

                int id = (int)dgKlijenti.SelectedCells[0].Value;
               

                int return_value = data.Klijenti_DELETE(id);

                if(return_value == 0)
                {
                    MessageBox.Show("Klijent je uspesno obrisan!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Greska prilikom brisanja, broj greske: " + return_value, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRefreshGrid.PerformClick();
        }
    }
}
