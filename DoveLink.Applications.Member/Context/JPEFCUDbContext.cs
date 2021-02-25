using DoveLink.Applications.Member.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DoveLink.Applications.Member.Context
{
    public class JPEFCUDbContext : DbContext
    {
        private IDbContextTransaction _currentTransaction;

        public JPEFCUDbContext(DbContextOptions<JPEFCUDbContext> options) : base(options)
        {
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ValidateCreatedAndUpdatedEntities();
            AddTimestamps();
            var updates = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            return updates;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.ValidateCreatedAndUpdatedEntities();
            AddTimestamps();
            var updates = await base.SaveChangesAsync(cancellationToken);
            return updates;
        }

        public virtual void BeginTransaction()
        {
            if (_currentTransaction != null) return;

            _currentTransaction = Database.BeginTransaction();
        }

        public virtual async Task CommitTransactionAsync()
        {
            try
            {
                await SaveChangesAsync();

                _currentTransaction?.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public virtual void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<CheckListItem>().Property(b => b.LeadTime).HasDefaultValue(1);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x =>
                x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.UtcNow;
                }
                ((BaseEntity)entity.Entity).DateModifed = DateTime.UtcNow;
            }
        }
    }
}
