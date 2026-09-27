using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

	private async void ToolbarItem_Clciked(object sender, EventArgs e)
	{

        //Cadastro de produtos: O código utiliza try e catch para capturar possíveis erros
		//durante o cadastro do produto.

        try
        {
            // Cria um novo objeto Produto utilizando os dados preenchidos pelo usuário
            Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

            // Insere o produto no banco de dados
            await App.Db.Insert(p);

            // Informa ao usuário que o cadastro foi realizado com sucesso
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

		}catch (Exception ex)
		{
            // Captura erros e exibe uma mensagem para o usuário
            await DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}