namespace JsonMessageApi.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Globalization;

	using Microsoft.EntityFrameworkCore;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    [Keyless]
    public partial class OrderLineDto
	{
		[JsonProperty("OrderLineNo")]
		public long OrderLineNo { get; set; }

		[JsonProperty("OrderLineReference")]
		public long OrderLineReference { get; set; }

		[JsonProperty("Sku")]
		public string Sku { get; set; }

		[JsonProperty("PriorityWithinBatch")]
		public long PriorityWithinBatch { get; set; }

		public override bool Equals(object obj)
		{
			return obj is OrderLineDto dto &&
				   OrderLineNo == dto.OrderLineNo &&
				   OrderLineReference == dto.OrderLineReference &&
				   Sku == dto.Sku &&
				   PriorityWithinBatch == dto.PriorityWithinBatch;
		}
	}
}
