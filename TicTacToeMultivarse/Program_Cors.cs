using System;

internal partial class Program
{
	private static void AddCors(WebApplicationBuilder builder, WebApplication app)
	{
        // Default Policy
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(
                builder =>
                {
                    builder.WithOrigins(
                        "http://localhost:4200",
                        "http://localhost:8080",
                        "https://localhost:4200",
                        "https://localhost:443",
                        "https://dhiman-angular-game.netlify.app")
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                });
        });

        app.UseCors();
    }
}