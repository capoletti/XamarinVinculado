using System;
namespace XamarinVinculado.Arquivo
{
	public class ArquivoVinculado
	{
		public string RetornarValor(int contador)
		{
			string valor = "arquivo: " + contador;

#if __ANDROID__
			valor += " - Android: " + Android.OS.Build.VERSION.Codename;
#elif __IOS__
			valor += " - iOS: " + UIKit.UIDevice.CurrentDevice.SystemVersion;
			#endif

			return valor;
		}
	}
}
