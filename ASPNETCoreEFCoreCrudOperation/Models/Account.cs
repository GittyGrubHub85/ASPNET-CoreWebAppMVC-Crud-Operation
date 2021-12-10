


namespace ASPNETCoreEFCoreCrudOperation.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Account
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}
