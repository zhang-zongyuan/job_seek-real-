﻿using job_seek.Shared.Domain;
using job_seek.Server.Data;
using job_seek.Server.IRepository;
using job_seek.Server.Models;
using job_seek.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace job_seek.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Company> _companys;
        private IGenericRepository<Description> _descriptions;
        private IGenericRepository<App> _apps;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Job> _jobs;
        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Make> Makes
            => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Company> Companys
            => _companys ??= new GenericRepository<Company>(_context);
        public IGenericRepository<Description> Descriptions
            => _descriptions ??= new GenericRepository<Description>(_context);
        public IGenericRepository<Job> Jobs
            => _jobs ??= new GenericRepository<Job>(_context);
        public IGenericRepository<App> Apps
            => _apps ??= new GenericRepository<App>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

        public IGenericRepository<Staff> Staffs 
            => _staffs ??= new GenericRepository<Staff>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}