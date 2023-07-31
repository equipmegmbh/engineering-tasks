using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Model;

//  Extend model or restructure the entity
public class Product
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public int DisplayGroupId { get; set; }		

    public string? DisplayGroup { get; set; }

     public int? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryDisplayValue { get; set; }

    public string? ProductCategory { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? DetailDescription { get; set; }

    public string? ServiceDescription { get; set; }

    public string? ProductNumber { get; set; }

    public decimal? Price { get; set; }

    public decimal? OneTimePrice { get; set; }

    public int Runtime { get; set; }

    public int RuntimeExtension { get; set; }

    public bool Active { get; set; }

    public Guid CorrelationID { get; set; }

    public DateTime Created { get; set; }

    public bool SystemProduct { get; set; }

    public string? SystemProductEntity { get; set; }

    public bool ChangeNodeAllowed { get; set; }
}
