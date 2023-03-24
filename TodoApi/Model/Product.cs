using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Model;

public class Product
{
    [Column("PK_RecordID")]
    public int Id { get; set; }

    [Column("FK_Supplier")]
    public int SupplierId { get; set; }

    [Column("SupplierName")]
    public string? SupplierName { get; set; }

    [Column("FK_DisplayGroup")]
    public int DisplayGroupId { get; set; }		

    [Column("DisplayGroup")]
    public string? DisplayGroup { get; set; }

    [Column("FK_Category")]
    public int? CategoryId { get; set; }

    [Column("CategoryName")]
    public string? CategoryName { get; set; }

    [Column("CategoryDisplayValue")]
    public string? CategoryDisplayValue { get; set; }

    [Column("ProductCategory")]
    public string? ProductCategory { get; set; }

    [Column("DisplayRank")]
    public int? DisplayRank { get; set; }

    [Column("Name")]
    public string? Name { get; set; }

    [Column("Description")]
    public string? Description { get; set; }

    [Column("DetailDescription")]
    public string? DetailDescription { get; set; }

    [Column("ServiceDescription")]
    public string? ServiceDescription { get; set; }

    [Column("ProductNumber")]
    public string? ProductNumber { get; set; }

    [Column("Price")]
    public decimal? Price { get; set; }

    [Column("OneTimePrice")]
    public decimal? OneTimePrice { get; set; }

    [Column("Runtime")]
    public int Runtime { get; set; }

    [Column("RuntimeExtension")]
    public int RuntimeExtension { get; set; }

    [Column("Active")]
    public bool Active { get; set; }

    [Column("CorrelationID")]
    public Guid CorrelationID { get; set; }

    [Column("Created")]
    public DateTime Created { get; set; }

    [Column("SystemProduct")]
    public bool SystemProduct { get; set; }

    [Column("SystemProductEntity")]
    public string? SystemProductEntity { get; set; }

    [Column("ChangeNodeAllowed")]
    public bool ChangeNodeAllowed { get; set; }
}
