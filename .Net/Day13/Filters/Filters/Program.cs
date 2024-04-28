using Filters.CustomFilters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IExceptionFilterMessage, ExceptionFilterMessage>();

/*builder.Services.AddScoped<TimeElapsed>();
builder.Services.AddMvc().AddMvcOptions(options => {
    options.Filters.AddService(typeof(TimeElapsed));
});*/

/*builder.Services.AddMvc().AddMvcOptions(options => {
    options.Filters.Add(new ShowMessage("Global"));
});*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Privacy}/{id?}");

app.Run();
