﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE.Chepeat.Domain.ValidationAttributes;

namespace CE.Chepeat.Domain.Aggregates.Seller;
public class SellerRequest
{
    public Guid Id { get; set; }


    [Required]
    [StringLength(120, ErrorMessage = "NombreTienda máximo 120 caracteres")]
    public string StoreName { get; set; }


    [StringLength(255, ErrorMessage = "Descripción máxima 255 caracteres")]
    public string Description { get; set; }
    
    
    [Required]
    [StringLength(120, ErrorMessage = "Calle máxima 120 caracteres")]
    public string Street { get; set; }
    
    
    [Required]
    [StringLength(6, ErrorMessage = "NúmeroExterior máximo 6 números")]
    public string ExtNumber { get; set; }
    
    
    [StringLength(6, ErrorMessage = "NúmeroInterior máximo 6 números")]
    public string IntNumber { get; set; }
    
    
    [Required]
    [StringLength(100, ErrorMessage = "Vecindario/Colonia máximo 100 caracteres")]
    public string Neighborhood { get; set; }
    
    
    [Required]
    [StringLength(100, ErrorMessage = "Ciudad máximo 100 caracteres")]
    public string City { get; set; }
    
    
    [Required]
    [StringLength(100, ErrorMessage = "Estado máximo 100 caracteres")]
    public string State { get; set; }
    
    
    [Required]
    [StringLength(10, ErrorMessage = "CodigoPostal máximo 10 números")]
    public string CP { get; set; }
    
    
    [StringLength(255, ErrorMessage = "DirecciónNotas máximo 255 caracteres")]
    public string AddressNotes { get; set; }
    
    
    [Required]
    public double Latitude { get; set; }
    
    
    [Required]
    public double Longitude { get; set; }
    
    
    [Required]
    [FechaNoAnteriorAtributo(ErrorMessage = "La fecha de creación no puede ser anterior a la actual")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    
    [Required]
    [FechaNoAnteriorAtributo(ErrorMessage = "La fecha de actualización no puede ser anterior a la actual")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    
    public Guid IdUser { get; set; } = Guid.Empty;
}
