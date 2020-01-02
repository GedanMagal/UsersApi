using System.ComponentModel.DataAnnotations;

namespace ContatosApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome Obrigatório")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Username obrigatorio")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password Obrigatorio")]
        public string Password { get; set; }

        public string PhotoPerfil { get; set; }        


    }
}