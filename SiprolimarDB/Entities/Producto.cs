//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiprolimarDB.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.LineaFactura = new HashSet<LineaFactura>();
        }
    
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int tamaño { get; set; }
        public int cantidadExistencia { get; set; }
        public double precioVenta { get; set; }
    
        public virtual ICollection<LineaFactura> LineaFactura { get; set; }
        public virtual TamannoProducto TamannoProducto { get; set; }
    }
}
