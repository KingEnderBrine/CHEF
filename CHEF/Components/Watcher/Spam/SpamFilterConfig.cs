﻿using System.ComponentModel.DataAnnotations;

namespace CHEF.Components.Watcher.Spam
{
    public class SpamFilterConfig
    {
        [Key]
        public int Id { get; set; }
        public ActionOnSpam ActionOnSpam { get; set; }
        public ulong MuteRoleId { get; set; }
        public int MessagesForAction { get; set; }
        public int MessageSecondsGap { get; set; }
        public bool InlcudeMessageContentInLog { get; set; }
    }
}
