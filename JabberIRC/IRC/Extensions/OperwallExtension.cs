﻿using System.IO;

namespace JabberIRC.IRC.Extensions
{
    /// <summary>
    ///  Parameters: "Text to be sent"
    /// 
    /// The WALLOPS command is used to send message to all currently
    /// connected users who have set the 'w' user mode for themselves.
    /// 
    /// After implementing WALLOPS as a user command it was found that it was
    /// often and commonly abused as a means of sending a message to a lot of
    /// people. Due to this, it is RECOMMENDED that the implementation of 
    /// WALLOPS allows and recognizes only servers as the originators of 
    /// WALLOPS.
    /// 
    /// </summary>
    public static class OperwallExtension
    {
        public static void Operwall(this ApiWrapper apiWrapper, StreamWriter writer, string message)
        {
            writer.WriteLine($"WALLOPS :{message}");
        }
    }
}
