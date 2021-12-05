using Entro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Callery> Calleries { get; set; }
        public DbSet<Concerts> Concerts { get; set; }
        public DbSet<GalleryImage> GalleryImage { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionTitle> SectionTitles { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Sosial> Sosials { get; set; }

    }
}
