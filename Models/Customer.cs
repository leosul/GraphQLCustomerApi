﻿using System.ComponentModel.DataAnnotations;

namespace GraphQlCustomersManager.Models;

public class Customer
{
    protected Customer() { }

    public Customer(string name, bool isActive)
    {
        Id = Guid.NewGuid();
        Name = name;
        IsActive = isActive;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public void AddInvoice(ICollection<Invoice> invoices) => Invoices = invoices;

    [Key]
    public Guid Id { get; private set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    /*EF Relation*/
    public ICollection<Invoice> Invoices { get; private set; }
}
