//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OhridCityPassClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int Id { get; set; }
        public string News1 { get; set; }
        public int Author { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public bool onFrontPage { get; set; }
    
        public virtual Administrator Administrator { get; set; }
    }
}