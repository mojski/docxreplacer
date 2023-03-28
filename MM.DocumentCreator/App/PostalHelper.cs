namespace MM.DocumentCreator.App
{
    public class PostalHelper
    {
        private readonly HttpClient _client;
        private const string _apiAddress = "https://kodpocztowy.intami.pl/api";
        public PostalHelper()
        {
            _client = new HttpClient();
        }

        public string GetDistrictByCode(string code)
        {
            return "";
        }
    }
}
