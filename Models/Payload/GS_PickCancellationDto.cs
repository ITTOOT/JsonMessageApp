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
        internal string _GS_PickCancellation { get; set; }

        [NotMapped]
        [JsonProperty("GS_PickCancellation")]
        public GS_PickCancellationDto GS_PickCancellation
        {
            get { return (this._GS_PickCancellation == null) ? null : JsonConvert.DeserializeObject<GS_PickCancellationDto>(this._GS_PickCancellation); }
            set { _GS_PickCancellation = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_PickCancellationDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		[JsonProperty("BonusNo")]
		public string BonusNo { get; set; }

		[JsonProperty("ReasonCode")]
		public long ReasonCode { get; set; }
        
        internal string _Cancellations { get; set; }

        [NotMapped]
        [JsonProperty("Cancellations")]
        public List<CancellationDto> Cancellations
        {
            get { return (this._Cancellations == null) ? null : JsonConvert.DeserializeObject<List<CancellationDto>>(this._Cancellations); }
            set { _Cancellations = JsonConvert.SerializeObject(value); }
        }

        public override bool Equals(object obj)
		{
			return obj is GS_PickCancellationDto dto &&
				   OrderReference == dto.OrderReference &&
				   BonusNo == dto.BonusNo &&
				   ReasonCode == dto.ReasonCode &&
				   Cancellations == dto.Cancellations;
		}
	}
}
