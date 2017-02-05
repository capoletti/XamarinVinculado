using System;
namespace XamarinVinculado.PLC
{
	public class ArquivoBibliotecaImpl
	{
		private IArquivoBiblioteca arquivoBiblioteca;

		/// <summary>
		/// Construtor recebendo a interface
		/// </summary>
		/// <param name="arquivoBiblioteca">Arquivo biblioteca.</param>
		public ArquivoBibliotecaImpl(IArquivoBiblioteca arquivoBiblioteca)
		{
			this.arquivoBiblioteca = arquivoBiblioteca;
		}

		/// <summary>
		/// Implementa o método retornar da interface
		/// </summary>
		/// <returns>The valor.</returns>
		/// <param name="contador">Contador.</param>
		public string RetornarValor(int contador)
		{
			return arquivoBiblioteca.RetornarValor(contador);
		}
	}
}
