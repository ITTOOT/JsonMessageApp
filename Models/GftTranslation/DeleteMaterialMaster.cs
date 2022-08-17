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
	public partial class DeleteMaterialMaster : HostMessage, IDeleteMaterialMaster
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
        /// ArticleNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }

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