using ISS_RestService.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();
List<Game> popisIgri = new List<Game>
{
    new Game
    {
       ID = "1",
       Publisher="Blizzard",
       title="Overwatch 1.5",
       price="Free",
       ganre="F2P,shooter",
       desription="overwatch 1 +"
    },

};
builder.Services.AddSingleton(popisIgri);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
