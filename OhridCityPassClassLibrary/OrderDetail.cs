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
    
    public partial class OrderDetail
    {
        public int PackageId { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> PackageUnits { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Package Package { get; set; }
    }
}
