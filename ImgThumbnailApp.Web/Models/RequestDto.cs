

namespace ImgThumbnailApp.Web.Models
{
    public class RequestDto
    {
        public Utilities.SD.ApiType ApiType { get; set; } = Utilities.SD.ApiType.GET;
        public string Url { get; set; } = string.Empty;
        public object Data { get; set; } = new();
        public string AccessToken { get; set; } = string.Empty;
        public Utilities.SD.ContentType ContentType { get; set; } = Utilities.SD.ContentType.Json;
    }
}
