using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabberIRC.IRC.Extensions
{
    public static class NumericRepliesExtension
    {
        public enum NumericReply
        {
            [Description("Welcome to the Internet Reply network" +
                         "<nick>!<user>@<host>")]
            RPL_WELCOME = 001, 
            [Description("Your host is <servername>, running version <ver>")]
            RPL_YOURHOST = 002,
            [Description("This server was created <date>")]
            RPL_CREATED = 003,
            [Description("<servername> <version> <available user mode>" +
                         "<available channel modes")]
            RPL_MYINFO = 004,
            [Description("Try server <server name>, port <port number>")]
            RPL_BOUNCE = 005,
            RPL_USERHOST = 302, // :*1<reply> *( " " <reply> )
            RPL_ISON = 303,
            [Description("<nick> :<away message>")]
            RPL_AWAY = 301,
            [Description(":You are no longer marked as being away")]
            RPL_UNAWAY = 305,
            [Description(":You have been marked as being away")]
            RPL_NOWAWAY = 306,
            [Description("<nick> <user> <host> * :<real name>")]
            RPL_WHOISUSER = 311,
            [Description("<nick> <server> :<server nfo>")]
            RPL_WHOISSERVER = 312,
            [Description("<nick> :is an IRC operator")]
            RPL_WHOISOPERATOR = 313,
            [Description("<nick> <integer> :seconds idle")]
            RPL_WHOISIDLE = 317,
            [Description("<nick> :End of WHOIS list")]
            RPL_ENDOFWHOIS = 318,
            RPL_WHOISCHANNELS = 319, // "<nick> :*( ( "@" / "+" ) <channel> " " )"
            [Description("<nick> <user> <host> * :<real name>")]
            RPL_WHOWASUSER = 314,
            [Description("<nick> :End of WHOWAS")]
            RPL_ENDOFWHOWAS = 369,
            [Description("Obsolete.Not used.")]
            RPL_LISTSTART = 321,
            [Description("<channel> <# visible> :<topic>")]
            RPL_LIST = 322,
            [Description(":End of LIST")]
            RPL_LISTEND = 323,
            [Description("<channel> <nickname>")]
            RPL_UNIQOPIS = 325,
            [Description("<channel> <mode> <mode params>")]
            RPL_CHANNELMODEIS = 324,
            [Description("<channel> :No topic is set")]
            RPL_NOTOPIC = 331,
            [Description("<channel> :<topic>")]
            RPL_TOPIC = 332,
            [Description("<channel> <nick>")]
            RPL_INVITING = 341,
            [Description("<user> :Summoning user to IRC")]
            RPL_SUMMONING = 342,
            [Description("<channel> <invitemask>")]
            RPL_INVITELIST = 346,
            [Description("<channel> :End of channel invite list")]
            RPL_ENDOFINVITELIST = 347,
            [Description("<channel> <exceptionmask>")]
            RPL_EXCEPTLIST = 348,
            [Description("<version>.<debuglevel> <server> :<comments>")]
            RPL_VERSION = 351,
            RPL_WHOREPLY = 352, //"<channel> <user> <host> <server> <nick> ( "H" / "G" > ["*"] [ ("@" / "+")]:<hopcount> <real name>"
        }
    }
}