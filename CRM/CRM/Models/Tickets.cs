//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tickets
    {
        public int id { get; set; }
        public int department_id { get; set; }
        public int user_id { get; set; }
        public int status_id { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> mail_data { get; set; }
        public string reference { get; set; }
        public string responce { get; set; }
        public Nullable<int> parent_id { get; set; }
        public int task_id { get; set; }
        public int manager_id { get; set; }
        public int cust_id { get; set; }
    }
}
