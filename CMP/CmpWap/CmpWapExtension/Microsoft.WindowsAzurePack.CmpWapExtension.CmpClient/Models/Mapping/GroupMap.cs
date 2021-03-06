﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Microsoft.WindowsAzurePack.CmpWapExtension.CmpClient.Models

{
    /// <summary>
    /// Entity framework class to map a Group object to the appropriate table
    /// </summary>
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Groups");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.GroupDescription).HasColumnName("GroupDescription");
            this.Property(t => t.Config).HasColumnName("Config");
            this.Property(t => t.TagData).HasColumnName("TagData");
            this.Property(t => t.TagId).HasColumnName("TagId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}

