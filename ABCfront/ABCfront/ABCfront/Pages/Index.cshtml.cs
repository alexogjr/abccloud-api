using Microsoft.AspNetCore.Mvc.RazorPages;
using ABCfront.Services;
using ABCfront.Models;

namespace ABCfront.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ApiService apiService)
        {
            _logger = logger;

            _apiService = apiService;
        }

        // faz o request
        // ele não converte para string, então fiz assim
        public Usuario ApiData { get; set; }
        // public async Task GetTaskAsync(string rota) => ApiData = await _apiService.GetDataFromApiAsync($"http://localhost:5246/usuario/{Models.Usuario.UsuarioId}");
        // public async Task GetServers(string rota) => ApiData = await _apiService.GetDataFromApiAsync($"http://localhost:5246/usuario//{Models.Servidor.ServidorId}");
        
        // public async Task ChamaRota(string rota) => ApiData = await _apiService.GetDataFromApiAsync($"http://localhost:5246/{rota}");
        public async Task OnGetAsync() => ApiData = await _apiService.GetDataFromApiAsync("http://localhost:5246/usuario/1");
    }
}
