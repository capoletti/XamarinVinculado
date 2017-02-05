using System;
using XamarinVinculado.PLC;
namespace XamarinVinculado.Droid
{
	public class ArquivoBiblioteca: IArquivoBiblioteca
	{
		public ArquivoBiblioteca()
		{
		}

		public string RetornarValor(int contador)
		{
			return "biblioteca: " + contador + " - Android: " + Android.OS.Build.VERSION.Codename;
		}
	}
}
