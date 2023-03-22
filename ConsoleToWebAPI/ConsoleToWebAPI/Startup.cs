namespace ConsoleToWebAPI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
             services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            //app.MapControllers();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from new web Api");
                });
                endpoints.MapControllers();
            });
        }
    }
}
