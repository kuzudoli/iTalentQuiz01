using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Fakulte
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Rektor Rektor { get; set; }

        public List<Bolum> Bolumler { get; set; } = new List<Bolum>();
    }
}
