namespace SegundoParcial
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public bool admin { get; set; }
        public bool activo { get; set; }

        public Usuario()
        {
            usuario = "";
            contrasena = "";
            admin = false;
            activo = false;
        }
    }
}
