using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWeb.API.Models;

namespace ProjectWeb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Construtor do DataContext.
        }
        public DbSet<Evento> Eventos { get; set; }//Mapeamento de uma class para se tornar um BD.
    }
}