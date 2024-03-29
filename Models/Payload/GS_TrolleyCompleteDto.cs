﻿namespace JsonMessageApi.Models
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
        internal string _GS_TrolleyComplete { get; set; }

        [NotMapped]
        [JsonProperty("GS_TrolleyComplete")]
        public GS_TrolleyCompleteDto GS_TrolleyComplete
        {
            get { return (this._GS_TrolleyComplete == null) ? null : JsonConvert.DeserializeObject<GS_TrolleyCompleteDto>(this._GS_TrolleyComplete); }
            set { _GS_TrolleyComplete = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_TrolleyCompleteDto
	{
		[JsonProperty("TrolleyID")]
		public long TrolleyId { get; set; }

        internal string _Totes { get; set; }

        [NotMapped]
        [JsonProperty("Totes")]
        public List<ToteDto> Totes
        {
            get { return (this._Totes == null) ? null : JsonConvert.DeserializeObject<List<ToteDto>>(this._Totes); }
            set { _Totes = JsonConvert.SerializeObject(value); }
        }

        public override bool Equals(object obj)
		{
			return obj is GS_TrolleyCompleteDto dto &&
				   TrolleyId == dto.TrolleyId &&
				   Totes == dto.Totes;
		}
	}
}
