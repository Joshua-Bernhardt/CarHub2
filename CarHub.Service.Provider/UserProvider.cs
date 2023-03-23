using CarHub.Service.Model.User;
using CarHub.Service.Model.User.Get;
using CarHub.Service.Model.User.Post;
using CarHub.Service.Model.User.Put;
using CarHub.Service.Repository.UserRepository;

namespace CarHub.Service.Provider
{
    public class UserProvider : IUserProvider
    {
        private readonly IUserRepository _repository;

        public UserProvider(IUserRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public UserPostResponse CreateUser(UserPostRequest request)
        {
            var user = new User()
            {
                Forename = request.Forename,
                MiddleName = request.MiddleName,
                Surname = request.Surname,
                Email = request.Email,
                VehicleRegistration = request.VehicleRegistration
            };

            if (_repository.CreateUser(user))
            {
                return new UserPostResponse()
                {
                    Created = true,
                    StatusCode = System.Net.HttpStatusCode.OK
                };
            }
            else
            {
                return new UserPostResponse()
                {
                    Created = false,
                    StatusCode = System.Net.HttpStatusCode.NotAcceptable
                };
            }
        }

        public UserPutResponse EditUser(UserPutRequest request)
        {
            throw new NotImplementedException();
        }

        public UserGetResponse GetUser(UserGetRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var user = _repository.GetUser(request.UserId);

            if (user == null)
            {
                return new UserGetResponse()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }

            return new UserGetResponse()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                User = user
            };
        }
    }
}