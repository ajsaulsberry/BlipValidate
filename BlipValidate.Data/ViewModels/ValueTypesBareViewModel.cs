using System;
using System.ComponentModel.DataAnnotations;

namespace BlipValidate.Data.ViewModels
{
    public class ValueTypesBareViewModel
    {
        public bool TypeBoolean { get; set; }

        public byte TypeByte { get; set; }

        public char TypeChar { get; set; }

        public decimal TypeDecimal { get; set; }

        public  double  TypeDouble { get; set; }

        public float TypeFloat { get; set; }

        public int TypeInt { get; set; }

        public long TypeLong { get; set; }

        public sbyte? TypeSByte { get; set; }

        public short TypeShort { get; set; }

        public uint TypeUint { get; set; }

        public ulong TypeUlong { get; set; }

        public ushort TypeUshort { get; set; }
    }
}
