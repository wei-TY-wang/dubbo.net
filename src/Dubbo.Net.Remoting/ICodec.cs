﻿using DotNetty.Buffers;

namespace Dubbo.Net.Remoting
{
    public interface ICodec
    {
        void Encode(IChannel channel, IByteBuffer buffer, object message);
        object Decode(IChannel channel, IByteBuffer buffer);
    }

    public enum DecodeResult
    {
        NeedMoreInput,
        SkipSomeInput
    }
}
