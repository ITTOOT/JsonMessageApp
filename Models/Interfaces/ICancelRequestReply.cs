namespace JsonMessageApi.Models
{
    /// Antwort auf Stornoanfrage von Host
    /// </summary>
    public interface ICancelRequestReply : IHostMessage
	{


		/// <summary>
		/// OutgoingGoodsNo 
		/// Warenausgangsnummer
		/// </summary>
		string OutgoingGoodsNo { get; set; }

		/// <summary>
		/// IsCanceled 
		/// 
		/// </summary>
		bool? IsCanceled { get; set; }

	}
}