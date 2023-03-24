namespace CarHub.Service.Validator
{
    public interface IUserValidator
    {
        bool IsValidEmail(string email);

        bool IsValidVehicleRegistration(string registration);
    }
}