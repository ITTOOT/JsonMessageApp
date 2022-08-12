namespace JsonMessageApi.Models
{
    //using Constants = Gebhardt.StoreWare.WmsErp.Constants;

	public interface IHostMessageFunctions
	{
		bool Handle();
		void SetFailed(string errorMessage, Constants.Status? status = Constants.Status.Failed);
		void SetFinished(Constants.Status? status = Constants.Status.Finished);
	}
}