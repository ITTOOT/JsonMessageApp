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
        internal string _NS_OrderCreate { get; set; }

		[NotMapped]
		[JsonProperty("NS_OrderCreate")]
		public NS_OrderCreateDto NS_OrderCreate
		{
			get { return (this._NS_OrderCreate == null) ? null : JsonConvert.DeserializeObject<NS_OrderCreateDto>(this._NS_OrderCreate); }
			set { _NS_OrderCreate = JsonConvert.SerializeObject(value); }
		}

		//[NotMapped]
		//[JsonProperty("NS_OrderCreate")]
		//public NS_OrderCreateDto NS_OrderCreate { get; set; }
	}

    [Keyless]
    public partial class NS_OrderCreateDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }
        
        [JsonProperty("BatchReference")]
		public long BatchReference { get; set; }

		[JsonProperty("Destination")]
		public long Destination { get; set; }

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode { get; set; }

		[JsonProperty("PickByTime")]
		public DateTime PickByTime { get; set; }
        
        [JsonProperty("BatchDescription")]
		public string BatchDescription { get; set; }

		[JsonProperty("BatchEndAllowed")]
		public string BatchEndAllowed { get; set; }

        [JsonProperty("BatchPriority")]
        public string BatchPriority { get; set; } // Added

        internal string _OrderLines { get; set; }

		[NotMapped]
		[JsonProperty("OrderLines")]
		public List<OrderLineDto> OrderLines
		{
			get { return (this._OrderLines == null) ? null : JsonConvert.DeserializeObject<List<OrderLineDto>>(this._OrderLines); }
			set { _OrderLines = JsonConvert.SerializeObject(value); }
		}

		// Equality
		public override bool Equals(object obj)
		{
			return obj is NS_OrderCreateDto dto &&
				   OrderReference == dto.OrderReference &&
				   BatchReference == dto.BatchReference &&
				   WarehouseCode == dto.WarehouseCode &&
				   PickByTime == dto.PickByTime &&
				   BatchDescription == dto.BatchDescription &&
				   BatchEndAllowed == dto.BatchEndAllowed &&
				   OrderLines == dto.OrderLines;
		}
	}
}
