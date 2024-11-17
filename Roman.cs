﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livres
{
    public class Roman : Livre
    {
        public string Genre { get; set; }
        public Roman(string titre, string auteur, int nbrPages, string genre):
            base(titre, auteur, nbrPages)
        {
            Genre = genre;
        }
        public new void AfficherDetails()
        {
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Nombre de Pages : {NombrePages}, Genre : {Genre}");
        }
    }
}
