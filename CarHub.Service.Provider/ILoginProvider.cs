using System.Collections.Immutable;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using CarHub.Service.Model.Token;

namespace CarHub.Service.Provider
{
    public interface ILoginProvider
    {
        JwtAuthResult GenerateTokens(Guid userId, Claim[] claims, DateTime currentTime);

        JwtAuthResult Refresh(string refreshToken, string accessToken, DateTime currentTime);

        void RemoveExpiredRefreshTokens(DateTime currentTime);

        void RemoveRefreshTokenByUserId(Guid userId);

        (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token);
    }
}