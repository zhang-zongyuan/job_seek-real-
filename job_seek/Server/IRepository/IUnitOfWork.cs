using job_seek.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Company> Companys { get; }
        IGenericRepository<Job> Jobs { get; }
        IGenericRepository<Description> Descriptions { get; }
        IGenericRepository<App> Apps { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}