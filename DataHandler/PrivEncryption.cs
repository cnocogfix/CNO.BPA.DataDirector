// *************************************************************************
// <copyright file="DemoEncryption.cs" company="Elegant Software Solutions, LLC">
//     Copyright (C) 2011 Elegant Software Solutions, LLC.  All rights reserved worldwide.
// </copyright>
// *************************************************************************

namespace CNO.BPA.DataHandler
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Security.Cryptography;
   using System.Text;

   /// <summary>
   /// This class is used to perform username and password encryption in the Demo java system.
   /// </summary>
   public class PrivEncryption
   {
      private string _passCode = "";
      public PrivEncryption(string passCode)
      {
         _passCode = passCode;
      }
      public string EncryptUsernamePassword(string clearText)
      {
         // TODO: Parameterize the Password, Salt, and Iterations.  They should be encrypted with the machine key and stored in the registry

         if (string.IsNullOrEmpty(clearText))
         {
            return clearText;
         }

         byte[] salt = new byte[]
            {
                (byte)0xc7,
                (byte)0x73,
                (byte)0x21,
                (byte)0x8c,
                (byte)0x7e,
                (byte)0xc8,
                (byte)0xee,
                (byte)0x99
            };

         // NOTE: The keystring, salt, and iterations must be the same as what is used in the Demo java system.
         PKCSKeyGenerator crypto = new PKCSKeyGenerator(_passCode, salt, 28, 1);

         ICryptoTransform cryptoTransform = crypto.Encryptor;
         byte[] cipherBytes = cryptoTransform.TransformFinalBlock(Encoding.UTF8.GetBytes(clearText), 0, clearText.Length);
         return System.Convert.ToBase64String(cipherBytes);
      }

      /// <summary>
      /// Use this method to decrypt usernames and passwords in the Demo user table.  The password and salt are hardcoded into this method.
      /// </summary>
      /// <param name="clearText">This is the cipher text you wish to decrypt.</param>
      /// <returns>Returns the decrypted version of the cipher text.</returns>
      public string DecryptUsernamePassword(string cipherText)
      {
         if (string.IsNullOrEmpty(cipherText))
         {
            return cipherText;
         }

         byte[] salt = new byte[]
            {
                (byte)0xc7,
                (byte)0x73,
                (byte)0x21,
                (byte)0x8c,
                (byte)0x7e,
                (byte)0xc8,
                (byte)0xee,
                (byte)0x99
            };

         // NOTE: The keystring, salt, and iterations must be the same as what is used in the Demo java system.
         PKCSKeyGenerator crypto = new PKCSKeyGenerator(_passCode, salt, 28, 1);

         ICryptoTransform cryptoTransform = crypto.Decryptor;
         byte[] cipherBytes = System.Convert.FromBase64String(cipherText);
         byte[] clearBytes = cryptoTransform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
         return Encoding.UTF8.GetString(clearBytes);
      }
   }
}
