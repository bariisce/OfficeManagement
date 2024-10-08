using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Infrastructure.Data.Postgres.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OfficeManagement.Middlewares;
using OfficeManagement.Utilities;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var cultureInfo = new CultureInfo("tr-Tr");

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", cBuilder =>
{
    cBuilder.AllowAnyHeader()
        .WithOrigins("http://localhost:4200") // Angular uygulamas�n�n adresi
        .AllowAnyMethod()
        .SetIsOriginAllowed(_ => true)
        .AllowCredentials();
}));

var postgresConnectionString = builder.Configuration.GetConnectionString("PsqlConnection");

builder.Services.AddDbContext<PostgresContext>(dbContextOptionsBuilder =>
    dbContextOptionsBuilder.UseNpgsql(postgresConnectionString, npgsqlDbContextOptionsBuilder =>
        npgsqlDbContextOptionsBuilder.MigrationsAssembly("Infrastructure")));

builder.Services.AddSignalR();

builder.Services.AddMySingleton();
builder.Services.AddMyScoped();
builder.Services.AddMyTransient();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
}
);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Office Management",
        Description = ".NET 8 / ASP.NET Core Web App MVC",
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        //Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
        Description = "'Bearer' [bo�luk] 'tokeniniz' �eklinde a�a��daki alan� doldurunuz..\r\n\r\n�rnek: \"Bearer benimtokenim\"",
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer",

                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtBearerOptions =>
{
    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["TokenOptions:Issuer"],
        ValidAudience = builder.Configuration["TokenOptions:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenOptions:SecurityKey"])),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();


var app = builder.Build();

app.Use(async (context, next) =>
{
    var accessToken = context.Request.Query["access_token"];
    if (!string.IsNullOrEmpty(accessToken))
    {
        context.Request.Headers["Authorization"] = "Bearer " + accessToken;
    }

    await next.Invoke().ConfigureAwait(false);
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseCors("CorsPolicy");

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*
 * A�a��daki g�revler yap�lamad�:
Employee olu�turulurken, email adresi benzersiz olmal�. Ayn� email ile kay�t yap�lmaya
�al���ld���nda bir hata d�nd�r�lmelidir.
� Role eklerken, e�er IsAdmin true ise, bu rol sadece y�neticiler taraf�ndan atanabilmelidir. Bu
i�lem validasyonla kontrol edilmelidir.
*/
