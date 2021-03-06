﻿using System.Runtime.Serialization;

namespace MonoDebugger.SharedLib
{
    [DataContract]
    public class StartDebuggingMessage
    {
        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public ApplicationType AppType { get; set; }

        [DataMember]
        public byte[] DebugContent { get; set; }
    }
}