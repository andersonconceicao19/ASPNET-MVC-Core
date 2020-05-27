using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.DTO
{
    public class FornecedorDTO
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 2)]
        public string Documento { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 11)]
        public int TipoFornecedor { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public bool Ativo { get; set; }

       
        public IEnumerable<ProdutoDTO> Produtos
        {
            get; set;
        }
    }
}