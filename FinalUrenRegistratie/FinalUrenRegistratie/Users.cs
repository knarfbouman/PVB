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
    
    public partial class Users
    {
        public Users()
        {
            this.UsersProjectenLijst = new HashSet<UsersProjectenLijst>();
        }
    
        public int userId { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string gebruikersnaam { get; set; }
        public string wachtwoord { get; set; }
        public string permissie { get; set; }
        public byte[] foto { get; set; }
    
        public virtual ICollection<UsersProjectenLijst> UsersProjectenLijst { get; set; }
    }
}
