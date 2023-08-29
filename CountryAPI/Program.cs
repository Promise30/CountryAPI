var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient(
    "CountryDetails", client =>
    {
        client.BaseAddress = new Uri("https://restcountries.com/v3.1/");
    });
builder.Services.AddHttpClient(
    "CountryStates", clientFactory =>
    {
        clientFactory.BaseAddress = new Uri("https://countriesnow.space/api/v0.1/");
    });
builder.Services.AddHttpClient(
    "CountryCities", clientTrial =>
    {
        clientTrial.BaseAddress = new Uri("https://countriesnow.space/api/v0.1/");
    });
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
