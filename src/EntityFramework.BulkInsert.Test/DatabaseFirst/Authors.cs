//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework.BulkInsert.Test.DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authors
    {
        public Authors()
        {
            this.Books = new HashSet<Books>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<Books> Books { get; set; }
    }
}
