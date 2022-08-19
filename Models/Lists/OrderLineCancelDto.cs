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
    public partial class OrderLineCancelDto
	{
        [JsonProperty("OrderLineNo")]
        public long OrderLineNo { get; set; }

        [JsonProperty("OrderLineReference")]
		public long OrderLineReference { get; set; }

        [JsonProperty("BatchReference")]
        public string BatchReference { get; set; }

        public override bool Equals(object obj)
		{
			return obj is OrderLineCancelDto dto &&
                OrderLineNo == dto.OrderLineNo &&
                OrderLineReference == dto.OrderLineReference;
		}
	}
}
