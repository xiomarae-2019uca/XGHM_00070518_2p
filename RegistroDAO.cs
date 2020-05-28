namespace SegundoParcial
{
    
        public static class RegistroDAO
        {
            public static void iniciarSesion(string pUsuario)
            {
                agregarRegistro(pUsuario, true);
            }
        
            public static void cerrarSesion(string pUsuario)
            {
                agregarRegistro(pUsuario, false);
            }
        
            private static void agregarRegistro(string pUsuario, bool entra)
            {
                string sql = string.Format(
                    "insert into registro(usuario, entrar) values ('{0}', {1});",
                    pUsuario, entra);

                
            }
        }
    }
