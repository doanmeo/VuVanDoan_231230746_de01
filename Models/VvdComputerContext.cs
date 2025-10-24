using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuVanDoan_231230746_de01.Models
{
    public class VvdComputerContext : DbContext
    {
        public VvdComputerContext(DbContextOptions<VvdComputerContext> options)
            : base(options)
        {
        }

        // Khai báo bảng HvtComputer mà DbContext sẽ quản lý
        public DbSet<VvdComputer> VvdComputer { get; set; }
    }
}
