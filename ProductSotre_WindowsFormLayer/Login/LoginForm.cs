using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductSotre_WindowsFormLayer.Factory;
using ProductSotre_WindowsFormLayer.Admin;
using ProductSotre_WindowsFormLayer.User;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_BussinessLayer.Users;

namespace ProductSotre_WindowsFormLayer.Login
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IFormFactory _formFactory;

        private UserDTO CurrentUser;

        public LoginForm(IUserService userService, IFormFactory formFactory)
        {
            _userService = userService;
            _formFactory = formFactory;

            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtUserName, errorProvider, "UserName cannot be empty.") ||
                !ValidateTextBox(txtPassword, errorProvider, "Password cannot be empty."))
            {
                return;
            }

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                CurrentUser = await _userService.isUserExist(userName, password);

                if (CurrentUser != null)
                {
                    CurrentUserInfo.CurrentUser = CurrentUser;

                    if (CurrentUser.Role == "Admin")
                    {
                        var AdminForm = _formFactory.CreateForm<AdminForm>();
                        AdminForm.onFormClosed = CloseForm;
                        AdminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        var userForm = _formFactory.CreateForm<UserForm>();
                        userForm.OnFormClosed = CloseForm;
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Email or Password is incorrect. Please try again!",
                                    "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void CloseForm()
        {
            this.Show();
        }

        private bool ValidateTextBox(TextBox textBox, ErrorProvider errorProvider, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, errorMessage);
                return false;
            }
            errorProvider.SetError(textBox, string.Empty);
            return true;
        }



    }
}
