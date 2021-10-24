﻿using System.Runtime.InteropServices;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct EntityDetails
    {
        [FieldOffset(8)]
        public PathEntityOffsets PathName;

        [FieldOffset(0x30)]
        public long ComponentLookUpPtr;

        public override string ToString()
        {
            return $"PathName: {PathName} ComponentLookUpPtr: {ComponentLookUpPtr}";
        }
    }
}
