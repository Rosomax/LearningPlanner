//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearningPlanner
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zadania
    {
        public int IDZadania { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public string Opis { get; set; }
        public System.DateTime DataUtworzenia { get; set; }
        public bool CzyZakonczone { get; set; }
        public short IDUzytkownika { get; set; }
    }
}
