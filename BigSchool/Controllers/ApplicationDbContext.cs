using System;

namespace BigSchool.Controllers
{
    internal class ApplicationDbContext
    {
        public object Courses { get; internal set; }
        public object Categories { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}