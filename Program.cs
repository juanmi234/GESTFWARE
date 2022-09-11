using Persistencia;
//Importante tener aquí el builder.Services.AddDbContext<>
//Para poder Listar las entidades en la página web

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Crear un contexto de datos, (Conectar con el db Context)
builder.Services.AddDbContext<Persistencia.AppContext>();

//Inyección de dependencias por cada interfaz y la clase que implementa
builder.Services.AddScoped<IRMunicipio,RMunicipio>();

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