namespace SubmissionAPI.Endpoints
{
    public static class EndpointRegistrations
    {
        public static IEndpointRouteBuilder MapAllEndpoints(this IEndpointRouteBuilder app)
        {
            CreateArticleEndpoint.Map(app);
            return app;
        }

    }
}
