// ToDo Later
// Needed for making

using static BarberConnect.Utility.SD;

namespace BarberConnect
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }

        public ContentType ContentType { get; set; } = ContentType.Json;  //for the token jwt adding process
    }
}