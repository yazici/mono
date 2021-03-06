//
// AesCng.cs
//
// Authors:
//	Marek Safar  <marek.safar@gmail.com>
//
// Copyright (C) 2016 Xamarin Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Security.Cryptography
{
	public sealed class AesCng : Aes
	{
		public AesCng ()
		{
			throw new NotImplementedException ();
 		}

		public AesCng (string keyName)
		{
			throw new NotImplementedException ();
 		}

		public AesCng (string keyName, CngProvider provider)
		{
			throw new NotImplementedException ();
 		}

		public AesCng (string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
		{
			throw new NotImplementedException ();
 		}

		public override Byte[] Key {
			get {
				throw new NotImplementedException ();
			} set {
				throw new NotImplementedException ();
			}
		}
 
 		public override int KeySize {
			get {
				throw new NotImplementedException ();
 			}

 			set {
				throw new NotImplementedException ();
			}
		}
		public override ICryptoTransform CreateDecryptor ()
		{
			throw new NotImplementedException ();
		}

		public override ICryptoTransform CreateDecryptor (Byte[] rgbKey, Byte[] rgbIV)
		{
			throw new NotImplementedException ();
		}

		public override ICryptoTransform CreateEncryptor ()
		{
			throw new NotImplementedException ();
		}

		public override ICryptoTransform CreateEncryptor (Byte[] rgbKey, Byte[] rgbIV)
		{
			return default(System.Security.Cryptography.ICryptoTransform);
		}

		protected override void Dispose (bool disposing) {
			throw new NotImplementedException ();
 		}

		public override void GenerateIV ()
		{
			throw new NotImplementedException ();
 		}

		public override void GenerateKey ()
		{
			throw new NotImplementedException ();
 		}
	}
}