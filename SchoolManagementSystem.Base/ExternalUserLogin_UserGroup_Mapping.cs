//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExternalUserLogin_UserGroup_Mapping
    {
        public int ExternalUserLogin_UserGroup_ID { get; set; }
        public Nullable<int> ExternalUserLoginID { get; set; }
        public Nullable<int> UserGroupId { get; set; }
    
        public virtual ExternalUserLogin ExternalUserLogin { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
