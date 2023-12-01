using BusinessLogic.Classes;
using MediaBazarCommon.Interfaces;
using MediaBazarDataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Register the services for Shift and Employee operations
// Assuming DBOpsShift and DBOpsEmployee are the concrete implementations of IShiftRepository and IEmployeeRepository
builder.Services.AddScoped<IShiftRepository, DBOpsShift>(serviceProvider =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    return new DBOpsShift(connectionString);
});


builder.Services.AddScoped<IEmployeeRepository, DBOpsEmployee>(serviceProvider =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    return new DBOpsEmployee(connectionString);
});

// Registering the business logic services
builder.Services.AddScoped<IShiftOperations, ShiftService>();
builder.Services.AddScoped<IEmployeeOperations, EmployeeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
