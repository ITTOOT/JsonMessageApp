﻿namespace JsonMessageApi.Models
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
    public partial class CancellationRequestsDto
	{
		[JsonProperty("OrderLineReference")]
		public long OrderLineReference { get; set; }

		[JsonProperty("OrderLineNo")]
		public long OrderLineNo { get; set; }

		public override bool Equals(object obj)
		{
			return obj is CancellationRequestsDto dto &&
				   OrderLineReference == dto.OrderLineReference &&
				   OrderLineNo == dto.OrderLineNo;
		}
	}
}
