namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;
	using Microsoft.VisualBasic;

    using Newtonsoft.Json;

    public abstract class HostMessage : IHostMessage
	{
		/// <summary>
		/// Id
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Id { get; set; }
		/// <summary>
		/// RefId
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? RefId { get; set; }
		/// <summary>
		/// RecordType
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.RecordType RecordType { get; set; }
		/// <summary>
		/// Status
		/// Default Value : Status.Pending
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.Status? Status { get; set; }
		/// <summary>
		/// ErrorInterface
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ErrorInterface { get; set; }
		/// <summary>
		/// Creator
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Creator { get; set; }
		/// <summary>
		/// Created
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime Created { get; set; }
		/// <summary>
		/// Process
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Process { get; set; }
		/// <summary>
		/// CcuVersion
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int CcuVersion { get; set; }
		/// <summary>
		/// Timestamp
		/// Default Value : 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime Timestamp { get; set; }
		public abstract bool Handle();
		public virtual void SetFailed(string errorMessage, Constants.Status? status = Constants.Status.Failed)
		{
			this.ErrorInterface = errorMessage;
			this.Status = status;
		}
		public virtual void SetFinished(Constants.Status? status = Constants.Status.Finished)
		{
			this.Status = status;
		}

		public override string ToString()
		{
			string json = JsonConvert.SerializeObject(this);
			return json;
		}

	}
}