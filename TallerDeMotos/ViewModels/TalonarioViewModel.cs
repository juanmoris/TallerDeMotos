﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TallerDeMotos.Models;
using TallerDeMotos.Models.ModelosDeDominio;

namespace TallerDeMotos.ViewModels
{
    public class TalonarioViewModel
    {
        public IEnumerable<ApplicationUser> Usuarios { get; set; }

        public int Id { get; set; }

        [Required]
        public int? Timbrado { get; set; }

        [Required]
        [StringLength(10)]
        public string Ruc { get; set; }

        [Required]
        [Display(Name = "Fecha de Inicio de Vigencia")]
        public DateTime? FechaInicioVigencia { get; set; }

        [Required]
        [Display(Name = "Fecha Fin de Vigencia")]
        public DateTime? FechaFinVigencia { get; set; }

        [Required]
        [Display(Name = "Número de Factura Inicial")]
        public int? NumeroFacturaInicial { get; set; }

        [Required]
        [Display(Name = "Número de Factura Final")]
        public int? NumeroFacturaFinal { get; set; }

        [Required]
        [Display(Name = "Número de Factura Actual")]
        public int? NumeroFacturaActual { get; set; }

        public bool EstaActivo { get; set; }

        [Required]
        [Display(Name = "Asignar Talonario a Usuario")]
        public string UsuarioId { get; set; }

        public string Titulo
        {
            get
            {
                return Id != 0 ? "Editar Talonario" : "Agregar Talonario";
            }
        }

        public TalonarioViewModel()
        {

        }

        public TalonarioViewModel(Talonario talonario)
        {
            Id = talonario.Id;
            Timbrado = talonario.Timbrado;
            Ruc = talonario.Ruc;
            FechaInicioVigencia = talonario.FechaInicioVigencia;
            FechaFinVigencia = talonario.FechaFinVigencia;
            NumeroFacturaInicial = talonario.NumeroFacturaInicial;
            NumeroFacturaFinal = talonario.NumeroFacturaFinal;
            NumeroFacturaActual = talonario.NumeroFacturaActual;
            EstaActivo = talonario.EstaActivo;
            UsuarioId = talonario.UsuarioId;
        }
    }
}