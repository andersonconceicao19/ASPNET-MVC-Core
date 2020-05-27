using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Api.DTO;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.Controllers
{
    public class FornecedorController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        
       public async Task<ActionResult<IEnumerable<FornecedorDTO>>> ObterTodos()
       {
            _fornecedorRepository.ObterTodos();

            return Ok();
       }

    }
}