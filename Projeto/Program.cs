using AplicationTpDB.Data;
using AplicationTpDB.Interface;
using AplicationTpDB.Services;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adicionando serviços ao contêiner.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUnidadeMedicaRepository, UnidadeMedicaRepository>();
            builder.Services.AddScoped<IConsultaRepository, ConsultaRepository>();

            // Configurando DbContext com MySQL
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")));
            });

            var app = builder.Build();

            // Configurando pipeline de requisições HTTP.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Testando a conexão com o banco de dados antes de iniciar o aplicativo
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                try
                {
                    var consultas = context.Consulta.ToList();
                    Console.WriteLine($"Conexão com o banco de dados bem-sucedida. Total de consultas: {consultas.Count}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao acessar o banco de dados: {ex.Message}");
                }
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
