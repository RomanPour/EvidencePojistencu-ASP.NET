using Microsoft.EntityFrameworkCore;
using EvidencePojistencu.Models;

namespace EvidencePojistencu.Data
{
    public class EvidenceContext : DbContext
    {
        public EvidenceContext(DbContextOptions<EvidenceContext> options) : base(options) { }

        public DbSet<Pojistenec> Pojistenci { get; set; }
    }
}
