namespace JsonMessageApi.Models.Constants
{
    public enum Status
	{
		/// <summary>
		/// The message is ready for processing
		/// </summary>
		Pending,
		/// <summary>
		/// The message is currently being processed
		/// </summary>
		InProgress,
		/// <summary>
		/// The processing was successful
		/// </summary>
		Finished,
		/// <summary>
		/// Processing the message failed.
		/// </summary>
		Failed,
	}
}