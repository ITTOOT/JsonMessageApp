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
        internal string _GS_PickConfirmation { get; set; }

        [NotMapped]
        [JsonProperty("GS_PickConfirmation")]
        public GS_PickConfirmationDto GS_PickConfirmation
        {
            get { return (this._GS_PickConfirmation == null) ? null : JsonConvert.DeserializeObject<GS_PickConfirmationDto>(this._GS_PickConfirmation); }
            set { _GS_PickConfirmation = JsonConvert.SerializeObject(value); }
        }
    }

    [Keyless]
    public partial class GS_PickConfirmationDto
	{
		[JsonProperty("OrderReference")]
		public Guid OrderReference { get; set; }

		[JsonProperty("OrderLineNo")]
		public long OrderLineNo { get; set; }

		[JsonProperty("OrderLineReference")]
		public long OrderLineReference { get; set; }

		[JsonProperty("ToteID")]
		public long ToteId { get; set; }

		[JsonProperty("PickedUPOS")]
		public string PickedUpos { get; set; }

        [JsonProperty("Qty")]
        public string Qty { get; set; }

        [JsonProperty("BonusNo")]
		public string BonusNo { get; set; }

		[JsonProperty("PickTime")]
		public DateTime PickTime { get; set; }

		public override bool Equals(object obj)
		{
			return obj is GS_PickConfirmationDto dto &&
				   OrderReference == dto.OrderReference &&
				   OrderLineNo == dto.OrderLineNo &&
				   OrderLineReference == dto.OrderLineReference &&
				   ToteId == dto.ToteId &&
				   PickedUpos == dto.PickedUpos &&
                   Qty == dto.Qty &&
                   BonusNo == dto.BonusNo &&
				   PickTime == dto.PickTime;
		}
	}
}
