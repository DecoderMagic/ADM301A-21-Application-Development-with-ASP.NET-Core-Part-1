using Microsoft.EntityFrameworkCore;

namespace FAQsApp.Models
{
    public class FAQsAppDbContext : DbContext
    {
        public FAQsAppDbContext(DbContextOptions<FAQsAppDbContext> options) : base(options)
        {
        }

        public DbSet<FAQ>? FAQs { get; set; }
        public DbSet<Topic>? Topics { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "history", Name = "History" },
                new Category { CategoryId = "general", Name = "General" }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "linux", Name = "Linux" },
                new Topic { TopicId = "fedora", Name = "Fedora" },
                new Topic { TopicId = "ubuntu", Name = "Ubuntu" },
                new Topic { TopicId = "archlinux", Name = "Arch Linux" }
            );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    FAQId = 1,
                    Question = "What is Linux?",
                    Answer = @"Linux is a family of open-source Unix-like operating 
                               systems based on the Linux kernel, an operating system 
                               kernel first released on September 17, 1991, by Linus 
                               Torvalds. Linux is typically packaged in a Linux distribution.",
                    TopicId = "linux",
                    CategoryId = "general"
                },
                new FAQ
                {
                    FAQId = 2,
                    Question = "What is Fedora?",
                    Answer = @"Fedora is a Linux distribution developed by the
                               community-supported Fedora Project which is 
                               sponsored primarily by Red Hat, a subsidiary of IBM, 
                               with additional support from other companies.", 
                    TopicId = "fedora",
                    CategoryId = "history"
                },
                new FAQ
                {
                    FAQId = 3,
                    Question = "What is Ubuntu?",
                    Answer = @"Ubuntu is a Linux distribution based on Debian 
                               and composed mostly of free and open-source software. 
                               Ubuntu is officially released in three editions: 
                               Desktop, Server, and Core for Internet of things devices 
                               and robots.",
                    TopicId = "ubuntu",
                    CategoryId = "history"
                },
                new FAQ
                {
                    FAQId = 4,
                    Question = "What is Arch Linux?",
                    Answer = @"Arch Linux is a Linux distribution for computers 
                               with x86-64 processors. Arch Linux adheres to five 
                               principles: simplicity, modernity, pragmatism, user 
                               centrality, and versatility.",
                    TopicId = "archlinux",
                    CategoryId = "history"
                }
            );
        }
    }
}

