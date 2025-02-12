namespace ABCfront.Models
{
    public class Usuario
    {
        public static int UsuarioId { get; set; } = 0;
        public bool IsAdmin { get; set; } = false;
        public int[]? UsuarioServidor { get; set; }
        public string[]? UsuarioServico { get; set; } = ["Plano ABC"];
        public string usuarioEmail { get; set; } = "email@abccloud.com.br";
        public string usuarioSenha { get; set; } = "abccloud";
    }
}
