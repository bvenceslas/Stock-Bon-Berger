﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data
{
    public class Constants
    {
        public class Table
        {
            public const string APPROVISIONNEMENT = "tApprov";
            public const string CATEGORIE_CLIENT = "tCategClient";
            public const string CATEGORIE_PIECE = "tCategPiece";
            public const string UTILISATEUR = "tUtilisateur";
            public const string CLIENT = "tClient";
            public const string COMMANDE = "tCommande";
            public const string DETAIL_COMMANDE = "tDetailCommande";
            public const string DETAIL_VENTE = "tDetailVente";
            public const string DETAIL_APPROVISIONNEMENT = "tDetailApprov";
            public const string FOURNISSEUR = "tFournisseur";
            public const string MODE_PAIEMENT = "tModePaiement";
            public const string PAIEMENT = "tPaiement";
            public const string VENTE = "tVente";
            public const string PIECE = "tPiece";
        }

        public class View
        {
            public const string LIST_PIECES = "v_list_pieces";
            public const string LIST_CLIENTS = "v_list_clients";
            public const string LIST_DETAIL_APPROV = "v_list_detail_approv";
            public const string LIST_APPROV = "v_list_approv";
            public const string LIST_CMD = "v_list_cmd";
            public const string LIST_DETAIL_CMD = "v_list_detail_cmd";
        }

        public class Procedure
        {

        }
    }
}
