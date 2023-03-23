namespace CarHub.Service.Repository.UserRepository
{
    public interface IUserRepository
    {
        bool CreateUser(Model.User.User user);

        bool EditUser(Model.User.User user);

        Model.User.User GetUser(string email, string password);
    }
}