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
        internal string _GS_StockAdjustment { get; set; }

        [NotMapped]
        [JsonProperty("GS_StockAdjustment")]
        public GS_StockAdjustmentDto GS_StockAdjustment
        {
            get { return (this._GS_StockAdjustment == null) ? null : JsonConvert.DeserializeObject<GS_StockAdjustmentDto>(this._GS_StockAdjustment); }
            set { _GS_StockAdjustment = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_StockAdjustmentDto
	{
		[JsonProperty("SKU")]
		public string Sku { get; set; }

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode { get; set; }

		[JsonProperty("Quantity")]
		public long Quantity { get; set; }

		[JsonProperty("adjustmentDate")]
		public DateTime AdjustmentDate { get; set; }

		[JsonProperty("BDCID")]
		public string Bdcid { get; set; }

		[JsonProperty("UPOS")]
		public object Upos { get; set; }

		[JsonProperty("AdjustmentReason")]
		public long AdjustmentReason { get; set; }

		[JsonProperty("BonusNo")]
		public string BonusNo { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_StockAdjustmentDto dto &&
				   Sku == dto.Sku &&
				   WarehouseCode == dto.WarehouseCode &&
				   Quantity == dto.Quantity &&
				   AdjustmentDate == dto.AdjustmentDate &&
				   Bdcid == dto.Bdcid &&
				   Upos == dto.Upos &&
				   AdjustmentReason == dto.AdjustmentReason &&
				   BonusNo == dto.BonusNo;
		}
	}
}
