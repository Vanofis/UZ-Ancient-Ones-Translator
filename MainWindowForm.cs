using System.Windows.Forms;
using AncientOnesTranslator.Processors;

namespace AncientOnesTranslator;

public partial class MainWindowForm : Form
{
    private readonly IStringProcessor[] _stringProcessors =
    [
        new DoubleLetterProcessor(),
    ];
    
    public MainWindowForm()
    {
        InitializeComponent();
    }

    private void TranslateButton_Click(object sender, System.EventArgs e)
    {
        string[] input = InputTextBox.Lines;

        foreach (var stringProcessor in _stringProcessors)
        {
            stringProcessor.Process(ref input);
        }
        
        OutputTextBox.Lines = input;
    }
}