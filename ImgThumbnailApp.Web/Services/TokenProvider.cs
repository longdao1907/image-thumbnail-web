using ImgThumbnailApp.Web.Services.IServices;
using ImgThumbnailApp.Web.Utilities;

namespace ImgThumbnailApp.Web.Services
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }


        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Session.Remove(SD.TokenCookie);
        }

        public string? GetToken()
        {
            return _contextAccessor.HttpContext?.Session.GetString(SD.TokenCookie);
        }

                public void SetToken(string token)
                {
                    _contextAccessor.HttpContext?.Session.SetString(SD.TokenCookie, token);
                }    }
}
