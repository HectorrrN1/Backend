﻿namespace CE.Chepeat.Domain.DTOs.User;
public class UserDto
{
    [Key]
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Fullname { get; set; }
}
