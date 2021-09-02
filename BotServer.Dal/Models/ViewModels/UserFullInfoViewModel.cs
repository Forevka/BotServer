namespace BotServer.Dal.Models.ViewModels
{
    public class UserFullInfoViewModel
    {
        public bool IsBlocked { get; set; }
        public bool CanBeCalled { get; set; }
        public bool SupportsVideoCalls { get; set; }
        public bool HasPrivateCalls { get; set; }
        public bool NeedPhoneNumberPrivacyException { get; set; }
        public string Bio { get; set; }
        public string ShareText { get; set; }
        public int GroupInCommonCount { get; set; }
    }
}
