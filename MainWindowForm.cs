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
        string[] inputs = InputTextBox.Lines;

        foreach (var stringProcessor in _stringProcessors)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = stringProcessor.Process(inputs[i]);
            }
            
        }
        
        OutputTextBox.Lines = inputs;
    }
}