﻿#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ListarTodasAsPreferenciasDeNotificacaoResponse
    {
        public Listas[] Listas { get; set; }
    }

    public class Listas
    {
        public string[] events { get; set; }
        public string target { get; set; }
        public string media { get; set; }
        public string token { get; set; }
        public string id { get; set; }
    }
}