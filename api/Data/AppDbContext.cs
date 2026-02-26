using System;
using Microsoft.EntityFrameworkCore;
using api.Data.Models;
using Microsoft.Extensions.Configuration;
namespace API.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}