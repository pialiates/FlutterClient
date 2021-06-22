namespace FlutterSignalRClient.Models
{
    public class SantralModel : BaseModel
    {
        private UretimOzetModel uretimOzet;
        public UretimOzetModel UretimOzet { get => uretimOzet; set => SetProperty(ref uretimOzet, value); }

        public SantralModel()
        {

        }

        public SantralModel(UretimOzetModel uretimOzet)
        {
            this.UretimOzet = uretimOzet;
        }
    }
}
