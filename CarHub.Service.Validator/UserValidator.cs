using System.Text.RegularExpressions;

namespace CarHub.Service.Validator
{
    public class UserValidator : IUserValidator
    {
        private readonly string _emailRegex = "([aA0-zZ9])+[@]([aA0-zZ9])+[.]([aA-zZ.])+";
        private readonly string _registrationRegex = "([A-Z]{2})([0-9]{2})([A-Z]{3})";

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));

            var emailRegex = new Regex(_emailRegex);

            return emailRegex.IsMatch(email);
        }

        public bool IsValidVehicleRegistration(string registration)
        {
            if (string.IsNullOrEmpty(registration)) throw new ArgumentNullException(nameof(registration));

            var registrationRegex = new Regex(_registrationRegex);

            return registrationRegex.IsMatch(registration.ToUpper());
            //Only validates post 2001
        }
    }
}