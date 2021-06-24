using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class VeiculoViewModel
    {
        [HiddenInput]
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório!")]
        public double Quilometragem { get; set; }
    }
}
