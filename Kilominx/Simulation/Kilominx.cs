using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Kilo.Simulation
{
    class Kilominx
    {
        private string[] Faces = { "U", "F", "R", "L", "BR", "BL", "D", "DB", "DR", "DL", "DBR", "DBL" };
        public string[] Stickers;

        public Kilominx()
        {
            Stickers = Faces.SelectMany(face => new[] { face, face, face, face, face })
                                        .ToArray();
        }
    }
}
