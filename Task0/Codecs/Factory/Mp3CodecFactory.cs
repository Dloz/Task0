using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task0
{
    public class Mp3CodecFactory : ICodecFactory
    {
        public ICodec Create()
        {
            return new Mp3Codec();
        }
    }
}