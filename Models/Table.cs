//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oct142023.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Table
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Max Length for last name is 20.")]
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
