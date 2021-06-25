using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IVeiculoRepository
    {
        Task Criar(Veiculo veiculo);
        Task Alterar(Veiculo veiculo);
        Task Excluir(Veiculo veiculo);
        Task<Veiculo> BuscarPorId(int id);
        Task<IEnumerable<Veiculo>> BuscarPorMarca(string marca);
        Task<IEnumerable<Veiculo>> BuscarPorModelo(string modelo);
        Task<IEnumerable<Veiculo>> ListarTodosVeiculos();
    }
}
