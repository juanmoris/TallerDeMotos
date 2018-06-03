﻿namespace TallerDeMotos.Dtos
{
    public class PresupuestoDetalleDto
    {
        public int Id { get; set; }

        public int PresupuestoId { get; set; }

        public int ProductoId { get; set; }

        public byte Cantidad { get; set; }

        public int Total { get; set; }

        public int TotalLineaExenta { get; set; }

        public int TotalLineaCincoXCiento { get; set; }

        public int TotalLineaDiezXCiento { get; set; }
    }
}