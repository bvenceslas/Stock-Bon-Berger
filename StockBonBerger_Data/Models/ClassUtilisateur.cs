﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    class Utilisateur : Base
    {
        public string NomsAgent { get; set; }

        public string NomUtilisateur { get; set; }

        public string MotDePasse { get; set; }

        public string Droits { get; set; }

        public string SchemaUtilisateur { get; set; }

        public bool Actif { get; set; }
    }
}
