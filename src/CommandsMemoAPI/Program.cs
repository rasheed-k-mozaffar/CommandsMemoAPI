using CommandsMemoAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Registering services in the IoC Container.
builder.Services.AddControllers();
builder.Services.ConfigureCommandsRepo();

var app = builder.Build();

//Configuring the request pipeline (Middleware chain)

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.MapControllers();


app.Run();
