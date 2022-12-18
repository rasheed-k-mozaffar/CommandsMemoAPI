using CommandsMemoAPI.Extensions;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
var sqlConnection = new SqlConnectionStringBuilder();
sqlConnection.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
sqlConnection.UserID = builder.Configuration["UserId"];
sqlConnection.Password = builder.Configuration["Password"];


//Registering services in the IoC Container.
builder.Services.AddControllers();
builder.Services.ConfigureCommandsRepo();
builder.Services.ConfigureSqlConnection(sqlConnection.ConnectionString);

var app = builder.Build();

//Configuring the request pipeline (Middleware chain)

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapControllers();


app.Run();
