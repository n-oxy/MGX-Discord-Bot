﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Http;
using System.Management;
using System.Reflection;

using Discord;
using Discord.API;
using Discord.Commands;
using Discord.Net;
using Discord.Rest;
using Discord.WebSocket;

using MGX_Discord_Bot.EModules.Scheduler;
using MGX_Discord_Bot.EModules.Holders.CommandHolders;
using MGX_Discord_Bot.EModules.Holders.InternalHolders;
using MGX_Discord_Bot.EModules.Entities;

namespace MGX_Discord_Bot.EModules.Commands.General
{
    class sudo
    {
        public static CommandInformation Info = new CommandInformation()
        {
            Alias = false,
            Category = "fun",
            Premium = false,
            RequiredPermissions = 18
        };
        public static async Task Maindo(SocketMessage arg)
        {
            if(arg.Content.ToLower().Contains(' '))
            {
                string ToRelay = arg.Content.ToLower().Split(new[] { ' ' }, 2)[1];

                if(ToRelay.Trim().Length > 1)
                {
                    await arg.Channel.SendMessageAsync(ToRelay);
                }
            }
        }
    }
}
