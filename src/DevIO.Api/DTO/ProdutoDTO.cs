using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.DTO
{
    public class ProdutoDTO
    {
        [Key]
        public Guid Id { get; set; }
     
        [Required(ErrorMessage = "O campo é obrigatório!!")]
        [StringLength(200, ErrorMessage = "o campo {0} precisa ter entre {1} e {2} caracter", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!!")]
        [StringLength(1000, ErrorMessage = "o campo {0} precisa ter entre {1} e {2} caracter", MinimumLength = 2)]
        public string Descricao { get; set; }


        public string ImagemUpload { get; set; }


        public string Imagem { get; set; }


        [Required(ErrorMessage = "O campo é obrigatório!!")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        public bool Ativo { get; set; }


        [Required(ErrorMessage = "O campo é obrigatório!!")]

        public Guid FornecedorId { get; set; }


        [ScaffoldColumn(false)]
        public string NomeFornecedor { get; set; }
    }
}
