using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class Probki
    {
        public string SampleId { get; set; }
        public string Name { get; set; }
        public SampleType Type { get; set; }
        public DateTime CollectionDate { get; set; }
        public string Description { get; set; }
    }

    public enum SampleType
    {
        DNA,
        RNA,
        Protein,
        Other
    }
}
