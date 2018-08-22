﻿using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AzureADLabDNSControl.Controllers.api
{
    public class DnsController : ApiController
    {
        public async Task UpdateTxtRecord(DnsDTO data)
        {
            using (var dns = new DnsAdmin())
            {
                await dns.SetTxtRecord(data.TxtRecord, data.DomainName);
            }
        }
    }

    public class DnsDTO
    {
        public string TxtRecord { get; set; }
        public string DomainName { get; set; }
    }
}
