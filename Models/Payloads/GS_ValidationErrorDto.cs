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
        internal string _GS_ValidationError { get; set; }

        [NotMapped]
        [JsonProperty("GS_ValidationError")]
        public GS_ValidationErrorDto GS_ValidationError
        {
            get { return (this._GS_ValidationError == null) ? null : JsonConvert.DeserializeObject<GS_ValidationErrorDto>(this._GS_ValidationError); }
            set { _GS_ValidationError = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_ValidationErrorDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_ValidationErrorDto dto &&
				   OrderReference == dto.OrderReference;
		}
	}
}
