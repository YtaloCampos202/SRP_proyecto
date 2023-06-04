//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRP_proyecto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_parqueo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_parqueo()
        {
            this.BOLETA = new HashSet<BOLETA>();
        }
    
        public int IdParqueo { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public Nullable<System.DateTime> Duracion { get; set; }
        public Nullable<decimal> Tarifa { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdVehiculo { get; set; }
        public Nullable<int> IdEspacio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        public virtual tb_cliente tb_cliente { get; set; }
        public virtual tb_espacio tb_espacio { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
        public virtual tb_vehiculo tb_vehiculo { get; set; }
    }
}
