﻿using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    /// Parameters: None
    /// 
    /// An operator can use the restart command to force the server to 
    /// restart itself. This message is optional since it may be viewed as a
    /// risk to allow arbitrary people to connect to a server as an operator
    /// and execute this command, causing (at least) a disruption to service.
    /// 
    /// The RESTART command MUST always be fully processed by the server to
    /// which the sending client is connected and MUST NOT be passed noto
    /// other connected servers.
    /// </summary>
    public static class RestartExtension
    {
        public static void Restart(this ApiWrapper apiWrapper, StreamWriter writer)
        {
            writer.WriteLine("RESTART");
        }
    }
}
