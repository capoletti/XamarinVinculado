using System;

using UIKit;

namespace XamarinVinculado.iOS
{
	public partial class ViewController : UIViewController
	{
		int contador = 0;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void Atualizar_TouchUpInside(UIButton sender)
		{
			contador++;
			textoArquivo.Text = (new Arquivo.ArquivoVinculado()).RetornarValor(contador);
			textoProjeto.Text = (new Projeto.ArquivoProjeto()).RetornarValor(contador);
			textoBiblioteca.Text = (new ArquivoBiblioteca()).RetornarValor(contador);
		}

		partial void Limpar_TouchUpInside(UIButton sender)
		{
			contador = 0;
			textoArquivo.Text = "Arquivo";
			textoProjeto.Text = "Projeto";
			textoBiblioteca.Text = "Biblioteca";
		}
	}
}
