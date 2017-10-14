﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using TallerDeMotos.Models.ModelosDeDominio;

namespace TallerDeMotos.ConfiguracionDeEntidades
{
    public class OrdenCompraConfiguracion : EntityTypeConfiguration<OrdenCompra>
    {
        public OrdenCompraConfiguracion()
        {
            ToTable("OrdenCompras");

            Property(oc => oc.Id)
                .HasColumnName("Codigo");

            Property(oc => oc.OrdenCompraNumero)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_OrdenCompraNumero", 1) { IsUnique = true }));

            Property(oc => oc.FormaPagoId)
                .HasColumnName("FormaPagoCodigo");

            Property(oc => oc.EstadoId)
                .HasColumnName("EstadoCodigo");

            Property(oc => oc.ProveedorId)
                .HasColumnName("ProveedorCodigo")
                .HasColumnOrder(3);

            HasRequired(oc => oc.FormaPago)
                .WithMany(fp => fp.OrdenCompras)
                .WillCascadeOnDelete(false);

            HasRequired(oc => oc.Estado)
                .WithMany(e => e.OrdenCompras)
                .WillCascadeOnDelete(false);

            HasRequired(oc => oc.Proveedor)
                .WithMany(e => e.OrdenCompras)
                .WillCascadeOnDelete(false);
        }
    }
}