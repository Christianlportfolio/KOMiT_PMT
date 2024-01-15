namespace KOMiT.Client.Shared
{
    // ConfirmationService.cs
    public class ConfirmationService
    {
        public string SuccessMessage { get; private set; }
        public string WarningMessage { get; private set; }

        public void SetSuccessMessage(string message)
        {
            SuccessMessage = message;
            WarningMessage = null; // Clear warning message
        }

        public void SetWarningMessage(string message)
        {
            WarningMessage = message;
            SuccessMessage = null; // Clear success message
        }
    }

}
