using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQlCustomersManager.Models;

public class Invoice
{
    protected Invoice() { }

    public Invoice(string invoiceNumber, decimal grossValue, decimal netValue, DateTime invoiceDate, Guid customerId)
    {
        Id = Guid.NewGuid();
        InvoiceNumber = invoiceNumber;
        GrossValue = grossValue;
        NetValue = netValue;
        InvoiceDate = invoiceDate;
        CustomerId = customerId;
    }

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Invoice Number is required")]
    public string InvoiceNumber { get; set; }

    [Required(ErrorMessage = "Gross Value is required")]
    public decimal GrossValue { get; set; }

    [Required(ErrorMessage = "Net Value is required")]
    public decimal NetValue { get; set; }

    [Required(ErrorMessage = "Invoice Date is required")]
    public DateTime InvoiceDate { get; set; }

    [ForeignKey("CustomerId")]
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
