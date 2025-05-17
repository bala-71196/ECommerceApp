var builder = WebApplication.CreateBuilder(args);

//Add services to the container

var app = builder.Build();

//Modify Http Pipeline Request

app.Run();
