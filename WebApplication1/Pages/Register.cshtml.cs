using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Data;
using WebMatrix.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace WebApplication1.Pages
{
    
    public class RegisterModel : PageModel
    {
        public void OnPost()
       {
            string Name = Request.Form["Name"];
            string Password = Request.Form["Pass"];
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=tcp:sqlservertouse1000.database.windows.net,1433;Initial Catalog=coreDB;Persist Security Info=False;User ID=adminsa;Password=RDMJ@july2037;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("INSERT INTO Users (Name, Pass) VALUES (@0,@1)", conn);
                // Add the parameters.
                command.Parameters.Add(new SqlParameter("0", Name));
                command.Parameters.Add(new SqlParameter("1", Password));

                command.ExecuteNonQuery();


            }
      
        }

        public void OnGet()
        {
          
        }
    }
}