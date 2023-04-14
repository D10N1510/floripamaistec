using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesPersonalizadas.Classes
{
    
        public class IngressoException : Exception
        {
            public IngressoException(String msg) : base(msg)
            {
            }

            public IngressoException(String msg, Exception causa) : base(msg, causa)
            {
            }

            public IngressoException()
            {
            }
        }
  
}
