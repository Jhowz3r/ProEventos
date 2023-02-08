using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Application.Dtos;

namespace ProEventos.API.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        //[MinLength(4, ErrorMessage ="{0} deve ter no mínimo 4 caracteres.")]
        //[MaxLength(50, ErrorMessage ="{0} deve ter no mínimo 50 caracteres.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage ="Intervalo permitido de 4 a 50 caracteres.")]
        public string Tema { get; set; }
        
        [Display(Name = "Qtd Pessoas")]
        [Range(1, 120000, ErrorMessage = "{0} não pode ser menor que 1 e maior do que 120.000.")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="não é uma imagem válida. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage ="o campo {0} é obrigatório.")] 
        [Phone(ErrorMessage ="o campo {0} está com número inválido.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório."),
        Display(Name = "e-mail"),
        EmailAddress(ErrorMessage ="O campo {0} precisa ser um e-mail válido.")]
        public string Email { get; set; }
        
        public IEnumerable<LoteDto> Lotes { get; set; }
         public IEnumerable<RedeSocialDto> RedesSociais { get; set;}

         public IEnumerable<PalestranteDto> PalestrantesEventos { get; set; }
    }
}