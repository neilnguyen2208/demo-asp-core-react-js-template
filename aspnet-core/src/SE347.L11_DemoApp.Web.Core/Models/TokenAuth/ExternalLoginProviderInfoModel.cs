﻿using Abp.AutoMapper;
using SE347.L11_DemoApp.Authentication.External;

namespace SE347.L11_DemoApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
