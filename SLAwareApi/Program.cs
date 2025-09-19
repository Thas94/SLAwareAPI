using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Interfaces.SLAware.TicketCategory;
using SLAwareApi.Interfaces.SLAware.TicketStatus;
using SLAwareApi.Interfaces.SLAware.TicketSubCategory;
using SLAwareApi.Middleware;
using SLAwareApi.Services.SLAware;
using SLAwareApi.Services.SLAware;
using SLAwareApi.Services.SLAware;
using SLAwareApi.Services.SLAware.TicketSubCategory;
using TFTShuttiAPI.TFTEntities.Helpers;




var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));


var connectionString = builder.Configuration.GetConnectionString("SLAware");
builder.Services.AddDbContext<slaware_dataContext>(options =>
{
    options.UseSqlServer(config["ConnectionStrings:SLAware"], sqlServerOptionsAction: sqloptions =>
    {
        sqloptions.EnableRetryOnFailure(maxRetryCount: 60, maxRetryDelay: TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
        sqloptions.MaxBatchSize(20);
    });
});


builder.Services.AddEntityFrameworkSqlServer().AddDbContext<TftAppContext>(options =>
{
    options.UseSqlServer(config["ConnectionStrings:TFTAPPDatabase"], sqlServerOptionsAction: sqloptions =>
    {
        sqloptions.EnableRetryOnFailure(maxRetryCount: 120, maxRetryDelay: TimeSpan.FromSeconds(15), errorNumbersToAdd: null);
        sqloptions.MaxBatchSize(20);
        sqloptions.CommandTimeout(300);
    });
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ISlaSeverityService, SlaSeverityService>();
builder.Services.AddScoped<IGlobalService, GlobalService>();
builder.Services.AddScoped<ITicketStatusService, TicketStatusService>();

builder.Services.AddScoped<ITicketSubCategoryService, TicketSubCategoryService>();
builder.Services.AddScoped<ITicketCategoryService, TicketCategoryService>();


builder.Services.AddScoped<slaware_dataContext>();

builder.Services.AddSingleton<ClinicalEntityHelper>();
builder.Services.AddSingleton<EntityHelper>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("TFTCors",
            builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();

            });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("TFTCors");


app.UseHttpsRedirection();
app.UseResponseCapture(); //Traffic Capture Middleware


app.UseAuthorization();

app.MapControllers();

app.Run();
