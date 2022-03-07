using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using MVC_Webgrid.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;



namespace MVC_Webgrid.Controllers
{
    public class HomeController : Controller
    {
        string mainconn = @"Data Source=PERSONALSRV-KAR\SQL2016;Initial Catalog=29dey;User ID=sa;Password=12341234";

        public HomeController()
        {
        }


        public ActionResult Index()
        {
            
            return View();
            
           
        }

        public ActionResult but()
        {

            var Userid = TempData["idd"];
            DataTable dt = new DataTable();
            //SampleDBEntities sd = new SampleDBEntities();
            Entities sd = new Entities();
            return View(sd.AspNetUsers.Where(x => x.Id==Userid).ToList());
            //using (SqlConnection sqlconn = new SqlConnection(mainconn))
            //{
            //    sqlconn.Open();
            //    SqlCommand sqlcomm = new SqlCommand();

            //    string sqlquery = "select * from [29dey].[dbo].[AspNetUsers] where Id='" + Userid + "'";
            //    //sqlcomm.CommandText = sqlquery;
            //    //sqlcomm.Connection = sqlconn;
            //    SqlDataAdapter sda = new SqlDataAdapter(sqlquery, sqlconn);
            //    sda.Fill(dt);
            //}
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            //return View(dt);
            //var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

        }
        [Authorize(Roles="Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your admin page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}