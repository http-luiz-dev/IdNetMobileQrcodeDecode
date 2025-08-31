using idNet.Mobile.Configurations;
using IdNet.Mobile.Util.Serialize;
using System;

namespace IdNet.Mobile.Util.QrCode
{
    public class QrCodeDecoder 
    {
        public static InitialAccess DecodeInitialAccessQrcode(string key)
        {
            InitialAccess access = (InitialAccess)Serializer.ToObject(key);


            if (access.ExpireDate < System.DateTime.Today)
            {
                throw new FormatException("QRCode expirado.");
            }

            string url = access.Url;
            string state = access.State.ToString();


            var today = System.DateTime.Today.Year + "-" + System.DateTime.Today.Month + "-" + System.DateTime.Today.Day;


            return access;
        }



    }
}