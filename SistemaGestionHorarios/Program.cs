using Microsoft.EntityFrameworkCore;
using SistemaGestionHorarios.Infrastructure;

namespace SistemaGestionHorarios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 🔗 Base de Datos
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // 🧠 MVC
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // ⚠️ ESTA LÍNEA FALTABA (MUY IMPORTANTE)
            app.UseRouting();

            app.UseHttpsRedirection();
            app.UseAuthorization();

            // 🌐 RUTEO MVC
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=ScheduleItems}/{action=Index}/{id?}");

            app.Run();
        }
    }
}