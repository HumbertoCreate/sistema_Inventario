﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInventario.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaInventario.AccesoDatos.Configuracion
{
    public class BodegaConfiguracion : IEntityTypeConfiguration<Bodega>
    {
        public void Configure(EntityTypeBuilder<Bodega> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired();
        }
    }
}
