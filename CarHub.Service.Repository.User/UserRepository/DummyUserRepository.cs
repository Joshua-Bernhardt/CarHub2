using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace CarHub.Service.Repository.UserRepository
{
    public class DummyUserRepository : IUserRepository
    {
        private IList<Model.User.User> _users;

        public DummyUserRepository()
        {
            _users = new List<Model.User.User>()
            {
                new Model.User.User()
                {
                    Id = Guid.NewGuid(),
                    Forename = "Forename",
                    Surname = "Surname",
                    MiddleName = "Middle",
                    VehicleRegistration = "GL17OOD",
                    Password = ""
                }
            };
        }

        public bool CreateUser(Model.User.User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(user.VehicleRegistration)) throw new InvalidOperationException();
            if (string.IsNullOrEmpty(user.Email)) throw new InvalidOperationException();
            if (string.IsNullOrEmpty(user.Password)) throw new InvalidOperationException();

            user.Id = Guid.NewGuid();
            _users.Add(user);

            return true;
        }

        public bool EditUser(Model.User.User user)
        {
            return true;
        }

        public Model.User.User GetUser(string email, string password)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException(nameof(password));

            return _users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}