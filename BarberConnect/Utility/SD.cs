namespace BarberConnect.Utility

{
    public class SD
    {
        public static string BarberCouponAPIBase { get; set; }
        public static string BarberAuthAPIBase { get; set; }

        public const string TokenCookie = "JWTToken";
        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}