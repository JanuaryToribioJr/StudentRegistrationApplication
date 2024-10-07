using static StudentRegistrationApplication.Form1;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Student
        {
            private string lastName;
            private string firstName;
            private string middleName;
            private string gender;
            private string day;
            private string month;
            private string year;
            private string program;
            public Student(string lastName, string firstName, string middleName, string gender, string day, string month, string year, string program)
            {
                this.firstName = lastName;
                this.lastName = firstName;
                this.middleName = middleName;
                this.gender = gender;
                this.day = day;
                this.month = month;
                this.year = year;
                this.program = program;
            }
            public void DisplayStudentInformation(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string program)
            {
                MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}\nGender: {gender}\nDate of Birth: {day}/{month}/{year}\nProgram: {program}");
            }
            public void DisplayStudentInformation(string firstName, string middleName, string lastName, string program)
            {
                MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}\nProgram: {program}");
            }
            public void DisplayStudentInformation(string firstName, string lastName, string program)
            {
                MessageBox.Show($"Student Name: {firstName} {lastName}\nProgram: {program}");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            string firstName = this.FName.Text;
            string lastName = this.LName.Text;
            string middleName = this.MName.Text;
            string gender = this.Male.Checked ? "Male" : this.female.Checked ? "Female" : "";
            string day = Day.SelectedItem?.ToString();
            string month = this.month.SelectedItem?.ToString();
            string year = this.year.SelectedItem?.ToString();
            string program = this.program.SelectedItem?.ToString();

            Student studentInfo = new Student(firstName, middleName, lastName, gender, day, month, year, program);

            if (!string.IsNullOrEmpty(day) && !string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(year))
            {
                //1st prompt
                studentInfo.DisplayStudentInformation(firstName, middleName, lastName, gender, day, month, year, program);
            }
            else if (!string.IsNullOrEmpty(middleName))
            {
                //2nd prompt
                studentInfo.DisplayStudentInformation(firstName, middleName, lastName, program);
            }
            else
            {
                //3rd prompt
                studentInfo.DisplayStudentInformation(firstName, lastName, program);
            }


        }

        private void picButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg;"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                this.pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
