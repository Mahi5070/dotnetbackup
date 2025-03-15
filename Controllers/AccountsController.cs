using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using TruYum_APP.Models;

namespace TruYum_APP.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin lg)
        {
            string constr = ConfigurationManager.ConnectionStrings["Truyum"].ConnectionString;
            using(SqlConnection con=new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = $"select * from usermaster where userid='{lg.UId}' and password='{lg.Pwd}'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //   TempData["msg"] = "login successfull";
                    Session["userid"] = dt.Rows[0]["userid"].ToString();
                    Session["fullname"] = dt.Rows[0]["fullname"].ToString();
                    Session["role"] = dt.Rows[0]["roleid"].ToString();
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.Clear();
                    TempData["msg"] = "incorrect userid/password";
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Accounts");
        }
    }
}