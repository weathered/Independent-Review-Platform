using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Rev.Entity;

namespace Rev.Dll
{
    public class ReviewContext:DbContext
    {

        public ReviewContext():base("name=DBReviewConnection")
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<UserPreference> UserPref { get; set; }
    }
}
