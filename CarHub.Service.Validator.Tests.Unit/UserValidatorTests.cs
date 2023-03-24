namespace CarHub.Service.Validator.Tests.Unit;

public class UserValidatorTests
{
    [Fact]
    public void IsValidEmail_EmptyEmailGiven_ArgumentNullExceptionThrown()
    {
        var validator = new UserValidator();

        Assert.Throws<ArgumentNullException>(() => validator.IsValidEmail(string.Empty));
    }

    [Fact]
    public void IsValidEmail_InvalidEmailGiven_ReturnsFalse()
    {
        var validator = new UserValidator();
        const string invalidEmail = "invalid";

        var result = validator.IsValidEmail(invalidEmail);

        Assert.False(result);
    }

    [Fact]
    public void IsValidEmail_ValidEmailGiven_ReturnsFalse()
    {
        var validator = new UserValidator();
        const string validEmail = "valid@email.com";

        var result = validator.IsValidEmail(validEmail);

        Assert.True(result);
    }

    [Fact]
    public void IsValidVehicleRegistration_EmptyRegistrationGiven_ArgumentNullExceptionThrown()
    {
        var validator = new UserValidator();

        Assert.Throws<ArgumentNullException>(() => validator.IsValidVehicleRegistration(string.Empty));
    }

    [Fact]
    public void IsValidVehicleRegistration_InvalidRegistrationGiven_ReturnsFalse()
    {
        var validator = new UserValidator();
        const string invalidRegistration = "invalid";

        var result = validator.IsValidVehicleRegistration(invalidRegistration);

        Assert.False(result);
    }

    [Fact]
    public void IsValidVehicleRegistration_ValidRegistrationGiven_ReturnsFalse()
    {
        var validator = new UserValidator();
        const string validRegistration = "GL17OOD";

        var result = validator.IsValidVehicleRegistration(validRegistration);

        Assert.True(result);
    }
}