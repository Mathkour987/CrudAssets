namespace CrudAssets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddMemoryCache();

           
            builder.Services.AddDistributedMemoryCache();

            
            builder.Services.AddSession();


            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

           
            app.UseResponseCaching();

            
            app.UseResponseCompression();

           
            app.UseStaticFiles();

           
            app.UseSession();

            
            app.UseRouting();

            

           
            app.UseAuthorization();

           
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
