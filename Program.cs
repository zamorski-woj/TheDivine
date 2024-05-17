using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace TheDivine
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
			builder.Services.AddLocalization();
			builder.Services.AddControllers();

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




			var supportedCultures = new[] { "en", "pl", "de" };
			var localizationOptions = new RequestLocalizationOptions()
				.SetDefaultCulture(supportedCultures[0])
				.AddSupportedCultures(supportedCultures)
				.AddSupportedUICultures(supportedCultures);
			app.UseRequestLocalization(localizationOptions);

			app.MapControllers();






			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}