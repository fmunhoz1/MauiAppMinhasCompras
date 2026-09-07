namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

	public void ToolbarItem_Clicked(Object sender, EventArgs e) 
	{
		try 
		{
			Navigation.PushAsync(new Views.NovoProduto());
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
	}
}