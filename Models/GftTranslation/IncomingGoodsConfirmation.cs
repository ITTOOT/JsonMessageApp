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
	public partial class IncomingGoodsConfirmation : HostMessage, IIncomingGoodsConfirmation
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
        /// IncomingGoodsNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string IncomingGoodsNo { get; set; }

		/// <summary>
		/// FiFo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? FiFo { get; set; }

		/// <summary>
		/// MovementType 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// StorageArea 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

		/// <summary>
		/// Module 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Module { get; set; }

		/// <summary>
		/// Client 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Client { get; set; }

		/// <summary>
		/// Variant 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Variant { get; set; }

	}
}