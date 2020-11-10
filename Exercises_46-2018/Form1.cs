using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_70_2018
{
    public partial class GlavnaForma : Form
    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public GlavnaForma()
        {
            InitializeComponent();
        }
        private void listBoxExerciseResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
            try
            {

                List<ExerciseResult> exerciseResults = new List<ExerciseResult>();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM ExerciseResults";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    exerciseResults.Add(new ExerciseResult(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetInt32(3)));

                }
                sqlConnection.Close();
                foreach (ExerciseResult p in exerciseResults)
                {
                    listBoxExerciseResults.Items.Add(p);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Postoji neka greska, ponovo pokrentite, ili pronadjite gresku");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
