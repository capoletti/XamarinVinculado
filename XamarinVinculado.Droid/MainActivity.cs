using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinVinculado.Droid
{
	[Activity(Label = "XamarinVinculado.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 0;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button bAtualizar = FindViewById<Button>(Resource.Id.atualizar);
			Button bLimpar = FindViewById<Button>(Resource.Id.limpar);
			bAtualizar.Click += delegate { atualizar(); };
			bLimpar.Click += delegate { limpar(); };
		}

		private void atualizar()
		{
			count++;
			TextView tArquivo = FindViewById<TextView>(Resource.Id.textArquivo);
			TextView tProjeto = FindViewById<TextView>(Resource.Id.textProjeto);
			TextView tBiblioteca = FindViewById<TextView>(Resource.Id.textBiblioteca);
			tArquivo.Text = (new Arquivo.ArquivoVinculado()).RetornarValor(count);
			tProjeto.Text = (new Projeto.ArquivoProjeto()).RetornarValor(count);
			tBiblioteca.Text = (new ArquivoBiblioteca()).RetornarValor(count);
		}

		private void limpar()
		{
			count = 0;
			TextView tArquivo = FindViewById<TextView>(Resource.Id.textArquivo);
			TextView tProjeto = FindViewById<TextView>(Resource.Id.textProjeto);
			TextView tBiblioteca = FindViewById<TextView>(Resource.Id.textBiblioteca);
			tArquivo.Text = "Arquivo";
			tProjeto.Text = "Projeto";
			tBiblioteca.Text = "Biblioteca";
		}
	}
}

