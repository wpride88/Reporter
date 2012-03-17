using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Reporter1.Models;
using LinqToSqlShared;


namespace Reporter1.Controllers
{
    public class SSQLController : Controller
    {
        //
        // GET: /SSQL/

        public ActionResult Index()
        {
            //REPORTEREntities1 db = new REPORTEREntities1();
            //db.Connection.ConnectionString.Select(db.jobs);
            //SqlDataSource ss = new SqlDataSource();
            ////SqlDataSource1 

            //string connectionString = WebConfigurationManager.ConnectionStrings["jobs"].ConnectionString;
            //SqlConnection con = new SqlConnection(connectionString);
            //    //con.DataSource(SqlDataSource1);

            //string sql = "create table test3(id int identity(1,1) primary key, SecondField varchar(10))";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

            //Data Source=.\sqlexpress;Initial Catalog=REPORTER;Integrated Security=True;Pooling=False

             //SELECT dbo.jobs.Date, dbo.jobtype.JTitle, dbo.UsersRP.Login, SUM(dbo.jobs.Jtimeh) AS SumTime1, dbo.jobs.Jname
             //FROM dbo.jobs
             //INNER JOIN dbo.jobtype ON dbo.jobs.Jtid = dbo.jobtype.Jid
             //INNER JOIN dbo.UsersRP ON dbo.jobs.Uid = dbo.UsersRP.Id
             //GROUP BY dbo.jobs.Date, dbo.jobtype.JTitle, dbo.UsersRP.Login, dbo.jobs.Jname)

               System.Web.UI.WebControls.Parameter pp = new System.Web.UI.WebControls.Parameter();
               string sss;

               //pp.Name = "Login";
               //pp.DefaultValue = sss; 
               //System.Web.UI.ControlsSqlDataSource3.SelectParameters.Add(pp);

            return View();
        }

    }
}
