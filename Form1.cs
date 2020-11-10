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
using System.Drawing.Text;

namespace Exercises_46-2018
{
    public partial class GlavnaForma : Form
{
    private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    public GlavnaForma()
    {
            InitializeComponent();
        }
    private void Form1_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = new SqlConnection();
        sqlConnection.ConnectionString = connectionString;

        List<ExerciseResult> exerciseResults = new List<ExerciseResult>();
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = sqlConnection;

        sqlConnection.Close();

    }

    private void Prikaz_rezultata_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

}
}