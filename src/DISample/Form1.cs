namespace DISample;

public partial class Form1 : Form
{
    private readonly GameState _gameState;
    private readonly IFormFactory _formFactory;

    public Form1(GameState gameState, IFormFactory formFactory)
    {
        InitializeComponent();
        _gameState = gameState;
        _formFactory = formFactory;
    }

    private void CreateForm2Button_Click(object sender, EventArgs e)
    {
        var form = _formFactory.CreateForm<Form2>();
        form.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = _formFactory.CreateForm<Form3>();
        form.Show();
    }
}
