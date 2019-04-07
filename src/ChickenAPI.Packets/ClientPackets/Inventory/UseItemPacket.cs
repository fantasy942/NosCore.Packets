﻿using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Inventory
{
    [PacketHeader("u_i")]
    public class UseItemPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [Range(0, 9)]
        [PacketIndex(2)]
        public PocketType Type { get; set; }

        [PacketIndex(3)]
        public short Slot { get; set; }

        [PacketIndex(4)]
        public short Mode { get; set; }

        [PacketIndex(5)]
        public short Parameter { get; set; }
    }
}