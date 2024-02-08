using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Doador.Domain.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=true";

        public async Task<IEnumerable<DoadorCommand>> GetAll()
        {
            string queryGetAll = "SELECT TOP 1000 * FROM Doador";
            using (SqlConnection con = new SqlConnection(conexao))
            {
                var result = await con.QueryAsync<DoadorCommand>(queryGetAll);
                return result;
            }
        }


        public async Task<string> PostAsync(DoadorCommand command)
        {
            string queryInsert = @"
            INSERT INTO Doador(DoadorNome, Cidade, Estado, Email, Telefone, Cep)
            VALUES(@DoadorNome, @Cidade, @Estado, @Email, @Telefone, @Cep)";
            using (SqlConnection conn = new SqlConnection(conexao)) 
            {
                conn.Execute(queryInsert, new
                {
                    DoadorNome = command.DoadorNome,
                    Cidade = command.Cidade,
                    DoadorId = command.DoadorId,
                    Estado = command.estado,
                    Email = command.Email,
                    Telefone = command.Telefone,
                    Cep = command.Cep,
                });

                return "Doador Cadastrado com sucesso";
            }
        }
        public void PostAsync() 
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DoadorProdutoViewModel>> GetAllDoadoresProdutos()
        {
            string queryjoin = @"
        SELECT 
        D.DoadorId, D.DoadorNome, D.Cidade, D.Estado, D.Email, D.Telefone, D.Cep,
        P.IdProduto AS IdProduto, P.NomeProduto, P.Descricao AS Descricao
        FROM Doador D
        JOIN 
        Produto P ON D.DoadorId = P.DoadorId";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                var result = await con.QueryAsync<DoadorProdutoViewModel>(queryjoin);
                return result;
            }
        }


    }


}
