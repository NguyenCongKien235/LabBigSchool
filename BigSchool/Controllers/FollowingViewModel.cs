using BigSchool.Models;
using System.Collections.Generic;

namespace BigSchool.Controllers
{
    internal class FollowingViewModel
    {
        public List<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}