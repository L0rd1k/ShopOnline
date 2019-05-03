using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OnlineStore
{
    sealed class SecurePassword
    {
        private const int salt_Size = 16;
        private const int hash_Size = 20;
        private const int hash_Iter = 10000; // how many times the hash alg. is run
        readonly byte[] _salt, _hash;

        public SecurePassword()
        {
        }

        public SecurePassword(string password)
        {
            new RNGCryptoServiceProvider().GetBytes(this._salt = new byte[salt_Size]); // generate the random salt
            this._hash = new Rfc2898DeriveBytes(password, this._salt, hash_Iter).GetBytes(hash_Size);
        }

        public SecurePassword(byte[] hash_Bytes)
        {
            Array.Copy(hash_Bytes, 0, _salt = new byte[salt_Size], 0, salt_Size);
            Array.Copy(hash_Bytes, salt_Size, _hash = new byte[hash_Size], 0, hash_Size);
        }

        public SecurePassword(byte[] _salt, byte[] _hash)
        {
            Array.Copy(_salt, 0, this._salt = new byte[salt_Size], 0, salt_Size);
            Array.Copy(_hash, 0, this._hash = new byte[hash_Size], 0, hash_Size);
        }

        public byte[] ToArray()
        {
            byte[] hash_Bytes = new byte[salt_Size + hash_Size];
            Array.Copy(_salt, 0, hash_Bytes, 0, salt_Size);
            Array.Copy(_hash, 0, hash_Bytes, salt_Size, hash_Size);
            return hash_Bytes;
        }

        public byte[] Salt
        {
            get
            {
                return (byte[])_salt.Clone();
            }
        }

        public byte[] Hash
        {
            get
            {
                return (byte[])_hash.Clone();
            }
        }

        public bool Verify(string password)
        {
            byte[] test = new Rfc2898DeriveBytes(password, _salt, hash_Iter).GetBytes(hash_Size);
            for (int i = 0; i < hash_Size; i++)
                if (test[i] != _hash[i])
                    return false;
            return true;
        }

        public void TestRun()
        {
            SecurePassword hash = new SecurePassword("MyTestPassowrd");
            byte[] hashBytes = hash.ToArray();
            //byte[] hash_Bytes = data;
            //SecurePassword hash = new SecurePassword(hashBytes);
            if (!hash.Verify("newly entered password"))
                throw new System.UnauthorizedAccessException();
        }


    }

}
