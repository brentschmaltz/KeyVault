﻿using System;
using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Tokens;

namespace KeyVault
{
    public class KeyVaultSecurityKey : SecurityKey
    {
        public KeyVaultSecurityKey(string keyId)
        {
            KeyId = keyId;
        }

        public override int KeySize
        {
            get
            {
                // TODO how do we figure out the size?
                return 2048;
            }
        }
    }
}
