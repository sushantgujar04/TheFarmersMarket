﻿namespace ECommerce.Core.Entities;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedDate { get; set; }

}