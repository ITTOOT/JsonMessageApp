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
        internal string _NS_ValidationError { get; set; }

        [NotMapped]
        [JsonProperty("NS_ValidationError")]
        public NS_ValidationErrorDto NS_ValidationError
        {
            get { return (this._NS_ValidationError == null) ? null : JsonConvert.DeserializeObject<NS_ValidationErrorDto>(this._NS_ValidationError); }
            set { _NS_ValidationError = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class NS_ValidationErrorDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		public override bool Equals(object obj)
		{
			return obj is NS_ValidationErrorDto dto &&
				   OrderReference == dto.OrderReference;
		}
	}
}
