//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employees.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public string Id_Employee { get; set; }
        public string Fullname { get; set; }
        public string Id_Office { get; set; }
        public string Position { get; set; }
    
        public virtual Office Office { get; set; }
    }
}