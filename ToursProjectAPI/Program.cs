using BusinesLayer.Abstract;
using BusinesLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.EfDal;
using DTOLayer.DTO;
using EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<ICitiesDal,EfCitiesDal>();
builder.Services.AddScoped<ICitiesService, CitiesManager>();
builder.Services.AddScoped<ICommentsDal, EfCommentsDal>();
builder.Services.AddScoped<ICommentsService, CommentsManager>();
builder.Services.AddScoped<IContactsDal, EfContactsDal>();
builder.Services.AddScoped<IContactService, ContactManager>(); 
builder.Services.AddScoped<IServiceDal, EfServiceDal>();    
builder.Services.AddScoped<IServicesService, ServicesManager>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<IStationsDal, EfStationsDal>();
builder.Services.AddScoped<IStationsService, StationsManager>();
builder.Services.AddScoped<ITicketsSoldDal, EfTicketsSoldDal>();
builder.Services.AddScoped<ITicketSoldService, TicketSoldManager>();
builder.Services.AddScoped<IToursDal, EfToursDal>();
builder.Services.AddScoped<IToursService, ToursManager>();
builder.Services.AddScoped<ITourTimeDal, EfTourTimeDal>();
builder.Services.AddScoped<ITourTimeService, TourTimeManager>();



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
