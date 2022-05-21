using System.Collections.Generic;

namespace Projeto2GFT.Interfaces
{
    public interface IRepositorio
    {
        public interface IRepositorio<T>
        {
            List<T> Lista();
            T RetornaPorId(int id);
            void Insere(T entidade);
            void Exclui(int id);
            void Atualiza(int id, T entidade);
            int ProximoId();
        }
    }
}