using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{   
    public interface IPedidoRepository
    {

    }

    public class PedidoRepository : BaseRepositiry<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAcessor;

        public PedidoRepository(ApplicationContext contexto, IHttpContextAccessor contextAcessor) : base(contexto)
        {
            this.contextAcessor = contextAcessor;
        }

        private int? GetPedidoId()
        {
            return contextAcessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAcessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
    }
}
