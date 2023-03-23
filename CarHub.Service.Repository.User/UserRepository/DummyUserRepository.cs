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
                    VehicleRegistration = "GL17OOD"
                }
            };
        }

        public bool CreateUser(Model.User.User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(user.VehicleRegistration)) throw new InvalidOperationException();

            user.Id = Guid.NewGuid();
            _users.Add(user);

            return true;
        }

        public bool EditUser(Model.User.User user)
        {
            return true;
        }

        public Model.User.User GetUser(Guid userId)
        {
            if (userId == null || userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));

            return _users.FirstOrDefault(x => x.Id == userId);
        }
    }
}