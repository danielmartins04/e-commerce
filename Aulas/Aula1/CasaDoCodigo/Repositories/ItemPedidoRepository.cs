using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{

    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int ItemPedidoId);
    }

    public class ItemPedidoRepository : BaseRepositiry<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int ItemPedidoId)
        {
            return dbSet.Where(ip => ip.Id == ItemPedidoId).SingleOrDefault();
        }
    }
}
