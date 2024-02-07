using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository: IProdutoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryInsert = @"
            INSERT INTO Produto(NomeProduto, Descricao, Categoria, DisponibilidadeAdocao, DoadorId)
            VALUES( @NomeProduto, @Descricao, @Categoria, @DisponibilidadeAdocao, @DoadorId)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {

                    NomeProduto = command.NomeProduto,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    DisponibilidadeAdocao = command.DisponibilidadeAdocao,
                    DoadorId = command.DoadorId,
                    
                });

                return "Produto Cadastrado com sucesso";
            }
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
