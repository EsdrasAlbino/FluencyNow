namespace WebServiceAPI
{
    using System;

    public partial class tbl_Register
    {

        public int Id_User { get; set; }

        public string Name_User { get; set; }

        public string LastName_User { get; set; }

        public string Email_User { get; set; }

        public string Password_User { get; set; }

        public DateTime? Date_User { get; set; }
    }
}
