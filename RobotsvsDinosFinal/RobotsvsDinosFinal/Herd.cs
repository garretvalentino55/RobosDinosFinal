using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosFinal
{
    class Herd
    {

        public List<Dinosaur> dinosaurs;
        public Herd()
        {
            Dinosaur stegosaurus = new Dinosaur("Steg");
            Dinosaur ankylosaurus = new Dinosaur("Bebop");
            Dinosaur triceratops = new Dinosaur("Rocksteady");
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(stegosaurus);
            dinosaurs.Add(ankylosaurus);
            dinosaurs.Add(triceratops);
        }

    }
}
