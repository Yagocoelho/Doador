using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Doador.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Doador.Service.Service
{
    public class DoadorService : IDoadorService
    {
        private readonly IDoadorRepository _repository;
        public DoadorService(IDoadorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DoadorCommand>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<DoadorProdutoViewModel>> GetAllDoadoresProdutos()
        {
            return await _repository.GetAllDoadoresProdutos();
        }

        public async Task<string> PostAsync(DoadorCommand command)
        {
          return  await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}