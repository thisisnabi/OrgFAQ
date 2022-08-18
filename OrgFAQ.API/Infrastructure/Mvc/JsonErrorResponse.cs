namespace OrgFAQ.API.Infrastructure.Mvc
{
    public class JsonErrorResponse
    {
        public string[] Messages { get; set; }

        public object DeveloperMessage { get; set; }
    }
}
