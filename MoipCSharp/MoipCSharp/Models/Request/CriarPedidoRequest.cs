﻿#pragma warning disable IDE1006
namespace MoipCSharp.Models
{
    public class CriarPedidoRequest
    {
        public string ownId { get; set; }
        public Amount amount { get; set; }
        public Item[] items { get; set; }
        public Customer customer { get; set; }
        public Receiver[] receivers { get; set; }
    }
}