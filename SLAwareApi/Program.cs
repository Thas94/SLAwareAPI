using Microsoft.EntityFrameworkCore;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Services.SLAware;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SLAware");
builder.Services.AddDbContext<slaware_dataContext>(options =>
{
    options.UseSqlServer(connectionString, sqlServerOptionsAction: sqloptions =>
    {
        sqloptions.EnableRetryOnFailure(maxRetryCount: 60, maxRetryDelay: TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
        sqloptions.MaxBatchSize(20);
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<slaware_dataContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
