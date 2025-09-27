using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        private string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$";
        private string MESSAGE_PASSWORD_ERROR = "Password doesnt comply with the listed requirements!";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txt_password.Text, pattern)) 
            {
                MessageBox.Show(MESSAGE_PASSWORD_ERROR,"Password Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!txt_password.Text.Equals(txt_repeatPassword.Text))
            {
                MessageBox.Show("Enter passwords doesnt match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Password Accepted", "Password Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
