using EvidencePojistencu.Data;
using EvidencePojistencu.Models;

namespace EvidencePojistencu.Services
{
    public class DatabazeService
    {
        private readonly EvidenceContext _context;

        public DatabazeService(EvidenceContext context)
        {
            _context = context;
        }

        public void Pridej(Pojistenec p)
        {
            _context.Pojistenci.Add(p);
            _context.SaveChanges();
        }

        public List<Pojistenec> VratVsechny()
        {
            return _context.Pojistenci.ToList();
        }

        public Pojistenec? Najdi(string jmeno, string prijmeni)
        {
            return _context.Pojistenci.FirstOrDefault(p =>
                p.Jmeno.ToLower() == jmeno.ToLower() &&
                p.Prijmeni.ToLower() == prijmeni.ToLower());
        }
    }
}
