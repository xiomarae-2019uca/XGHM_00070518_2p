namespace SegundoParcial
{
    using System;

    namespace ClaseGUI05.Modelo
    {
        public class Registro
        {
            public int id_registro { get; set; }
            public string usuario { get; set; }
            public bool entrar { get; set; }
            public DateTime fecha { get; set; }

            public Registro()
            {
                id_registro = 0;
                usuario = "";
                entrar = false;
                fecha = DateTime.Now;
            }
        }
    }
}
