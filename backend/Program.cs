var builder = WebApplication.CreateBuilder(args);

// Activar controllers
builder.Services.AddControllers();

// 🔥 PERMITIR CONEXIÓN DESDE VUE
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// 🔥 USAR CORS
app.UseCors("AllowVueApp");

app.MapControllers();

app.Run();