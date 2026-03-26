using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSoftware.LicenceEngine.Common;
using AppSoftware.LicenceEngine.KeyGenerator;

namespace KeyGen.KeyGenerator
{
    public class KeyGeneratorWrapper
    {
        public string MakeKey(int seed, KeyByteSet[] keyByteSets, string expiryString)
        {
            var generator = new PkvKeyGenerator();
            return generator.MakeKey(seed, keyByteSets);
        }
    }
}