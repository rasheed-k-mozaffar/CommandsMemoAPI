using CommandsMemoAPI.Extensions;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var sqlConnection = new SqlConnectionStringBuilder();
sqlConnection.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
sqlConnection.UserID = builder.Configuration["UserId"];
sqlConnection.Password = builder.Configuration["Password"];


//Registering services in the IoC Container.
builder.Services.AddControllers().AddNewtonsoftJson(s =>
{
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});
builder.Services.ConfigureCommandsRepo();
builder.Services.ConfigureSqlConnection(sqlConnection.ConnectionString);
builder.Services.ConfigureAutoMapper();

var app = builder.Build();

//Configuring the request pipeline (Middleware chain)

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapControllers();


app.Run();
