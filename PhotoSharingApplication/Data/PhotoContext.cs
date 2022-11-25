using PhotoSharingApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharingApplication.Data
{
    public class PhotoContext:DbContext
    {
        public PhotoContext():base ("PhotoKeyDB") { }

        public DbSet<Photo> fotos { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}