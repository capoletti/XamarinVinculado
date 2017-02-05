using System;
namespace XamarinVinculado.Projeto
{
	public class ArquivoProjeto
	{
		public string RetornarValor(int contador)
		{
			string valor = "projeto: " + contador;

#if __ANDROID__
			valor += " - Android: " + Android.OS.Build.VERSION.Codename;
#elif __IOS__
			valor += " - iOS: " + UIKit.UIDevice.CurrentDevice.SystemVersion;
#endif

			return valor;
		}
	}
}
