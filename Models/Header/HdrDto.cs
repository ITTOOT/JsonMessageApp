namespace JsonMessageApi.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Globalization;

	using Microsoft.EntityFrameworkCore;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	/// <summary>
	/// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
	/// </summary>
	///
	[Keyless]
	public partial class HdrDto
	{
        [JsonProperty("messageType")]
		public string MessageType { get; set; }

		[JsonProperty("messageVersion")]
		public string MessageVersion { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("uniqueKey")]
		public Guid UniqueKey { get; set; }

		[JsonProperty("senderID")]
		public string SenderId { get; set; }

		[JsonProperty("destinationID")]
		public string DestinationId { get; set; }

		[JsonProperty("resendCounter")]
		public long ResendCounter { get; set; }


		public override bool Equals(object obj)
		{
			return obj is HdrDto dto &&
				   MessageType == dto.MessageType &&
				   MessageVersion == dto.MessageVersion &&
				   Created == dto.Created &&
				   UniqueKey == dto.UniqueKey &&
				   SenderId == dto.SenderId &&
				   DestinationId == dto.DestinationId &&
				   ResendCounter == dto.ResendCounter;
		}
	}
}
