﻿using System;
using Discord.Commands;
using Discord.Net;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace DiscordBot.TasksClient
{
    public class Messages : ModuleBase<SocketCommandContext>
    {
        public static int MsgCount { get; set; } = 0;
        public Task MsgCouter(SocketMessage msg)
        {
            if(!msg.Author.IsBot)
            MsgCount++;
            return Task.CompletedTask;
        }

    }
}
