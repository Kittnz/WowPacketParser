using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Security;

namespace WowPacketParser.SRP6
{
    /*public class SRP6
    {
        private static readonly Srp6GroupParameters Group = Srp6StandardGroups.Rfc5054_1024;
        private static readonly IDigest Digest = new Sha256Digest();
        private static readonly SecureRandom Random = new SecureRandom();

        public void CalculateVerifier(string username, string password, out string s_hex, out string v_hex)
        {
            byte[] salt = new byte[16];
            Random.NextBytes(salt);
            BigInteger saltBigInt = new BigInteger(1, salt);

            byte[] identityHash = ComputeIdentityHash(username, password, salt);
            BigInteger verifier = Group.G.ModPow(new BigInteger(1, identityHash), Group.N);

            s_hex = BitConverter.ToString(salt).Replace("-", "").ToLower();
            v_hex = BitConverter.ToString(verifier.ToByteArrayUnsigned()).Replace("-", "").ToLower();
        }

        private byte[] ComputeIdentityHash(string username, string password, byte[] salt)
        {
            string identity = $"{username}:{password}";
            byte[] identityBytes = Encoding.UTF8.GetBytes(identity);

            Digest.BlockUpdate(identityBytes, 0, identityBytes.Length);
            Digest.BlockUpdate(salt, 0, salt.Length);

            byte[] result = new byte[Digest.GetDigestSize()];
            Digest.DoFinal(result, 0);

            return result;
        }
    }*/
}
