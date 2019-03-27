﻿using System;

namespace FbxSharp
{
    public struct InputLocation
    {
        public InputLocation(int line, int column, int index, string filename)
        {
            Line = line;
            Column = column;
            Index = index;
	    Filename = filename;
        }

        public readonly int Line;
        public readonly int Column;
        public readonly int Index;
	public readonly string Filename;
    }
}

