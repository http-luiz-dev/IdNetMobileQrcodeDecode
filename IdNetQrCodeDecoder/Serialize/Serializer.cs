using System;

namespace IdNet.Mobile.Util.Serialize
{
    #pragma warning disable SYSLIB0011

    class Serializer
    {
        public static object ToObject(string serializedObject)
        {
            object res = null;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binform = null;

            try
            {
                using (var mso = new System.IO.MemoryStream(Convert.FromBase64String(serializedObject)))
                {
                    binform = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binform.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                    binform.Binder = new CustomizedBinder();

                    res = binform.Deserialize(mso);
                }
            }
            catch (System.Exception oError)
            {
                throw oError;
            }

            return res;
        }

        public static byte[] ToByteArray(object obj)
        {
            byte[] aData = null;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binform = null;

            try
            {
                using (var mso = new System.IO.MemoryStream())
                {
                    binform = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binform.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                    binform.Serialize(mso, obj);

                    aData = mso.ToArray();
                }
            }
            catch (System.Exception oError)
            {
                throw oError;
            }

            return aData;
        }
    }
#pragma warning restore SYSLIB0011


}
