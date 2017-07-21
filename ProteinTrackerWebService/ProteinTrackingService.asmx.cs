using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProteinTrackerWebService
{
    [WebService(Namespace = "http://simpleprogrammer.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ProteinTrackingService : System.Web.Services.WebService
    {

        [WebMethod(Description = "Adds an amount to the total..", EnableSession = true)]
        public int AddProtein(int amount, int userId)
        {
            if (Session["user" + userId] == null)
                return -1;
            var user = (User)Session["user" + userId];
            user.Total += amount;
            Session["user" + userId] = user;

            return user.Total;
        }

        [WebMethod(Description = "Adds a new user in the Session..", EnableSession = true)]
        public int AddUser(string name, int goal)
        {
            var userId = 0;
            if (Session["userId"] != null)
                userId = (int)Session["userId"];
            Session["user" + userId] = new User { Goal = goal, Name = name, Total = 0, UserId = userId };
            Session["userId"] = userId + 1;

            return userId;
        }

        [WebMethod(Description = "Lists the users added in the Session..", EnableSession = true)]
        public List<User> ListUsers()
        {
            var users = new List<User>();
            var userId = 0;
            if (Session["userId"] != null)
                userId = (int)Session["userId"];
            for (var i = 0; i < userId; i++)
            {
                users.Add((User)Session["user" + i]);
            }

            return users;
        }

    }
}
