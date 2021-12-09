using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ASPNETCoreEFCoreCrudOperation.Models;
using Microsoft.Data.SqlClient;

namespace ASPNETCoreEFCoreCrudOperation.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Account
        [HttpGet]//What's the use of this? The program worked normally when I try to comment this request.
        public ActionResult Login() //Function name really matters to indicate which .html name should be opened upon runtime otherwise I'd get an error.
        {
            return View();
        }//*/
        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-DOLPF4J\\SQLEXPRESS; database=SQL_basic; integrated security = SSPI;";
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from dbo.tbl_login where _username='" + acc.Name + "'  and _password= '" + acc.Password + "' ";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Create");
            }
            else
            {
                con.Close();
                return View("Error");
            }

        }
    }
}
