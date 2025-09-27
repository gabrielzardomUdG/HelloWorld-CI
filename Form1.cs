using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {

        /*
         Some constants to avoid lengthy lines.
         */

        const string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$";
        const string MESSAGE_PASSWORD_ERROR = "Password doesnt comply with the listed requirements!";

        public Form1()
        {
            InitializeComponent();
        }

        /*
        When cliking on the button confirm, this function will run, first it will check if the RegExp pattern is matched,
        then it will check if both passwords are the same, if any of these checks fail, an error message will be shown,
        otherwise a success message will be shown.
        */
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
