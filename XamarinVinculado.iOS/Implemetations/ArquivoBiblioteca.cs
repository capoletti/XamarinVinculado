using System;
using XamarinVinculado.PLC;
namespace XamarinVinculado.iOS
{
	public class ArquivoBiblioteca : IArquivoBiblioteca
	{
		public ArquivoBiblioteca()
		{
		}

		public string RetornarValor(int contador)
		{
			return "biblioteca: " + contador + " - iOS: " + UIKit.UIDevice.CurrentDevice.SystemVersion;
		}
	}
}
