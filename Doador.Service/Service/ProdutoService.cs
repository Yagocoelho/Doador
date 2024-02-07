using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {
            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
