﻿using System;
using System.IO;

namespace GRF
{
    public class GRF
    {
        public int FileCount { get; } = 0;

        public void Open( string path )
        {
            if( !File.Exists( path ) )
                throw new FileNotFoundException( path );
        }
    }
}
