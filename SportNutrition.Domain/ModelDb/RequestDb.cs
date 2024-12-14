﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SportNutrition.Domain.ModelDb;

[Table("request")]
public class RequestDb
{
    [Column("id")]
    public Guid Id { get; set; }

    [Column("idUser")]
    public Guid UserId { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("status")]
    public int Status { get; set; }

    [Column("createdAt", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
}
