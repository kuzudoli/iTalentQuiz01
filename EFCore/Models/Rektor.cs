using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Rektor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int FakulteId { get; set; }
        public Fakulte Fakulte { get; set; }
    }
}
