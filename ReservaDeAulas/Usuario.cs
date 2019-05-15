using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaDeAulas
{
   public class Usuario
    {
        private int usuario_ID;
        private string user;
        private string password;

        public int Usuario_ID
        {
            get
            {
                return usuario_ID;
            }

            set
            {
                usuario_ID = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
