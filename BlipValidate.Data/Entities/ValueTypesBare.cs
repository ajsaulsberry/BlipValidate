using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace BlipValidate.Data.Entities
{
    public class ValueTypesBare
    {
        public int Id { get; set; }

        public bool TypeBoolean { get; set; }

        public byte TypeByte { get; set; }

        [NotMapped]
        public char TypeChar { get; set; }

        public decimal TypeDecimal { get; set; }

        public double TypeDouble { get; set; }

        public float TypeFloat { get; set; }

        public int TypeInt { get; set; }

        public long TypeLong { get; set; }

        [NotMapped]
        public sbyte TypeSByte { get; set; }

        public short TypeShort { get; set; }

        [NotMapped]
        public uint TypeUint { get; set; }

        [NotMapped]
        public ulong TypeUlong { get; set; }

        [NotMapped]
        public ushort TypeUshort { get; set; }
    }
}
