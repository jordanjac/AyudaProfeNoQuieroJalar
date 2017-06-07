namespace PaqueteTuristico.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alimentacions",
                c => new
                    {
                        AlimentacionId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        PaqueteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlimentacionId)
                .ForeignKey("dbo.Paquetes", t => t.PaqueteId, cascadeDelete: true)
                .Index(t => t.PaqueteId);
            
            CreateTable(
                "dbo.CalificacionAlimentacions",
                c => new
                    {
                        CalificacionAlimentacionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AlimentacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CalificacionAlimentacionId)
                .ForeignKey("dbo.Alimentacions", t => t.AlimentacionId, cascadeDelete: true)
                .Index(t => t.AlimentacionId);
            
            CreateTable(
                "dbo.CategoriaRestaurants",
                c => new
                    {
                        CategoriaRestaurantId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AlimentacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaRestaurantId)
                .ForeignKey("dbo.Alimentacions", t => t.AlimentacionId, cascadeDelete: true)
                .Index(t => t.AlimentacionId);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AlimentacionId = c.Int(nullable: false),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("dbo.Alimentacions", t => t.AlimentacionId, cascadeDelete: true)
                .ForeignKey("dbo.Hospedajes", t => t.HospedajeId, cascadeDelete: true)
                .Index(t => t.AlimentacionId)
                .Index(t => t.HospedajeId);
            
            CreateTable(
                "dbo.Hospedajes",
                c => new
                    {
                        HospedajeId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        PaqueteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HospedajeId)
                .ForeignKey("dbo.Paquetes", t => t.PaqueteId, cascadeDelete:false)
                .Index(t => t.PaqueteId);
            
            CreateTable(
                "dbo.CalificacionHospedajes",
                c => new
                    {
                        CalificacionHospedajeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CalificacionHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.HospedajeId, cascadeDelete: true)
                .Index(t => t.HospedajeId);
            
            CreateTable(
                "dbo.CategoriaHospedajes",
                c => new
                    {
                        CategoriaHospedajeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.HospedajeId, cascadeDelete: true)
                .Index(t => t.HospedajeId);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        PaqueteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PaqueteId);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        TransporteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PlacaTransporte = c.String(),
                        PaqueteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransporteId)
                .ForeignKey("dbo.Paquetes", t => t.PaqueteId, cascadeDelete: true)
                .Index(t => t.PaqueteId);
            
            CreateTable(
                "dbo.EstadoTransportes",
                c => new
                    {
                        EstadoTransporteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TransporteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstadoTransporteId)
                .ForeignKey("dbo.Transportes", t => t.TransporteId, cascadeDelete: true)
                .Index(t => t.TransporteId);
            
            CreateTable(
                "dbo.MarcaTransportes",
                c => new
                    {
                        MarcaTransporteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TipoTransporteId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MarcaTransporteId)
                .ForeignKey("dbo.TipoTransportes", t => t.TipoTransporteId, cascadeDelete: true)
                .ForeignKey("dbo.Transportes", t => t.TransporteId, cascadeDelete: true)
                .Index(t => t.TipoTransporteId)
                .Index(t => t.TransporteId);
            
            CreateTable(
                "dbo.ModeloTransportes",
                c => new
                    {
                        ModeloTransporteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MarcaTransporteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModeloTransporteId)
                .ForeignKey("dbo.MarcaTransportes", t => t.MarcaTransporteId, cascadeDelete: true)
                .Index(t => t.MarcaTransporteId);
            
            CreateTable(
                "dbo.TipoTransportes",
                c => new
                    {
                        TipoTransporteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TransporteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTransporteId)
                .ForeignKey("dbo.Transportes", t => t.TransporteId, cascadeDelete: false)
                .Index(t => t.TransporteId);
            
            CreateTable(
                "dbo.CategoriaTransportes",
                c => new
                    {
                        CategoriaTransporteId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TipoTransporteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaTransporteId)
                .ForeignKey("dbo.TipoTransportes", t => t.TipoTransporteId, cascadeDelete: true)
                .Index(t => t.TipoTransporteId);
            
            CreateTable(
                "dbo.ServicioHospedajes",
                c => new
                    {
                        ServicioHospedajeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.HospedajeId, cascadeDelete: true)
                .Index(t => t.HospedajeId);
            
            CreateTable(
                "dbo.TipoHospedajes",
                c => new
                    {
                        TipoHospedajeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HospedajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoHospedajeId)
                .ForeignKey("dbo.Hospedajes", t => t.HospedajeId, cascadeDelete: true)
                .Index(t => t.HospedajeId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DireccionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UbigeoId)
                .ForeignKey("dbo.Direccions", t => t.DireccionId, cascadeDelete: true)
                .Index(t => t.DireccionId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UbigeoId = c.Int(nullable: false),
                        PronvinciaId = c.Int(nullable: false),
                        Provincia_ProvinciaId = c.Int(),
                    })
                .PrimaryKey(t => t.DepartamentoId)
                .ForeignKey("dbo.Provincias", t => t.Provincia_ProvinciaId)
                .ForeignKey("dbo.Ubigeos", t => t.UbigeoId, cascadeDelete: true)
                .Index(t => t.UbigeoId)
                .Index(t => t.Provincia_ProvinciaId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DistritoId = c.Int(nullable: false),
                        UbigeoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinciaId)
                .ForeignKey("dbo.Distritoes", t => t.DistritoId, cascadeDelete: true)
                .ForeignKey("dbo.Ubigeos", t => t.UbigeoId, cascadeDelete: true)
                .Index(t => t.DistritoId)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UbigeoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistritoId)
                .ForeignKey("dbo.Ubigeos", t => t.UbigeoId, cascadeDelete: false)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "dbo.TipoAlimentacions",
                c => new
                    {
                        TipoAlimentacionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AlimentacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoAlimentacionId)
                .ForeignKey("dbo.Alimentacions", t => t.AlimentacionId, cascadeDelete: true)
                .Index(t => t.AlimentacionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoAlimentacions", "AlimentacionId", "dbo.Alimentacions");
            DropForeignKey("dbo.Ubigeos", "DireccionId", "dbo.Direccions");
            DropForeignKey("dbo.Departamentoes", "UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Provincias", "UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Distritoes", "UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Provincias", "DistritoId", "dbo.Distritoes");
            DropForeignKey("dbo.Departamentoes", "Provincia_ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.TipoHospedajes", "HospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.ServicioHospedajes", "HospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.Transportes", "PaqueteId", "dbo.Paquetes");
            DropForeignKey("dbo.MarcaTransportes", "TransporteId", "dbo.Transportes");
            DropForeignKey("dbo.TipoTransportes", "TransporteId", "dbo.Transportes");
            DropForeignKey("dbo.MarcaTransportes", "TipoTransporteId", "dbo.TipoTransportes");
            DropForeignKey("dbo.CategoriaTransportes", "TipoTransporteId", "dbo.TipoTransportes");
            DropForeignKey("dbo.ModeloTransportes", "MarcaTransporteId", "dbo.MarcaTransportes");
            DropForeignKey("dbo.EstadoTransportes", "TransporteId", "dbo.Transportes");
            DropForeignKey("dbo.Hospedajes", "PaqueteId", "dbo.Paquetes");
            DropForeignKey("dbo.Alimentacions", "PaqueteId", "dbo.Paquetes");
            DropForeignKey("dbo.Direccions", "HospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.CategoriaHospedajes", "HospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.CalificacionHospedajes", "HospedajeId", "dbo.Hospedajes");
            DropForeignKey("dbo.Direccions", "AlimentacionId", "dbo.Alimentacions");
            DropForeignKey("dbo.CategoriaRestaurants", "AlimentacionId", "dbo.Alimentacions");
            DropForeignKey("dbo.CalificacionAlimentacions", "AlimentacionId", "dbo.Alimentacions");
            DropIndex("dbo.TipoAlimentacions", new[] { "AlimentacionId" });
            DropIndex("dbo.Distritoes", new[] { "UbigeoId" });
            DropIndex("dbo.Provincias", new[] { "UbigeoId" });
            DropIndex("dbo.Provincias", new[] { "DistritoId" });
            DropIndex("dbo.Departamentoes", new[] { "Provincia_ProvinciaId" });
            DropIndex("dbo.Departamentoes", new[] { "UbigeoId" });
            DropIndex("dbo.Ubigeos", new[] { "DireccionId" });
            DropIndex("dbo.TipoHospedajes", new[] { "HospedajeId" });
            DropIndex("dbo.ServicioHospedajes", new[] { "HospedajeId" });
            DropIndex("dbo.CategoriaTransportes", new[] { "TipoTransporteId" });
            DropIndex("dbo.TipoTransportes", new[] { "TransporteId" });
            DropIndex("dbo.ModeloTransportes", new[] { "MarcaTransporteId" });
            DropIndex("dbo.MarcaTransportes", new[] { "TransporteId" });
            DropIndex("dbo.MarcaTransportes", new[] { "TipoTransporteId" });
            DropIndex("dbo.EstadoTransportes", new[] { "TransporteId" });
            DropIndex("dbo.Transportes", new[] { "PaqueteId" });
            DropIndex("dbo.CategoriaHospedajes", new[] { "HospedajeId" });
            DropIndex("dbo.CalificacionHospedajes", new[] { "HospedajeId" });
            DropIndex("dbo.Hospedajes", new[] { "PaqueteId" });
            DropIndex("dbo.Direccions", new[] { "HospedajeId" });
            DropIndex("dbo.Direccions", new[] { "AlimentacionId" });
            DropIndex("dbo.CategoriaRestaurants", new[] { "AlimentacionId" });
            DropIndex("dbo.CalificacionAlimentacions", new[] { "AlimentacionId" });
            DropIndex("dbo.Alimentacions", new[] { "PaqueteId" });
            DropTable("dbo.TipoAlimentacions");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Provincias");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Ubigeos");
            DropTable("dbo.TipoHospedajes");
            DropTable("dbo.ServicioHospedajes");
            DropTable("dbo.CategoriaTransportes");
            DropTable("dbo.TipoTransportes");
            DropTable("dbo.ModeloTransportes");
            DropTable("dbo.MarcaTransportes");
            DropTable("dbo.EstadoTransportes");
            DropTable("dbo.Transportes");
            DropTable("dbo.Paquetes");
            DropTable("dbo.CategoriaHospedajes");
            DropTable("dbo.CalificacionHospedajes");
            DropTable("dbo.Hospedajes");
            DropTable("dbo.Direccions");
            DropTable("dbo.CategoriaRestaurants");
            DropTable("dbo.CalificacionAlimentacions");
            DropTable("dbo.Alimentacions");
        }
    }
}
