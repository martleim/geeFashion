//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeeFashion.Model
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations;
    
    [DataContract]
    public partial class Item
    {
        
    	[Key()]
    	[DataMember(Name = "Id")]
    	public int Id { get; set; }
        
    	[Required(ErrorMessage = "ProductId is required.")]
    	[DataMember(Name = "ProductId", IsRequired = true)]
    	public int ProductId { get; set; }
        
    	[Required(ErrorMessage = "WarehouseId is required.")]
    	[DataMember(Name = "WarehouseId", IsRequired = true)]
    	public int WarehouseId { get; set; }
        
    	[Required(ErrorMessage = "Size is required.")]
    	[DataMember(Name = "Size", IsRequired = true)]
    	public int Size { get; set; }
        
    	[StringLength(50, ErrorMessage = "Color has a maximum length of 50.")]
    	[Required(ErrorMessage = "Color is required.")]
    	[DataMember(Name = "Color", IsRequired = true)]
    	public string Color { get; set; }
        
    	[DataMember(Name = "Status")]
    	public Nullable<int> Status { get; set; }
    
        [DataMember(Name = "Product")]
    	public virtual Product Product { get; set; }
        [DataMember(Name = "Warehouse")]
    	public virtual Warehouse Warehouse { get; set; }
    }
}
