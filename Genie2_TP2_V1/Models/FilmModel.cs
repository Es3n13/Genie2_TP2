using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genie2_TP2.Models
{
    public class FilmModel
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }

        // Liste utilisée pour afficher les étoiles
        public List<int> Stars => Enumerable.Range(1, Rating).ToList();
    }
}
