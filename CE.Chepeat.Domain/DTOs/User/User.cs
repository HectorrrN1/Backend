﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Chepeat.Domain.DTOs.User;
public class User 
{
    [Key]
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Fullname { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsBuyer { get; set; }
    public bool IsSeller { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set;}
}
