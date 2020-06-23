using System;
using Inventory.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inventory.DataAccess.SQL
{
    public partial class DeploymentsContext : DbContext
    {      

        public DeploymentsContext(DbContextOptions<DeploymentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblComputers> TblComputers { get; set; }
        public virtual DbSet<TblDellWarranty> TblDellWarranty { get; set; }
        public virtual DbSet<TblHdspace> TblHdspace { get; set; }
        public virtual DbSet<TblHdspaceScan> TblHdspaceScan { get; set; }
        public virtual DbSet<TblHpwarranty> TblHpwarranty { get; set; }
        public virtual DbSet<TblInventory> TblInventory { get; set; }
        public virtual DbSet<TblSoftware> TblSoftware { get; set; }
        public virtual DbSet<TblSoftwareScan> TblSoftwareScan { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }
        public virtual DbSet<VAsset2Area> VAsset2Area { get; set; }
        public virtual DbSet<VAsset2User> VAsset2User { get; set; }
        public virtual DbSet<VAssetWarranty> VAssetWarranty { get; set; }
        public virtual DbSet<VDiskSpace> VDiskSpace { get; set; }
        public virtual DbSet<VInventory2Ad> VInventory2Ad { get; set; }
        public virtual DbSet<VInventoryData> VInventoryData { get; set; }
        public virtual DbSet<VInventoryOs> VInventoryOs { get; set; }
        public virtual DbSet<VLowDiskSpace> VLowDiskSpace { get; set; }
        public virtual DbSet<VSoftware> VSoftware { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.10.10.50;Database=Deployments;UID=DBA;PWD=Welcome1;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblComputers>(entity =>
            {
                entity.HasKey(e => e.ComputerName);

                entity.ToTable("tblComputers");

                entity.Property(e => e.ComputerName).HasMaxLength(24);

                entity.Property(e => e.Adstatus).HasColumnName("ADStatus");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipv4address).HasMaxLength(20);

                entity.Property(e => e.LastLogonDate).HasColumnType("date");

                entity.Property(e => e.LastLogonTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Macaddress).HasColumnName("MACAddress");

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.Osarchitecture)
                    .HasColumnName("OSArchitecture")
                    .HasMaxLength(50);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.SerialNumber).HasMaxLength(150);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDellWarranty>(entity =>
            {
                entity.HasKey(e => e.AssetTag)
                    .HasName("PK_tblDellWarranty_1");

                entity.ToTable("tblDellWarranty");

                entity.Property(e => e.AssetTag).HasMaxLength(20);

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memory).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ModelFamily).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.Storage).HasMaxLength(50);

                entity.Property(e => e.WarrantyDaysLeft).HasComputedColumnSql("(case when datediff(day,getdate(),[WarrantyEndDate])>=(1) then datediff(day,getdate(),[WarrantyEndDate]) else (0) end)");

                entity.Property(e => e.WarrantyEndDate).HasColumnType("datetime");

                entity.Property(e => e.WarrantyMonthsLeft).HasComputedColumnSql("(case when datediff(month,getdate(),[WarrantyEndDate])>=(1) then datediff(month,getdate(),[WarrantyEndDate]) else (0) end)");

                entity.Property(e => e.WarrantyStartDate).HasColumnType("datetime");

                entity.Property(e => e.WarrantyStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when datediff(day,getdate(),[WarrantyEndDate])<=(30) AND datediff(day,getdate(),[WarrantyEndDate])>(1) then 'WARNING' when datediff(day,getdate(),[WarrantyEndDate])>(30) then 'VALID' else 'EXPIRED' end)");

                entity.Property(e => e.WarrantyYearsLeft).HasComputedColumnSql("(case when datediff(year,getdate(),[WarrantyEndDate])>=(1) then datediff(year,getdate(),[WarrantyEndDate]) else (0) end)");
            });

            modelBuilder.Entity<TblHdspace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblHDSpace");

                entity.Property(e => e.Caption).HasMaxLength(50);

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Drive).HasMaxLength(30);

                entity.Property(e => e.FileSystem).HasMaxLength(30);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.SerialNumber).HasMaxLength(30);
            });

            modelBuilder.Entity<TblHdspaceScan>(entity =>
            {
                entity.HasKey(e => e.ComputerName);

                entity.ToTable("tblHDSpaceScan");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.Scanned).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblHpwarranty>(entity =>
            {
                entity.HasKey(e => e.AssetTag)
                    .HasName("PK_tblHPWarranty_1");

                entity.ToTable("tblHPWarranty");

                entity.Property(e => e.AssetTag).HasMaxLength(20);

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Memory).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ModelFamily).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.Storage).HasMaxLength(50);

                entity.Property(e => e.WarrantyDaysLeft).HasComputedColumnSql("(case when datediff(day,getdate(),[WarrantyEndDate])>=(1) then datediff(day,getdate(),[WarrantyEndDate]) else (0) end)");

                entity.Property(e => e.WarrantyEndDate).HasColumnType("date");

                entity.Property(e => e.WarrantyMonthsLeft).HasComputedColumnSql("(case when datediff(month,getdate(),[WarrantyEndDate])>=(1) then datediff(month,getdate(),[WarrantyEndDate]) else (0) end)");

                entity.Property(e => e.WarrantyStartDate).HasColumnType("date");

                entity.Property(e => e.WarrantyStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when datediff(day,getdate(),[WarrantyEndDate])<=(30) AND datediff(day,getdate(),[WarrantyEndDate])>(1) then 'WARNING' when datediff(day,getdate(),[WarrantyEndDate])>(30) then 'VALID' else 'EXPIRED' end)");

                entity.Property(e => e.WarrantyYearsLeft).HasComputedColumnSql("(case when datediff(year,getdate(),[WarrantyEndDate])>=(1) then datediff(year,getdate(),[WarrantyEndDate]) else (0) end)");
            });

            modelBuilder.Entity<TblInventory>(entity =>
            {
                entity.HasKey(e => e.ComputerName);

                entity.ToTable("tblInventory");

                entity.Property(e => e.ComputerName).HasMaxLength(24);

                entity.Property(e => e.ChassisType).HasMaxLength(120);

                entity.Property(e => e.Dhcpserver)
                    .HasColumnName("DHCPServer")
                    .HasMaxLength(20);

                entity.Property(e => e.DiskSizeGb).HasColumnName("DiskSize_GB");

                entity.Property(e => e.Dnsserver).HasColumnName("DNSServer");

                entity.Property(e => e.Domain).HasMaxLength(24);

                entity.Property(e => e.DomainMember).HasMaxLength(10);

                entity.Property(e => e.FirmwareVersion)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastBootUpTime).HasColumnType("date");

                entity.Property(e => e.LastUpdated).HasColumnType("date");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Macaddress).HasColumnName("MACAddress");

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.Osarchitecture)
                    .HasColumnName("OSArchitecture")
                    .HasMaxLength(50);

                entity.Property(e => e.Osbuild).HasColumnName("OSBuild");

                entity.Property(e => e.OsinstallDate)
                    .HasColumnName("OSInstallDate")
                    .HasColumnType("date");

                entity.Property(e => e.Osversion)
                    .HasColumnName("OSVersion")
                    .HasMaxLength(10);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RamMb).HasColumnName("RAM_MB");

                entity.Property(e => e.RemoteDesktop).HasMaxLength(20);

                entity.Property(e => e.SerialNumber).HasMaxLength(150);

                entity.Property(e => e.Spversion).HasColumnName("SPVersion");

                entity.Property(e => e.SystemType).HasMaxLength(50);

                entity.Property(e => e.TimeZone).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSoftware>(entity =>
            {
                entity.ToTable("tblSoftware");

                entity.Property(e => e.ComputerName).HasMaxLength(24);

                entity.Property(e => e.InstallDate).HasColumnType("date");

                entity.Property(e => e.Program).HasMaxLength(255);

                entity.Property(e => e.Publisher).HasMaxLength(100);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.RegistryKey)
                    .HasMaxLength(120)
                    .IsFixedLength();

                entity.Property(e => e.Version).HasMaxLength(20);
            });

            modelBuilder.Entity<TblSoftwareScan>(entity =>
            {
                entity.HasKey(e => e.ComputerName);

                entity.ToTable("tblSoftwareScan");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.ToTable("tblUsers");

                entity.Property(e => e.Adstatus).HasColumnName("ADStatus");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Geid).HasColumnName("GEID");

                entity.Property(e => e.LastLogonDate).HasColumnType("date");

                entity.Property(e => e.LastLogonTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<VAsset2Area>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAsset2Area");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Geid).HasColumnName("GEID");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.SerialNumber).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VAsset2User>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAsset2User");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Geid).HasColumnName("GEID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VAssetWarranty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAssetWarranty");

                entity.Property(e => e.AssetTag)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Memory).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ModelFamily).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.Storage).HasMaxLength(50);

                entity.Property(e => e.ValidationDate).HasColumnType("date");

                entity.Property(e => e.WarrantyEndDate).HasColumnType("datetime");

                entity.Property(e => e.WarrantyStartDate).HasColumnType("datetime");

                entity.Property(e => e.WarrantyStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDiskSpace>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDiskSpace");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Drive).HasMaxLength(30);

                entity.Property(e => e.Ipv4address).HasMaxLength(20);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<VInventory2Ad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventory2AD");

                entity.Property(e => e.AdlastLogon)
                    .HasColumnName("ADLastLogon")
                    .HasColumnType("date");

                entity.Property(e => e.ChassisType).HasMaxLength(120);

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.Dhcpserver)
                    .HasColumnName("DHCPServer")
                    .HasMaxLength(20);

                entity.Property(e => e.DiskSizeGb).HasColumnName("DiskSize_GB");

                entity.Property(e => e.Dnsserver).HasColumnName("DNSServer");

                entity.Property(e => e.Domain).HasMaxLength(24);

                entity.Property(e => e.DomainMember).HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastBootUpTime).HasColumnType("date");

                entity.Property(e => e.LastUpdated).HasColumnType("date");

                entity.Property(e => e.Macaddress).HasColumnName("MACAddress");

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.Osarchitecture)
                    .HasColumnName("OSArchitecture")
                    .HasMaxLength(50);

                entity.Property(e => e.Osbuild).HasColumnName("OSBuild");

                entity.Property(e => e.OsinstallDate)
                    .HasColumnName("OSInstallDate")
                    .HasColumnType("date");

                entity.Property(e => e.Osversion)
                    .HasColumnName("OSVersion")
                    .HasMaxLength(10);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.RamMb).HasColumnName("RAM_MB");

                entity.Property(e => e.RemoteDesktop).HasMaxLength(20);

                entity.Property(e => e.SerialNumber).HasMaxLength(150);

                entity.Property(e => e.Spversion).HasColumnName("SPVersion");

                entity.Property(e => e.SystemType).HasMaxLength(50);

                entity.Property(e => e.TimeZone).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VInventoryData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventoryData");

                entity.Property(e => e.ComputerName).HasMaxLength(24);

                entity.Property(e => e.Dhcpserver)
                    .HasColumnName("DHCPServer")
                    .HasMaxLength(20);

                entity.Property(e => e.DiskSizeGb).HasColumnName("DiskSize_GB");

                entity.Property(e => e.Dnsserver)
                    .HasColumnName("DNSServer")
                    .HasMaxLength(20);

                entity.Property(e => e.Domain).HasMaxLength(24);

                entity.Property(e => e.DomainMember).HasMaxLength(10);

                entity.Property(e => e.Ipv4address).HasMaxLength(20);

                entity.Property(e => e.LastBootUpTime).HasColumnType("date");

                entity.Property(e => e.LastLogonDate).HasColumnType("date");

                entity.Property(e => e.LastLogonTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Macaddress).HasColumnName("MACAddress");

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.Osarchitecture)
                    .HasColumnName("OSArchitecture")
                    .HasMaxLength(50);

                entity.Property(e => e.Osbuild).HasColumnName("OSBuild");

                entity.Property(e => e.Osversion)
                    .HasColumnName("OSVersion")
                    .HasMaxLength(10);

                entity.Property(e => e.RamMb).HasColumnName("RAM_MB");

                entity.Property(e => e.SerialNumber).HasMaxLength(150);

                entity.Property(e => e.Spversion).HasColumnName("SPVersion");

                entity.Property(e => e.SystemType).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<VInventoryOs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventoryOS");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(100);

                entity.Property(e => e.Osbuild).HasColumnName("OSBuild");

                entity.Property(e => e.Osversion)
                    .HasColumnName("OSVersion")
                    .HasMaxLength(10);

                entity.Property(e => e.Spversion).HasColumnName("SPVersion");
            });

            modelBuilder.Entity<VLowDiskSpace>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLowDiskSpace");

                entity.Property(e => e.ComputerName).HasMaxLength(50);

                entity.Property(e => e.Drive).HasMaxLength(30);

                entity.Property(e => e.Ipv4address).HasMaxLength(20);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<VSoftware>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSoftware");

                entity.Property(e => e.ComputerName).HasMaxLength(24);

                entity.Property(e => e.InstallDate).HasColumnType("date");

                entity.Property(e => e.Program).HasMaxLength(255);

                entity.Property(e => e.Publisher).HasMaxLength(100);

                entity.Property(e => e.Qdate)
                    .HasColumnName("QDate")
                    .HasColumnType("date");

                entity.Property(e => e.RegistryKey)
                    .HasMaxLength(120)
                    .IsFixedLength();

                entity.Property(e => e.Version).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
