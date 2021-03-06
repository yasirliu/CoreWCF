﻿using System.Net;

namespace CoreWCF.Channels
{
    interface IHttpTransportFactorySettings : ITransportFactorySettings
    {
        int MaxBufferSize { get; }
        TransferMode TransferMode { get; }
        bool KeepAliveEnabled { get; set; }
        IAnonymousUriPrefixMatcher AnonymousUriPrefixMatcher { get; }
        WebSocketTransportSettings WebSocketSettings { get; }
        AuthenticationSchemes AuthenticationScheme { get; }
        bool IsAuthenticationRequired { get; }
        bool IsAuthenticationSupported { get; }
    }
}
