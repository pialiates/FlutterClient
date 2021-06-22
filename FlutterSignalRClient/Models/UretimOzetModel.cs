using System;
using System.Reflection.Metadata.Ecma335;

namespace FlutterSignalRClient.Models
{
    public class UretimOzetModel : BaseModel
    {
        private Decimal gunlukUretim;
        public Decimal GunlukUretim { get => gunlukUretim; set => SetProperty(ref gunlukUretim, value); }

        private Decimal bekleyenUretim;
        public Decimal BekleyenUretim { get => bekleyenUretim; set => SetProperty(ref bekleyenUretim, value); }

        private Decimal uretilenSiparis;
        public Decimal UretilenSiparis { get => uretilenSiparis; set => SetProperty(ref uretilenSiparis, value); }

        private Decimal bekleyenSiparis;
        public Decimal BekleyenSiparis { get => bekleyenSiparis; set => SetProperty(ref bekleyenSiparis, value); }

        private Decimal santralVerim;
        public Decimal SantralVerim { get => santralVerim; set => SetProperty(ref santralVerim, value); }

        private Decimal enerjiTuketim;
        public Decimal EnerjiTuketim { get => enerjiTuketim; set => SetProperty(ref enerjiTuketim, value); }

        public UretimOzetModel()
        {

        }

        public UretimOzetModel(Decimal gunlukUretim, Decimal bekleyenUretim, Decimal uretilenSiparis, Decimal bekleyenSiparis, Decimal santralVerim, Decimal enerjiTuketim)
        {
            GunlukUretim = gunlukUretim;
            BekleyenUretim = bekleyenUretim;
            UretilenSiparis = uretilenSiparis;
            BekleyenSiparis = bekleyenSiparis;
            SantralVerim = santralVerim;
            EnerjiTuketim = enerjiTuketim;
        }
    }
}
