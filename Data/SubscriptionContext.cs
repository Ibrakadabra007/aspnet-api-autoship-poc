using System;
using AutoShipServicePOC.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShipServicePOC
{
    public partial class SubscriptionContext : DbContext
    {

        public SubscriptionContext(DbContextOptions<SubscriptionContext> options)
            : base(options)
        {
        }
        public DbSet<Subscription> Subscription { get; set; }

    }
}
