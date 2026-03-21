using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Set the Swagger UI to be at the app's root URL (optional)
        // c.RoutePrefix = string.Empty; 
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });

    app.UseReDoc(options =>
    {
        options.DocumentTitle = "Documentação API";
        options.SpecUrl = "/swagger/v1/swagger.json"; // URL do JSON gerado
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
