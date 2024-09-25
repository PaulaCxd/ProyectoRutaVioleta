
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DbRutaVioleta: DbContext
    {
        public DbSet<ActivacionInterna> ActivacionInterna { get; set; }
        public DbSet<Autenticacion> Autenticacion { get; set; }
        public DbSet<RutaVioleta> RutaVioletas { get; set; }
        public DbSet<RemisionEspecialistas> RemisionEspecialistas { get; set; }
        public DbSet<DatosGenerales> DatosGenerales { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<IdentidadGenero> IdentidadGeneros { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Orientacion> OrientacionSexual { get; set; }
        public DbSet<Sede> Sedes { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }

        

        public DbSet<Vinculo> Vinculo { get; set; }
        
        public DbSet<ViolenciaEconomica> ViolenciaEconomicas { get; set; }
        public DbSet<ViolenciaFisica> ViolenciaFisicas { get; set; }
        public DbSet<ViolenciaInstitucional> ViolenciaInstitucional { get; set; }
        public DbSet<ViolenciaPrejuicio> ViolenciaPrejuicios { get; set; }
        public DbSet<ViolenciaPsicologica> ViolenciaPsicologicas { get; set; }
        public DbSet<ViolenciaSexual> ViolenciaSexuales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["RutaVioletas"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TipoDocumento>()
               .HasMany(e => e.DatosGenerales)
               .WithOne(e => e.TiposDocumento)
               .HasForeignKey(e => e.IdTipoDocumento);

            builder.Entity<Municipio>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.Municipio)
                .HasForeignKey(e => e.IdMunicipio);

            builder.Entity<Sexo>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo);

            builder.Entity<Orientacion>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.Orientacion)
                .HasForeignKey(e => e.IdOrientacion);

            builder.Entity<IdentidadGenero>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.IdentidadGenero)
                .HasForeignKey(e => e.IdIdentidadGenero);

            builder.Entity<Sede>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.Sede)
                .HasForeignKey(e => e.IdSede);

            builder.Entity<Facultad>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.Facultad)
                .HasForeignKey(e => e.IdFacultad);

            builder.Entity<TipoDocumento>()
                .HasMany(e => e.DatosGenerales)
                .WithOne(e => e.TiposDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            builder.Entity<Departamento>()
                .HasMany(e => e.Municipio)
                .WithOne(e => e.Departamento)
                .HasForeignKey(e => e.IdDepartamento);


            builder.Entity<Vinculo>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.Vinculo)
                .HasForeignKey(e => e.IdVinculo);

            builder.Entity<ViolenciaPsicologica>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ViolenciaPsicologica)
                .HasForeignKey(e => e.IdViolenciaPsicologica);



            builder.Entity<ViolenciaFisica>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ViolenciaFisica)
                .HasForeignKey(e => e.IdViolenciaFisica);

            builder.Entity<ViolenciaEconomica>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ViolenciaEconomica)
                .HasForeignKey(e => e.IdViolenciaEconomica);

            builder.Entity<ViolenciaSexual>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ViolenciaSexual)
                .HasForeignKey(e => e.IdViolenciaSexual);

            builder.Entity<ViolenciaPrejuicio>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ViolenciaPrejuicio)
                .HasForeignKey(e => e.IdViolenciaPrejuicio);

            builder.Entity<ViolenciaInstitucional>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ViolenciaInstitucional)
                .HasForeignKey(e => e.IdViolenciaInstitucional);

            builder.Entity<ActivacionInterna>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.ActivacionInterna)
                .HasForeignKey(e => e.IdActivacionInterna);

            builder.Entity<RemisionEspecialistas>()
                .HasMany(e => e.RutaVioleta)
                .WithOne(e => e.RemisionEspecialistas)
                .HasForeignKey(e => e.IdRemisionEspecialistas);
        }
    }
}
