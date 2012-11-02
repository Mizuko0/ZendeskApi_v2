﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using RestSharp;
using RestSharp.Contrib;
using ZenDeskApi_v2.Requests;

namespace ZenDeskApi_v2
{
    public class ZenDeskApi
    {
        public Tickets Tickets { get; set; }
        public Attachments Attachments { get; set; }
        public Views Views { get; set; }

        public ZenDeskApi(string yourZenDeskUrl, string user, string password)
        {
            Tickets = new Tickets(yourZenDeskUrl, user, password);
            Attachments = new Attachments(yourZenDeskUrl, user, password);
            Views = new Views(yourZenDeskUrl, user, password);
        }
    }
}
