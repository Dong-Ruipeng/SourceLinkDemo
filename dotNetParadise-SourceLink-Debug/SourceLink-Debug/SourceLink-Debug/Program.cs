using dotNetParadise_SourceLink.MinimalApis.Extensions;
using Newtonsoft.Json;
using SourceLink_Debug;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.RegisterEndPoints();
User user = new()
{
    Name = "user",
    Email = "user@163.com"
};
var json = JsonConvert.SerializeObject(user);

app.Run();

