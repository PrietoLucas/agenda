using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;
using Agenda.DTO;

namespace Agenda.BLL
{
    public class ContatoBLL
    {
        public static int InserirContatoBLL(Contato objContato)
        {
            return ContatoDAL.InserirContatoDAL(objContato);
        }
    }
}
