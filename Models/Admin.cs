namespace HMS_Dotnet.Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set
            {
                // Hash the password
                _password = Helpers.PasswordHelper.HashPassword(value);
            }
        }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}