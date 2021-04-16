using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPP_PRVI_KOLOKVIJUM_Prvi_Deo
{
    public partial class Form1 : Form
    {
        DataTable kupci = new DataTable("Kupci");
        DataTable fakture = new DataTable("Fakture");
        DataTable faktureStavke = new DataTable("FaktureStavke");

        DataSet Fakturisanje;


        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNazivKupca.Text == "" || txtAdresa.Text == "")
                {
                    MessageBox.Show("Morate da popunite polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow kupac = kupci.NewRow();
                kupac["NazivKupca"] = txtNazivKupca.Text;
                kupac["Adresa"] = txtAdresa.Text;
                kupci.Rows.Add(kupac);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajFakturu_Click(object sender, EventArgs e)
        {

            try
            {

                DataRow faktura = fakture.NewRow();
                faktura["KupacID"] = txtKupacID.Text;
                faktura["Datum"] = txtDatum.Text;
                fakture.Rows.Add(faktura);

            }
            catch (Exception ex)
            { 
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtNazivStavke.Text == "")
                {
                    MessageBox.Show("Morate da popunite polje za naziv stavke!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow stavka = faktureStavke.NewRow();
                stavka["FakturaID"] = txtFakturaID.Text;
                stavka["NazivStavke"] = txtNazivStavke.Text;
                stavka["CenaStavke"] = txtCenaStavke.Text;
                faktureStavke.Rows.Add(stavka);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // tabela Kupci

                //dodavanje kolone KupacID
                DataColumn KupacID = new DataColumn("KupacID");
                KupacID.DataType = typeof(int);
                KupacID.AutoIncrement = true;
                KupacID.AutoIncrementSeed = 1;
                KupacID.AutoIncrementStep = 1;
                KupacID.AllowDBNull = false;
                
                //PK
                kupci.PrimaryKey = new DataColumn[] { kupci.Columns["KupacID"] };
                kupci.Columns.Add(KupacID);

                //dodavanje kolone NazivKupca
                DataColumn NazivKupca = new DataColumn("NazivKupca");
                NazivKupca.DataType = typeof(string);
                NazivKupca.MaxLength = 50;
                NazivKupca.AllowDBNull = false;
                

                kupci.Columns.Add(NazivKupca);

                //dodavanje kolone Adresa
                DataColumn Adresa = new DataColumn("Adresa");
                Adresa.DataType = typeof(string);
                Adresa.MaxLength = 200;
                Adresa.AllowDBNull = true;

                kupci.Columns.Add(Adresa);


                // tabela Fakture
                

                //dodavanje kolone FakturaID
                DataColumn FakturaID = new DataColumn("FakturaID");
                FakturaID.DataType = typeof(int);
                FakturaID.AutoIncrement = true;
                FakturaID.AutoIncrementSeed = 1;
                FakturaID.AutoIncrementStep = 1;
                FakturaID.AllowDBNull = false;
                //PK
                fakture.PrimaryKey = new DataColumn[] { fakture.Columns["FakturaID"] };
                fakture.Columns.Add(FakturaID);


                //dodavanje kolone KupacID - spoljni kljuc
                DataColumn KupacID_FK = new DataColumn("KupacID");
                KupacID_FK.DataType = typeof(int);
                KupacID_FK.AllowDBNull = false;

                fakture.Columns.Add(KupacID_FK);

                //dodavanje kolone Datum
                DataColumn Datum = new DataColumn("Datum");
                Datum.DataType = typeof(DateTime);
                Datum.AllowDBNull = false;
                Datum.DefaultValue = DateTime.Now;

                fakture.Columns.Add(Datum);



                //tabela FaktureStavke


                //dodavanje kolone FakturaID - spoljni kljuc
                DataColumn FakturaID_FK = new DataColumn("FakturaID");
                FakturaID_FK.DataType = typeof(int);
                FakturaID_FK.AllowDBNull = false;

                faktureStavke.Columns.Add(FakturaID_FK);

                //dodavanje kolone NazivStavke
                DataColumn NazivStavke = new DataColumn("NazivStavke");
                NazivStavke.DataType = typeof(string);
                NazivStavke.MaxLength = 40;
                NazivStavke.AllowDBNull = false;

                faktureStavke.Columns.Add(NazivStavke);

                //dodavanje kolone CenaStavke
                DataColumn CenaStavke = new DataColumn("CenaStavke");
                CenaStavke.DataType = typeof(decimal);
                CenaStavke.AllowDBNull = false;

                faktureStavke.Columns.Add(CenaStavke);
                //PK
                faktureStavke.PrimaryKey = new DataColumn[] { faktureStavke.Columns["FakturaID"], faktureStavke.Columns["NazivStavke"] };

                // stavljanje tabela u DataSet
                Fakturisanje = new DataSet("Fakturisanje");
                Fakturisanje.Tables.Add(kupci);
                Fakturisanje.Tables.Add(fakture);
                Fakturisanje.Tables.Add(faktureStavke);

                //pravljenje relacije kupciFakture
                DataRelation kupciFakture = new DataRelation("RelacijaKupciFakture", kupci.Columns["KupacID"], fakture.Columns["KupacID"], true);


                //pravljenje relacije FaktureStavke
                DataRelation FaktureStavke = new DataRelation("RelacijaFaktureStavke", fakture.Columns["FakturaID"], faktureStavke.Columns["FakturaID"], true);

                //dodavanje relacija
                Fakturisanje.Relations.Add(kupciFakture);
                Fakturisanje.Relations.Add(FaktureStavke);

                ForeignKeyConstraint fk = (ForeignKeyConstraint)fakture.Constraints["RelacijaKupciFakture"];
                fk.DeleteRule = Rule.None;
                fk.UpdateRule = Rule.None;

                ForeignKeyConstraint fk2 = (ForeignKeyConstraint)faktureStavke.Constraints["RelacijaFaktureStavke"];
                fk2.DeleteRule = Rule.None;
                fk2.UpdateRule = Rule.None;

                ////dodavanje redova u tabele    
                DataRow kupac1 = kupci.NewRow();
                kupac1["NazivKupca"] = "Radovan Vukovic";
                kupac1["Adresa"] = "Makedonska 6";
                kupci.Rows.Add(kupac1);

                DataRow kupac2 = kupci.NewRow();
                kupac2["NazivKupca"] = "Mihajlo Pantic";
                kupac2["Adresa"] = "Bele bartoka 13";
                kupci.Rows.Add(kupac2);

                DataRow kupac3 = kupci.NewRow();
                kupac3["NazivKupca"] = "Ivan Milutinovic";
                kupac3["Adresa"] = "Francuska 23";
                kupci.Rows.Add(kupac3);



                DataRow faktura1 = fakture.NewRow();
                faktura1["KupacID"] = 1;
                faktura1["Datum"] = "09/10/2020";
                fakture.Rows.Add(faktura1);

                DataRow faktura2 = fakture.NewRow();
                faktura2["KupacID"] = 2;
                faktura2["Datum"] = "23/12/2020";
                fakture.Rows.Add(faktura2);

                DataRow faktura3 = fakture.NewRow();
                faktura3["KupacID"] = 3;
                faktura3["Datum"] = "15/7/2020";
                fakture.Rows.Add(faktura3);



                DataRow stavka1 = faktureStavke.NewRow();
                stavka1["FakturaID"] = 1;
                stavka1["NazivStavke"] = "Laptop";
                stavka1["CenaStavke"] = 60000;
                faktureStavke.Rows.Add(stavka1);

                DataRow stavka2 = faktureStavke.NewRow();
                stavka2["FakturaID"] = 1;
                stavka2["NazivStavke"] = "Tastatura";
                stavka2["CenaStavke"] = 4000;
                faktureStavke.Rows.Add(stavka2);

                DataRow stavka3 = faktureStavke.NewRow();
                stavka3["FakturaID"] = 2;
                stavka3["NazivStavke"] = "Mis";
                stavka3["CenaStavke"] = 3000;
                faktureStavke.Rows.Add(stavka3);

                DataRow stavka4 = faktureStavke.NewRow();
                stavka4["FakturaID"] = 2;
                stavka4["NazivStavke"] = "Monitor";
                stavka4["CenaStavke"] = 20000;
                faktureStavke.Rows.Add(stavka4);

                DataRow stavka5 = faktureStavke.NewRow();
                stavka5["FakturaID"] = 3;
                stavka5["NazivStavke"] = "Telefon";
                stavka5["CenaStavke"] = 35000;
                faktureStavke.Rows.Add(stavka5);

                DataRow stavka6 = faktureStavke.NewRow();
                stavka6["FakturaID"] = 3;
                stavka6["NazivStavke"] = "Slusalice";
                stavka6["CenaStavke"] = 8000;
                faktureStavke.Rows.Add(stavka6);

                dgKupci.DataSource = kupci;
                dgFakture.DataSource = fakture;
                dgFaktureStavke.DataSource = faktureStavke;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            Fakturisanje.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MTPP vezbe" + "\\Fakture.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Podaci su uspesno snimljeni!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
