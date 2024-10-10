using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Docente
    {
        public int id { set; get; }
        public string IdDocente { set; get; } = string.Empty;
        public string NombreDocente { set; get; } = string.Empty;
        public string GeneroDocente { set; get; } = string.Empty;
        public string DireccionDocente { set; get; } = string.Empty;
        public string ImagenesDocente { set; get; } = string.Empty;
        public string StatusDocentes { set; get; } = string.Empty;
        public string InsertarFecha { set; get; } = string.Empty;
        public string ActualizarFecha { set; get; } = string.Empty;
    }
}
