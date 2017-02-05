// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinVinculado.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton atualizar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton limpar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textoArquivo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textoBiblioteca { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textoProjeto { get; set; }

        [Action ("Atualizar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Atualizar_TouchUpInside (UIKit.UIButton sender);

        [Action ("Limpar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Limpar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (atualizar != null) {
                atualizar.Dispose ();
                atualizar = null;
            }

            if (limpar != null) {
                limpar.Dispose ();
                limpar = null;
            }

            if (textoArquivo != null) {
                textoArquivo.Dispose ();
                textoArquivo = null;
            }

            if (textoBiblioteca != null) {
                textoBiblioteca.Dispose ();
                textoBiblioteca = null;
            }

            if (textoProjeto != null) {
                textoProjeto.Dispose ();
                textoProjeto = null;
            }
        }
    }
}