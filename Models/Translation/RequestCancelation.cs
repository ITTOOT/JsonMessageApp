namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class RequestCancelation : HostMessage // , IRequestCancelation
    {
        public static Func<IHostMessage, bool> OnHandle;

        public override bool Handle()
        {
            if (OnHandle == null)
            {
                throw new NotImplementedException($"{nameof(OnHandle)} was not set in Class {nameof(OrderStart)}");
            }
            else
            {
                return OnHandle.Invoke(this);
            }
        }

        /// <summary>
        /// BatchId 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string BatchId { get; set; }

		/// <summary>
		/// OutgoingGoodsNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string OutgoingGoodsNo { get; set; }

		/// <summary>
		/// PositionNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string PositionNo { get; set; }

	}
}