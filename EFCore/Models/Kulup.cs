using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Kulup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }
}
