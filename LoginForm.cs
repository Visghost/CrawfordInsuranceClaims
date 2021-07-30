using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawfordInsuranceClaims
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginProcedure procedure = new LoginProcedure(UsernameField.Text, PasswordField.Text);
            if (procedure.Successful)
            {
                Hide();

                LossDataForm lossDataForm = new LossDataForm(procedure.DisplayName);
                lossDataForm.ShowDialog();

                Close();
            }
        }

        private void LoginButtonCheckEnable(object sender, EventArgs e)
        {
            LoginButton.Enabled = UsernameField.Text.Length > 0 && PasswordField.Text.Length > 0;
        }

    }
}
