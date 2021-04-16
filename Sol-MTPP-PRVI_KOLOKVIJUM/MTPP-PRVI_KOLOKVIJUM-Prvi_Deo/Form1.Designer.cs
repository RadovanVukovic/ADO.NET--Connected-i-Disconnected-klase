namespace MTPP_PRVI_KOLOKVIJUM_Prvi_Deo
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgKupci = new System.Windows.Forms.DataGridView();
            this.dgFakture = new System.Windows.Forms.DataGridView();
            this.dgFaktureStavke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNazivKupca = new System.Windows.Forms.TextBox();
            this.txtCenaStavke = new System.Windows.Forms.TextBox();
            this.txtFakturaID = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKupacID = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            this.btnDodajFakturu = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNazivStavke = new System.Windows.Forms.TextBox();
            this.btnSaveXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktureStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(45, 516);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(158, 76);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Kreiraj tabele";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgKupci
            // 
            this.dgKupci.AllowUserToAddRows = false;
            this.dgKupci.AllowUserToDeleteRows = false;
            this.dgKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKupci.Location = new System.Drawing.Point(12, 197);
            this.dgKupci.Name = "dgKupci";
            this.dgKupci.ReadOnly = true;
            this.dgKupci.RowHeadersWidth = 25;
            this.dgKupci.RowTemplate.Height = 24;
            this.dgKupci.Size = new System.Drawing.Size(435, 250);
            this.dgKupci.TabIndex = 1;
            // 
            // dgFakture
            // 
            this.dgFakture.AllowUserToAddRows = false;
            this.dgFakture.AllowUserToDeleteRows = false;
            this.dgFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFakture.Location = new System.Drawing.Point(489, 197);
            this.dgFakture.Name = "dgFakture";
            this.dgFakture.ReadOnly = true;
            this.dgFakture.RowHeadersWidth = 25;
            this.dgFakture.RowTemplate.Height = 24;
            this.dgFakture.Size = new System.Drawing.Size(428, 250);
            this.dgFakture.TabIndex = 2;
            // 
            // dgFaktureStavke
            // 
            this.dgFaktureStavke.AllowUserToAddRows = false;
            this.dgFaktureStavke.AllowUserToDeleteRows = false;
            this.dgFaktureStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFaktureStavke.Location = new System.Drawing.Point(951, 197);
            this.dgFaktureStavke.Name = "dgFaktureStavke";
            this.dgFaktureStavke.ReadOnly = true;
            this.dgFaktureStavke.RowHeadersWidth = 51;
            this.dgFaktureStavke.RowTemplate.Height = 24;
            this.dgFaktureStavke.Size = new System.Drawing.Size(466, 250);
            this.dgFaktureStavke.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv kupca: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresa : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(980, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Fakture :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Kupca : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(980, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cena stavke : ";
            // 
            // txtNazivKupca
            // 
            this.txtNazivKupca.Location = new System.Drawing.Point(108, 25);
            this.txtNazivKupca.Name = "txtNazivKupca";
            this.txtNazivKupca.Size = new System.Drawing.Size(186, 22);
            this.txtNazivKupca.TabIndex = 10;
            // 
            // txtCenaStavke
            // 
            this.txtCenaStavke.Location = new System.Drawing.Point(1102, 109);
            this.txtCenaStavke.Name = "txtCenaStavke";
            this.txtCenaStavke.Size = new System.Drawing.Size(120, 22);
            this.txtCenaStavke.TabIndex = 11;
            // 
            // txtFakturaID
            // 
            this.txtFakturaID.Location = new System.Drawing.Point(1102, 30);
            this.txtFakturaID.Name = "txtFakturaID";
            this.txtFakturaID.Size = new System.Drawing.Size(45, 22);
            this.txtFakturaID.TabIndex = 12;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(569, 65);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(131, 22);
            this.txtDatum.TabIndex = 13;
            // 
            // txtKupacID
            // 
            this.txtKupacID.Location = new System.Drawing.Point(569, 25);
            this.txtKupacID.Name = "txtKupacID";
            this.txtKupacID.Size = new System.Drawing.Size(45, 22);
            this.txtKupacID.TabIndex = 14;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(108, 65);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(186, 22);
            this.txtAdresa.TabIndex = 15;
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.Location = new System.Drawing.Point(108, 145);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(112, 46);
            this.btnDodajKupca.TabIndex = 16;
            this.btnDodajKupca.Text = "Dodaj kupca";
            this.btnDodajKupca.UseVisualStyleBackColor = true;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // btnDodajFakturu
            // 
            this.btnDodajFakturu.Location = new System.Drawing.Point(569, 145);
            this.btnDodajFakturu.Name = "btnDodajFakturu";
            this.btnDodajFakturu.Size = new System.Drawing.Size(112, 46);
            this.btnDodajFakturu.TabIndex = 17;
            this.btnDodajFakturu.Text = "Dodaj fakturu";
            this.btnDodajFakturu.UseVisualStyleBackColor = true;
            this.btnDodajFakturu.Click += new System.EventHandler(this.btnDodajFakturu_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(1102, 145);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(112, 46);
            this.btnDodajStavku.TabIndex = 18;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(978, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Naziv stavke : ";
            // 
            // txtNazivStavke
            // 
            this.txtNazivStavke.Location = new System.Drawing.Point(1102, 70);
            this.txtNazivStavke.Name = "txtNazivStavke";
            this.txtNazivStavke.Size = new System.Drawing.Size(120, 22);
            this.txtNazivStavke.TabIndex = 20;
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(1205, 516);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(158, 76);
            this.btnSaveXML.TabIndex = 21;
            this.btnSaveXML.Text = "Sacuvaj kao XML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 650);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.txtNazivStavke);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.btnDodajFakturu);
            this.Controls.Add(this.btnDodajKupca);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtKupacID);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtFakturaID);
            this.Controls.Add(this.txtCenaStavke);
            this.Controls.Add(this.txtNazivKupca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgFaktureStavke);
            this.Controls.Add(this.dgFakture);
            this.Controls.Add(this.dgKupci);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Radovan Vukovic s20/18";
            ((System.ComponentModel.ISupportInitialize)(this.dgKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFakture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFaktureStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgKupci;
        private System.Windows.Forms.DataGridView dgFakture;
        private System.Windows.Forms.DataGridView dgFaktureStavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNazivKupca;
        private System.Windows.Forms.TextBox txtCenaStavke;
        private System.Windows.Forms.TextBox txtFakturaID;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKupacID;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnDodajKupca;
        private System.Windows.Forms.Button btnDodajFakturu;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNazivStavke;
        private System.Windows.Forms.Button btnSaveXML;
    }
}

