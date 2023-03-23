using CarHub.Service.Model.User.Get;
using CarHub.Service.Model.User.Post;
using CarHub.Service.Model.User.Put;

namespace CarHub.Service.Provider
{
    public interface IUserProvider
    {
        UserPostResponse CreateUser(UserPostRequest request);

        UserGetResponse GetUser(UserGetRequest request);

        UserPutResponse EditUser(UserPutRequest request);
    }
}