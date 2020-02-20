using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Web_First.Models;

namespace Web_First.Data
{
    public partial class MvcSPContext : DbContext
    {
        public MvcSPContext()
        {
        }

        public MvcSPContext(DbContextOptions<MvcSPContext> options)
            : base(options)
        {
        }
        public virtual DbSet<san_pham_sale> San_Pham_Sale{ get; set; }
        public virtual DbSet<san_pham_new> San_Pham_New { get; set; }
        public virtual DbSet<View_Image> View_Image { get; set; }
        public virtual DbSet<ao> Ao { get; set; }
        public virtual DbSet<quan> quan { get; set; }
        public virtual DbSet<San_Pham> San_Pham { get; set; }
        //
        public virtual DbSet<PK> PK { get; set; }
        public virtual DbSet<Ao_Khoac> Ao_Khoac { get; set; }
        public virtual DbSet<Ao_Len> Ao_Len { get; set; }
        public virtual DbSet<Ao_Polo> Ao_Polo { get; set; }
        public virtual DbSet<Ao_HD> Ao_HD { get; set; }
        public virtual DbSet<Ao_SM> Ao_SM { get; set; }
        public virtual DbSet<Ao_ST> Ao_ST { get; set; }
        public virtual DbSet<Ao_Thun> Ao_Thun { get; set; }
        public virtual DbSet<Ao_TT> Ao_TT { get; set; }
        public virtual DbSet<BL_T> BL_T { get; set; }
        public virtual DbSet<Giay_dep> Giay_Dep { get; set; }
        public virtual DbSet<Non_Vo> Non_Vo { get; set; }
        public virtual DbSet<Quan_Jeans> Quan_Jeans { get; set; }
        public virtual DbSet<Quan_JJ> Quan_JJ { get; set; }
        public virtual DbSet<Quan_kaki> Quan_Kaki { get; set; }
        public virtual DbSet<Quan_Short> Quan_Short { get; set; }
        public virtual DbSet<Quan_Tay> Quan_Tay { get; set; }
        public virtual DbSet<That_Lung> That_Lung { get; set; }
    }

}



