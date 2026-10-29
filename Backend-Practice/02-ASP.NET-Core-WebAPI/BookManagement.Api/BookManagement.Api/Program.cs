using BookManagement.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 註冊 Controller
builder.Services.AddControllers();

// 註冊 Entity Framework Core 與 SQL Server 連線
builder.Services.AddDbContext<BookManagementDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// 設定 CORS，允許本機前端呼叫 API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins(
                  "http://localhost:5500",
                  "http://127.0.0.1:5500")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 啟用 CORS，必須在 MapControllers 之前
app.UseCors("AllowFrontend");

app.UseAuthorization();
app.MapControllers();

app.Run();