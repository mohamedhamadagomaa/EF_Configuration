﻿using CallGroupingConfigurationUsingAssembly.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CallGroupingConfigurationUsingAssembly.Data.Config
{
    internal class TweetConfig : IEntityTypeConfiguration<Tweet>
    {
        public void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.ToTable("tblTweets");
        }
    }
}
