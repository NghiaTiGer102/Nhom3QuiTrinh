//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class DSBanBe
    {
        public int id { get; set; }
        public int idbanbe { get; set; }
        public string tenbanbe { get; set; }
        public int idaccount { get; set; }
        public bool yeucau { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}