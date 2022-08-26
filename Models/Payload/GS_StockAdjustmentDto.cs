using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

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

        //[NotMapped]
        //[JsonProperty("GS_StockAdjustment")]
        //public GS_StockAdjustmentDto GS_StockAdjustment
        //{

        //    get { return (this._GS_StockAdjustment == null) ? null : JsonConvert.DeserializeObject<GS_StockAdjustmentDto>(this.GS_StockAdjustment, OrderCreateConverter.Settings); }
        //    set { _GS_StockAdjustment = JsonConvert.SerializeObject(value).ToString(); }
        //}

        [NotMapped]
        [JsonProperty("GS_StockAdjustment")]
        public GS_StockAdjustmentDto GS_StockAdjustment { get; set; }
    }

    [Keyless]
    public partial class GS_StockAdjustmentDto
	{
		[JsonProperty("SKU")]
		public string Sku { get; set; }

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode { get; set; }

		[JsonProperty("Quantity")]
		public long? Quantity { get; set; }

		[JsonProperty("adjustmentDate")]
		public DateTime? AdjustmentDate { get; set; }

		[JsonProperty("BDCID")]
		public string Bdcid { get; set; }

		[JsonProperty("UPOS")]
		public string Upos { get; set; }

		[JsonProperty("AdjustmentReason")]
		public long? AdjustmentReason { get; set; }

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





// JSON settings
internal static class OrderCreateConverter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
}


