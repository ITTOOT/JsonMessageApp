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
	public partial class SystemActivity : HostMessage // , IPickCancelation
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
		/// OutgoingGoodsNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string UserActivity { get; set; }

		/// <summary>
		/// ReasonCode 
		/// </summary>
		[XmlAttribute]
        [JsonProperty]
        public string Username { get; set; }

        /// <summary>
        /// ArticleNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public DateTime? EventTime { get; set; }

		/// <summary>
		/// CancelQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

	}
}