using System;

namespace idNet.Mobile.Configurations
{
    [Serializable]
    public class InitialAccess
    {
        public string Url
        {
            get;
            set;
        }

        public string State
        {
            get;
            set;
        }

        public System.DateTime ExpireDate
        {
            get;
            set;
        }
    }
}
