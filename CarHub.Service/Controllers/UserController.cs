using System.Net;
using CarHub.Service.Model.User.Get;
using CarHub.Service.Model.User.Post;
using CarHub.Service.Model.User.Put;
using CarHub.Service.Provider;
using Microsoft.AspNetCore.Mvc;

namespace CarHub.Service.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserProvider _userProvider;

        public UserController(IUserProvider userProvider, ILogger<UserController> logger)
        {
            _userProvider = userProvider ?? throw new ArgumentNullException(nameof(userProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost()]
        public UserPostResponse Create(UserPostRequest request)
        {
            if (request == null)
            {
                _logger.LogInformation("Request given was null");
                return new UserPostResponse()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Created = false,
                    Message = "Request was null"
                };
            }

            return _userProvider.CreateUser(request);
        }

        [HttpGet]
        [Route("{id}")]
        public UserGetResponse Get([FromRoute]UserGetRequest request)
        {
            if (request == null)
            {
                return new UserGetResponse()
                {
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            return _userProvider.GetUser(request);
        }

        [HttpPut]
        public UserPutResponse Edit(UserPutRequest request)
        {
            if (request == null)
            {
                return new UserPutResponse()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Created = false,
                    Message = "Request was null"
                };
            }

            return _userProvider.EditUser(request);
        }
    }
}