namespace ApiDemo.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.WithOrigins("http://localhost:5174") // Ursprunget för Vue-applikationen
                           .AllowAnyHeader() // Tillåter alla headers
                           .AllowAnyMethod()); // Tillåter alla HTTP-metoder (GET, POST, PUT, DELETE, etc.)
            });
        }
    }
}
