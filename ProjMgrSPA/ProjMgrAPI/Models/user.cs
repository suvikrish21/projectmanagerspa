//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjMgrAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> emp_id { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<int> task_id { get; set; }
    
        public virtual project project { get; set; }
        public virtual task task { get; set; }
    }
}
