using MySql.Data.MySqlClient;
namespace TolentinoTiquioFlamiano_Courses
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@" datasource = localhost; port = 3306; username = root; password = ''; database = schooldb03;");
        MySqlCommand cmd;
        MySqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadCourses()
        {
            data_courses.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("Select courseTitle,courseDescription,units,collegeOffered FROM courses;", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                data_courses.Rows.Add(rdr.GetString(0),rdr.GetString(1),rdr.GetString(2),rdr.GetString(3));
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
    }
}