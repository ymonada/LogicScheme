using LogicTranslator.Interfaces;
using LogicTranslator.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<ITService, TService>();
builder.Services.AddScoped<IJKService, JKService>();
builder.Services.AddScoped<IDService, DService>();
builder.Services.AddScoped<IRSService, RSService>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();
