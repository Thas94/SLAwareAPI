using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SLAwareApi.Entities.SLAware;

public partial class slaware_dataContext : DbContext
{
    public slaware_dataContext(DbContextOptions<slaware_dataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientTier> ClientTiers { get; set; }

    public virtual DbSet<ClientTierCommunicationType> ClientTierCommunicationTypes { get; set; }

    public virtual DbSet<ClientTierSeverityLevel> ClientTierSeverityLevels { get; set; }

    public virtual DbSet<CommunicationType> CommunicationTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SlaSeverityLevel> SlaSeverityLevels { get; set; }

    public virtual DbSet<SlaSeverityLevelRule> SlaSeverityLevelRules { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<TicketActivityLog> TicketActivityLogs { get; set; }

    public virtual DbSet<TicketMessage> TicketMessages { get; set; }

    public virtual DbSet<TicketNotification> TicketNotifications { get; set; }

    public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientTier>(entity =>
        {
            entity.ToTable("Client_Tiers");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ClientTierCommunicationType>(entity =>
        {
            entity.ToTable("Client_Tier_Communication_Types");

            entity.Property(e => e.ClientTierId).HasColumnName("Client_Tier_Id");
            entity.Property(e => e.CommunicationTypeId).HasColumnName("Communication_Type_Id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
        });

        modelBuilder.Entity<ClientTierSeverityLevel>(entity =>
        {
            entity.ToTable("Client_Tier_Severity_Levels");

            entity.Property(e => e.ClientTierId).HasColumnName("Client_Tier_Id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(1000)
                .HasColumnName("Created_By");
            entity.Property(e => e.SlaSeverityLevelId).HasColumnName("SLA_Severity_Level_Id");
        });

        modelBuilder.Entity<CommunicationType>(entity =>
        {
            entity.ToTable("Communication_Types");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("Role_Name");
        });

        modelBuilder.Entity<SlaSeverityLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SLA_Policy");

            entity.ToTable("SLA_Severity_Levels");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<SlaSeverityLevelRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SLA_Policy_Rules");

            entity.ToTable("SLA_Severity_Level_Rules");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.InitialResponseHours).HasColumnName("Initial_Response_Hours");
            entity.Property(e => e.SlaSeverityLevelId).HasColumnName("SLA_Severity_Level_Id");
            entity.Property(e => e.TargetResolutionHours).HasColumnName("Target_Resolution_Hours");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.ToTable("Ticket");

            entity.Property(e => e.AssignedToId).HasColumnName("Assigned_To_Id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedById).HasColumnName("Created_By_Id");
            entity.Property(e => e.IsResolutionSlaBreach).HasColumnName("IsResolution_SLA_Breach");
            entity.Property(e => e.IsResponseSlaBreach).HasColumnName("IsResponse_SLA_Breach");
            entity.Property(e => e.PausedDtm)
                .HasColumnType("datetime")
                .HasColumnName("Paused_DTM");
            entity.Property(e => e.RemainingResolutionDueDtm)
                .HasColumnType("datetime")
                .HasColumnName("Remaining_Resolution_Due_DTM");
            entity.Property(e => e.RemainingResponseDueDtm)
                .HasColumnType("datetime")
                .HasColumnName("Remaining_Response_Due_DTM");
            entity.Property(e => e.ResolutionDueDtm)
                .HasColumnType("datetime")
                .HasColumnName("Resolution_Due_DTM");
            entity.Property(e => e.ResolvedDtm)
                .HasColumnType("datetime")
                .HasColumnName("Resolved_DTM");
            entity.Property(e => e.ResponseDueDtm)
                .HasColumnType("datetime")
                .HasColumnName("Response_Due_DTM");
            entity.Property(e => e.SlaSeverityLevelId).HasColumnName("SLA_Severity_Level_Id");
            entity.Property(e => e.Subject).HasMaxLength(50);
            entity.Property(e => e.TicketNumber).HasColumnName("Ticket_Number");
            entity.Property(e => e.TicketStatusId).HasColumnName("Ticket_Status_Id");
        });

        modelBuilder.Entity<TicketActivityLog>(entity =>
        {
            entity.ToTable("Ticket_Activity_Log");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.NewTicketStatusId).HasColumnName("New_Ticket_Status_Id");
            entity.Property(e => e.OldTicketStatusId).HasColumnName("Old_Ticket_Status_Id");
            entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UserId).HasColumnName("User_Id");
        });

        modelBuilder.Entity<TicketMessage>(entity =>
        {
            entity.ToTable("Ticket_Messages");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.MessageContent).HasColumnName("Message_Content");
            entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
        });

        modelBuilder.Entity<TicketNotification>(entity =>
        {
            entity.ToTable("Ticket_Notifications");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.IsRead).HasColumnName("Is_Read");
            entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UserId).HasColumnName("User_Id");
        });

        modelBuilder.Entity<TicketStatus>(entity =>
        {
            entity.ToTable("Ticket_Status");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Created_At");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("Created_By");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.ClientTierId).HasColumnName("Client_Tier_Id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
