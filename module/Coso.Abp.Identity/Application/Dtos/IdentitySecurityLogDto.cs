﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Coso.Abp.Identity.Application.Dtos
{
    public class IdentitySecurityLogDto : EntityDto<Guid>
    {

        public string ApplicationName { get; protected set; }

        public string Identity { get; protected set; }

        public string Action { get; protected set; }

        public Guid? UserId { get; protected set; }

        public string UserName { get; protected set; }

        public string TenantName { get; protected set; }

        public string ClientId { get; protected set; }

        public string CorrelationId { get; protected set; }

        public string ClientIpAddress { get; protected set; }

        public string BrowserInfo { get; protected set; }

        public DateTime CreationTime { get; protected set; }
    }
}
