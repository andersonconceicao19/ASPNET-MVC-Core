using DevIO.Domain.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Domain.Interfaces
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
