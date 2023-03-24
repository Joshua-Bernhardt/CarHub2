using System.Security.AccessControl;
using System.Security.Claims;
using System.Net;
using CarHub.Service.Model.Login;
using CarHub.Service.Model.User.Get;
using CarHub.Service.Model.User.Post;
using CarHub.Service.Model.User.Put;
using CarHub.Service.Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarHub.Service.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserProvider _userProvider;
        private readonly ILoginProvider _loginProvider;

        public UserController(IUserProvider userProvider, ILogger<UserController> logger,
            ILoginProvider loginProvider)
        {
            _userProvider = userProvider ?? throw new ArgumentNullException(nameof(userProvider));
            _loginProvider = loginProvider ?? throw new ArgumentNullException(nameof(loginProvider));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost()]
        [AllowAnonymous]
        public UserPostResponse Create(UserPostRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return new UserPostResponse()
                {
                    StatusCode = HttpStatusCode.Forbidden,
                    Created = false,
                    Message = "User already logged in"
                };
            }

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

        [HttpPost("login")]
        [AllowAnonymous]
        public LoginPostResponse Login([FromBody] LoginPostRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize]
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