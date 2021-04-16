using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;


namespace MTPP_PRVI_KOLOKVIJUM_Drugi_Deo
{
    class clsDataAccess
    {
        static string konekcija = ConfigurationManager.ConnectionStrings["Konekcija"].ConnectionString;

        SqlConnection Cn = new SqlConnection(konekcija);
     
        public DataTable Klijenti_SELECT()
        {

            int RetValue = -1;
            SqlCommand Cm = new SqlCommand();
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable tabela_klijenti = new DataTable();
            try
            {             
                Cm.Connection = Cn;
                Cm.CommandType = CommandType.StoredProcedure;
                Cm.CommandText = "dbo.Klijenti_SELECT";
                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
                
                Da.SelectCommand = Cm;
                Da.Fill(tabela_klijenti);

                RetValue = (int)Cm.Parameters["@RETURN_VALUE"].Value;
                
                if(RetValue != 0) throw new Exception("Greska prilikom izvrsavanja procedure!");
             
                return tabela_klijenti;

            }
            catch (Exception ex)
            {                              
                MessageBox.Show(ex.Message + " Broj greske: " + RetValue , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabela_klijenti;
            }
        }

        public int Klijenti_INSERT(string naziv, string kontakt, string grad, string zemlja)
        {
            int RetValue = -1;
            if (Cn.State != ConnectionState.Open) Cn.Open();

            try
            {
                SqlCommand Cm = new SqlCommand();
                Cm.Connection = Cn;
                Cm.CommandType = CommandType.StoredProcedure;
                Cm.CommandText = "dbo.Klijenti_INSERT";
                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
                Cm.Parameters.AddWithValue("@naziv", naziv);
                Cm.Parameters.AddWithValue("@kontakt", kontakt);
                Cm.Parameters.AddWithValue("@grad", grad);
                Cm.Parameters.AddWithValue("@zemlja", zemlja);

                Cm.ExecuteNonQuery();

                RetValue = (int)Cm.Parameters["@RETURN_VALUE"].Value;

                if (RetValue != 0) throw new Exception("Greska prilikom izvrsavanja procedure!");

                Cn.Close();

                return RetValue;
            }
            catch (Exception ex)
            {
                Cn.Close();
                MessageBox.Show(ex.Message + " Broj greske: " + RetValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return RetValue;
            }
        }

        public int Klijenti_UPDATE(int id ,string naziv, string kontakt, string grad, string zemlja)
        {
            int RetValue = -1;
            if (Cn.State != ConnectionState.Open) Cn.Open();

            try
            {
                SqlCommand Cm = new SqlCommand();
                Cm.Connection = Cn;
                Cm.CommandType = CommandType.StoredProcedure;
                Cm.CommandText = "dbo.Klijenti_UPDATE";
                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
                Cm.Parameters.AddWithValue("@id", id);
                Cm.Parameters.AddWithValue("@naziv", naziv);
                Cm.Parameters.AddWithValue("@kontakt", kontakt);
                Cm.Parameters.AddWithValue("@grad", grad);
                Cm.Parameters.AddWithValue("@zemlja", zemlja);

                Cm.ExecuteNonQuery();

                RetValue = (int)Cm.Parameters["@RETURN_VALUE"].Value;

                if (RetValue != 0) throw new Exception("Greska prilikom izvrsavanja procedure!");

                Cn.Close();

                return RetValue;
            }
            catch (Exception ex)
            {
                Cn.Close();
                MessageBox.Show(ex.Message + " Broj greske: " + RetValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return RetValue;
            }
        }

        public int Klijenti_DELETE(int id)
        {
            int RetValue = -1;
            if (Cn.State != ConnectionState.Open) Cn.Open();

            try
            {
                SqlCommand Cm = new SqlCommand();
                Cm.Connection = Cn;
                Cm.CommandType = CommandType.StoredProcedure;
                Cm.CommandText = "dbo.Klijenti_DELETE";
                Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));
                Cm.Parameters.AddWithValue("@id", id);
                                
                Cm.ExecuteNonQuery();

                RetValue = (int)Cm.Parameters["@RETURN_VALUE"].Value;

                if (RetValue != 0) throw new Exception("Greska prilikom izvrsavanja procedure!");

                Cn.Close();
                return RetValue;

            }
            catch (Exception ex)
            {
                Cn.Close();
                MessageBox.Show(ex.Message + " Broj greske: " + RetValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return RetValue;

            }
        }
    }
}
