using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Services
{
    public class AcessoService
    {
        private readonly BancoContext _bancoContext;
        public AcessoService(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<AcessoModel> FindByDate(DateTime?minDate,DateTime? maxDate)
        {
            var result = from obj in _bancoContext.Acessos select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Entrada >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Saida <= maxDate.Value);
            }
            return result
                .OrderByDescending(x=>x.Entrada)
                .ToList();
 
               
        }
    }
}
