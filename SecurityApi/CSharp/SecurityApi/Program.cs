using System.Text;
using Generator;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IRepository, Repository>();
builder.Services.AddSingleton<IModelGenerator, ModelGenerator>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {

      options.TokenValidationParameters = new TokenValidationParameters
      {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "admin",
        ValidAudience = "valid",
        IssuerSigningKey = new SymmetricSecurityKey(
          Encoding.UTF8.GetBytes(
            builder.Configuration["SecurityToken"]
          ))
      };
    });
builder.Services.AddAuthorization(options =>
{
  options.AddPolicy("TokenSecurityPolicy", policy =>
  {
    policy.RequireAuthenticatedUser();
    policy.RequireRole("User");
  });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();