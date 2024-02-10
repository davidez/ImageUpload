using ImageUpload.Components;

namespace ImageUpload {
	public class Program {
		public static void Main(string[] args) {
			var builder = WebApplication.CreateBuilder(args);


			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents();

			//builder.Services.Configure<FormOptions>(options => {
			//	options.MultipartBodyLengthLimit = 104857600; // default should be 128 MB as showed in the tooltip
			//});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment()) {
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();
			app.UseAntiforgery();

			app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}
