namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    /// 
	public partial class RequestDto
    {
        internal string _GS_InventorySnapshot { get; set; }

        [NotMapped]
        [JsonProperty("GS_InventorySnapshot")]
        public GS_InventorySnapshotDto GS_InventorySnapshot
        {
            get { return (this._GS_InventorySnapshot == null) ? null : JsonConvert.DeserializeObject<GS_InventorySnapshotDto>(this._GS_InventorySnapshot); }
            set { _GS_InventorySnapshot = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_InventorySnapshotDto
	{
		[JsonProperty("SKU")]
		public string Sku { get; set; }

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode { get; set; }

		[JsonProperty("Quantity")]
		public long Quantity { get; set; }

		[JsonProperty("LastInductDate")]
		public DateTime LastInductDate { get; set; }

		[JsonProperty("LastRetrievedDate")]
		public DateTime LastRetrievedDate { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_InventorySnapshotDto dto &&
				   Sku == dto.Sku &&
				   WarehouseCode == dto.WarehouseCode &&
				   Quantity == dto.Quantity &&
				   LastInductDate == dto.LastInductDate &&
				   LastRetrievedDate == dto.LastRetrievedDate;
		}
	}
}
