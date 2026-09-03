using DIServiceLifetime.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// service transient: A new instance is provided every time it is requested.
builder.Services.AddTransient<IMessageService, MessageService>();
// Scoped: A new instance is created once per request within the scope. It is equivalent to a singleton in the context of a single request.
builder.Services.AddScoped<IScopedMessageService, ScopedMessageService>();

// Singleton : A single instance is created and shared throughout the application's lifetime.
builder.Services.AddSingleton<ISingletonMessageService, SingletonMessageService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
