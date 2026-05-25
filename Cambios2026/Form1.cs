using Cambios2026.Modelos;
using Cambios2026.Servicos;

namespace Cambios2026;

public partial class Form1 : Form
{
    private List<Rate> Rates;

    private readonly NetworkService networkService;
    private readonly ApiService apiService;
    private readonly DialogService dialogService;
    private readonly DataService dataService;


    public Form1()
    {
        InitializeComponent();
        networkService = new NetworkService();
        apiService = new ApiService();
        dialogService = new DialogService();
        dataService = new DataService();
        LoadRates();
    }

    private async void LoadRates()
    {
        bool load;

        LabelResultado.Text = "A atualizar taxas...";

        var connection = networkService.CheckConnection();

        if (!connection.IsSucccess)
        {
            LoadLocalRates();
            load = false;
        }
        else
        {
            await LoadApiRates();
            load = true;
        }

        if (Rates.Count == 0)
        {
            LabelResultado.Text = "Não há ligação à Internet" + Environment.NewLine +
                "e não foram préviamente carregadas as taxas." + Environment.NewLine +
                "Tente mais tarde!";

            LabelStatus.Text = "Primeira inicialização deverá ter ligação á Internet";

            return;
        }



        ComboBoxOrigem.DataSource = Rates;
        ComboBoxOrigem.DisplayMember = "Name";

        ComboBoxDestino.BindingContext = new BindingContext();

        ComboBoxDestino.DataSource = Rates;
        ComboBoxDestino.DisplayMember = "Name";


        ButtonConverter.Enabled = true;
        ButtonTroca.Enabled = true;

        LabelResultado.Text = "Taxas atualizadas...";

        if (load)
        {
            LabelStatus.Text = string.Format("Taxas carregadas da internet em {0:F}", DateTime.Now);
        }
        else
        {
            LabelStatus.Text = string.Format("Taxas carregadas da base de dados.");
        }

        ProgressBar1.Value = 100;
    }

    private void LoadLocalRates()
    {
        Rates = dataService.GetData();
    }

    private async Task LoadApiRates()
    {
        ProgressBar1.Value = 0;

        var response = await apiService.GetRates("http://rates.somee.com", "/api/rates");

        Rates = (List<Rate>)response.Result;

        dataService.DeleteData();

        dataService.SaveData(Rates);
    }

    private void ButtonConverter_Click(object sender, EventArgs e)
    {
        Converter();
    }

    private void ButtonTroca_Click(object sender, EventArgs e)
    {
        Troca();
    }

    private void Converter()
    {
        if (string.IsNullOrEmpty(TextBoxValor.Text))
        {
            dialogService.ShowMessage("Insira um valor a converter", "Erro");
            return;
        }

        decimal valor;
        if (!decimal.TryParse(TextBoxValor.Text, out valor))
        {
            dialogService.ShowMessage("Valor terá de ser numérico", "Erro de conversão");
            return;
        }

        if (ComboBoxOrigem.SelectedItem == null)
        {
            dialogService.ShowMessage("Tem que escolher uma moeda a converter", "Erro");
            return;
        }

        if (ComboBoxDestino.SelectedItem == null)
        {
            dialogService.ShowMessage("Tem que escolher uma moeda de destino para converter", "Erro");
            return;
        }

        var taxaOrigem = (Rate)ComboBoxOrigem.SelectedItem;
        var taxaDestino = (Rate)ComboBoxDestino.SelectedItem;

        var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;
        LabelResultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}", taxaOrigem.Code, valor, taxaDestino.Code, valorConvertido);
    }

    private void Troca()
    {
        var aux = ComboBoxOrigem.SelectedItem;
        ComboBoxOrigem.SelectedItem = ComboBoxDestino.SelectedItem;
        ComboBoxDestino.SelectedItem = aux;
        Converter();
    }

   
}
