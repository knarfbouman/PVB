//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalUrenRegistratie
{
    using System;
    using System.Collections.Generic;
    
    public partial class Taken
    {
        public Taken()
        {
            this.UsersProjectenLijst = new HashSet<UsersProjectenLijst>();
        }
    
        public int takenId { get; set; }
        public int projectId { get; set; }
        public string taak { get; set; }
        public string taakOmschrijving { get; set; }
    
        public virtual Projecten Projecten { get; set; }
        public virtual ICollection<UsersProjectenLijst> UsersProjectenLijst { get; set; }
    }
}
