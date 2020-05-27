using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.DTO
{
    public class EnderecoDTO
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 2)]    
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = " O campo precisa ter entre {1} e {2} caracter ", MinimumLength = 2)]
        public string Estado { get; set; }

        public Guid FornecedorId { get; set; }

        /* EF Relation */
        public FornecedorDTO Fornecedor { get; set; }
    }
}
