namespace ABCfront.Models
{
        public class Servidor
        {
            public static int ServidorId { get; set; } = 0;
            public static string[]? ArquivosServidor { get; set; } = ["'index.js', 'abccloud.app'"];

            public string? TipoArquivo { get; set; } = ".js";
            public static string? NomeArquivo { get; set; } = "index.js";
            public static int? TamanhoArquivo { get; set; } = 124;

            public static string ArquivoInicial { get; set; } = "index.js";
            public static string StartupComando { get; set; } = "node index.js";
            public static string ServidorLinguagem { get; set; } = "nodejs";
            public static Object Consumo { get; set; } = new { Models.ServidorConsumo.MaxRam, Models.ServidorConsumo.RamUse, Models.ServidorConsumo.MaxVCpu, Models.ServidorConsumo.vCpuUse };
            public static string RamConfumo { get; set; } = "nodejs";
        }
}
