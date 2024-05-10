namespace FusionProject
{
    public partial class Form1 : Form
    {
        private MyDbContext dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new MyDbContext();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public bool IsUsernameExists(string username)
        {
            // Check if a user with the given username exists
            return dbContext.Users.Any(u => u.Name == username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_box.Text;


            if (username != "" && password != "")
            {
                try
                {
                    if (IsUsernameExists(username))
                    {
                        MessageBox.Show(" Valid Username And Password");

                    }
                    else
                    {
                        MessageBox.Show(" In  Valid Username And Password");

                    }
                }
                catch (Exception ere)
                {
                    username_text.Text = ere.Message;
                }
               

                //  Form2 check = new Form2();
                //  check.Show();
                // Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username And Password");

            }
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}