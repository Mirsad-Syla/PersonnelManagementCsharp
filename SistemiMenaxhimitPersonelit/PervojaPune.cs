//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemiMenaxhimitPersonelit
{
    using System;
    using System.Collections.Generic;
    
    public partial class PervojaPune
    {
        public int ID { get; set; }
        public int OrganizataID { get; set; }
        public int PersoniID { get; set; }
        public int VitePervoje { get; set; }
        public string Pergjegjesite { get; set; }
    
        public virtual Organizata Organizata { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
