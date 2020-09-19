using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrayerWall
{
    public class PrayerRequest : DbRequest
    {
        public DbSet<Wall> Walls { get; set; }
        public DbSet<Chain> Chains { get; set; }

        protected override void OnConfiguring(DbRequestOptionsBuilder options)
            => options.UseSqlite("Data Source=prayer.db");
    }

    public class Wall
    {
        public int WallId { get; set; }
        public string Url { get; set; }

        public List<Chain> Chains { get; } = new List<Chain>();
    }

    public class Chain
    {
        public int ChainId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int WallId { get; set; }
        public Wall Wall { get; set; }
    }
}
