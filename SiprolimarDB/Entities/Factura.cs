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
    
    public partial class Factura
    {
        public Factura()
        {
            this.LineaFactura = new HashSet<LineaFactura>();
        }
    
        public int idFactura { get; set; }
        public System.DateTime fechaHora { get; set; }
        public double montoTotal { get; set; }
        public int cliente { get; set; }
        public int tipoFactura { get; set; }
    
        public virtual Cliente Cliente1 { get; set; }
        public virtual TipoFactura TipoFactura1 { get; set; }
        public virtual ICollection<LineaFactura> LineaFactura { get; set; }
    }
}