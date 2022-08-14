using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }

        public List<Kulup> Kulupler { get; set; } = new List<Kulup>();
    }
}
