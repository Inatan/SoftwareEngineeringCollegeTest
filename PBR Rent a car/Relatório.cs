//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBR_Rent_a_car
{
<<<<<<< HEAD
    using System;
    using System.Collections.Generic;
    
=======
>>>>>>> origin/Code_Generator_fix
    public partial class Relatório
    {
        public Relatório()
        {
            this.Histórico = new HashSet<Histórico>();
        }
    
        public int Id { get; set; }
    
        public virtual ICollection<Histórico> Histórico { get; set; }
        public virtual Funcionário Funcionário { get; set; }
    }
}
