//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quinto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipo
    {
        public Equipo()
        {
            this.EquiposFutbolistas = new HashSet<EquipoFutbolista>();
        }
    
        public int equipoID { get; set; }
        public string nomEquipo { get; set; }
    
        public virtual ICollection<EquipoFutbolista> EquiposFutbolistas { get; set; }
    }
}
