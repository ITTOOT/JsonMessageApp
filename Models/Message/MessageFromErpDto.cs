namespace JsonMessageApi.Models
{
	using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    using NextApi.Utilities.JSON;

    /// <summary>
    /// Rückmeldung an das BFS, wenn ein Paket am Ziel abgeworfen wurde
    /// </summary>
    ///
    public partial class MessageFromErpDto
	{
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Header
        internal string _Hdr { get; set; }

        [NotMapped]
        [JsonProperty("Hdr")]
        public HdrDto Hdr
        {
            get { return (this._Hdr == null) ? null : JsonConvert.DeserializeObject<HdrDto>(this._Hdr); }
            set { _Hdr = JsonConvert.SerializeObject(value); }
        }

        // Request
        internal string _Request { get; set; }

        [NotMapped]
        [JsonProperty("Request")]
        public RequestDto Request
        {
            get { return (this._Request == null) ? null : JsonConvert.DeserializeObject<RequestDto>(this._Request); }
            set { _Request = JsonConvert.SerializeObject(value); }
        }
    }
}
