using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using JsonMessageApi.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JsonMessageApi.Context
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        // Database - With specified options DI into context container
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            // DI container for the current database context.
            // This is storage for the below resources...
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Connect to SQL server database in production
            // options.UseSqlite(_configuration.GetConnectionString("WebApiDatabase"));
            options.UseInMemoryDatabase("MessagesDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Message
            modelBuilder.Entity<MessageDto>()
                .Property(b => b._Hdr).HasColumnName("Hdr");

            modelBuilder.Entity<MessageDto>()
                .Property(b => b._Request).HasColumnName("Request");

            // Payload
            modelBuilder.Entity<RequestDto>(
                eb =>
                {
                    eb.Property(b => b._NS_ArticleCreate).HasColumnName("NS_ArticleCreate");
                    eb.Property(b => b._NS_OrderCreate).HasColumnName("NS_OrderCreate");
                    eb.Property(b => b._NS_OrderUpdate).HasColumnName("NS_OrderUpdate");
                    eb.Property(b => b._NS_OrderCancel).HasColumnName("NS_OrderCancel");
                    eb.Property(b => b._NS_OrderLineCancel).HasColumnName("NS_OrderLineCancel");
                    eb.Property(b => b._NS_ValidationError).HasColumnName("NS_ValidationError");
                    eb.Property(b => b._GS_StockAdjustment).HasColumnName("GS_StockAdjustment");
                    eb.Property(b => b._GS_InventorySnapshot).HasColumnName("GS_InventorySnapshot");
                    eb.Property(b => b._GS_ToteAssignment).HasColumnName("GS_ToteAssignment");
                    eb.Property(b => b._GS_TrolleyComplete).HasColumnName("GS_TrolleyComplete");
                    eb.Property(b => b._GS_PickConfirmation).HasColumnName("GS_PickConfirmation");
                    eb.Property(b => b._GS_PickCancellation).HasColumnName("GS_PickCancellation");
                    eb.Property(b => b._GS_PickCancellationRequest).HasColumnName("GS_PickCancellationRequest");
                    eb.Property(b => b._GS_Activity).HasColumnName("GS_Activity");
                    eb.Property(b => b._GS_ValidationError).HasColumnName("GS_ValidationError");
                    eb.HasNoKey();
                });

            // List
            modelBuilder.Entity<NS_OrderCreateDto>(
                eb =>
                {
                    eb.Property(b => b._OrderLines).HasColumnName("OrderLines");
                    eb.HasNoKey();
                });

            modelBuilder.Entity<NS_OrderLineCancelDto>(
                eb =>
                {
                    eb.Property(b => b._OrderLineCancel).HasColumnName("OrderLineCancel");
                    eb.HasNoKey();
                });

            modelBuilder.Entity<GS_TrolleyCompleteDto>(
                eb =>
                {
                    eb.Property(b => b._Totes).HasColumnName("Totes");
                    eb.HasNoKey();
                });

            modelBuilder.Entity<GS_PickCancellationDto>(
                eb =>
                {
                    eb.Property(b => b._Cancellations).HasColumnName("Cancellations");
                    eb.HasNoKey();
                });

            modelBuilder.Entity<GS_PickCancellationRequestDto>(
                eb =>
                {
                    eb.Property(b => b._CancellationRequests).HasColumnName("CancellationRequests");
                    eb.HasNoKey();
                });

        }

        // Tables - Query DB instances of the resource
        //public DbSet<MessageDto> MessagesToErp { get; set; }
        public DbSet<QuantityCorrection> MessagesToErp { get; set; }
        //public DbSet<MessageDto> MessagesFromErp { get; set; }
        public DbSet<OrderLineDto> OrderLines { get; set; }
        public DbSet<OutgoingGoods> MessagesFromErp { get; set; } // will be ERP table
    }
}
