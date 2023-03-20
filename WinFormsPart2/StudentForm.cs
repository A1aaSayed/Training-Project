namespace WinFormsPart2
{
    public partial class StudentForm : System.Windows.Forms.Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // add new student
            STUDENT student = new STUDENT();
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox3.Text;
            string address = textBox4.Text;
            string gender = "Male";

            if (checkBox1.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            // check the age of the student
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 18) || ((this_year - born_year) > 27))
            {
                MessageBox.Show("The student age must be between 18 and 27", "Invalide Bithe Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                if (student.insertStudent(fname, lname, bdate, phone, gender, address, pic))
                {
                    MessageBox.Show("New student added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // create a function to verify data
        bool verify()
        {
            if ((textBox1.Text.Trim() == "") ||
                (textBox2.Text.Trim() == "") ||
                (textBox3.Text.Trim() == "") ||
                (textBox4.Text.Trim() == "") ||
                (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // browse picture from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}