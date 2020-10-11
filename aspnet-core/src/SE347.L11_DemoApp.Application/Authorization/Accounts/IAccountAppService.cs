﻿using System.Threading.Tasks;
using Abp.Application.Services;
using SE347.L11_DemoApp.Authorization.Accounts.Dto;

namespace SE347.L11_DemoApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
