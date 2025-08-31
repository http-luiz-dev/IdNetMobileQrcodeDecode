using idNet.Mobile.Configurations;
using System;
using System.Runtime.Serialization;

namespace IdNet.Mobile.Util.Serialize
{

    sealed class CustomizedBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {


            return typeof(InitialAccess);
        }

        public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            base.BindToName(serializedType, out assemblyName, out typeName);
            assemblyName = "IdNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
        }
    }

}

