using System;
using Microsoft.EntityFrameworkCore;

namespace MyBlog.Models{

    public class BlogContext : DbContext{
        public BlogContext(DbContextOptions<BlogContext> options) : base(options){

        }

        public DbSet<Author> Author{get;set;}
        public DbSet<Category> Category{get;set;}
        public DbSet<Blog> Blog{get;set;}
    }
}