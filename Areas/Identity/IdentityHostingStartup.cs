using System;
using FinanceManage.Areas.Identity.Data;
using FinanceManage.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FinanceManage.Areas.Identity.IdentityHostingStartup))]
namespace FinanceManage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FinanceManageContextConnection")));

                services.AddDefaultIdentity<FinanceManageUser>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireLowercase = false;
        })
                    .AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}