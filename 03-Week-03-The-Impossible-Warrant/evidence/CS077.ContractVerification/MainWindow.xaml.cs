using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace CS077.ContractVerification;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void EvaluateContractButton_Click(object sender, RoutedEventArgs e)
    {
        bool timestampConflict = TimestampConflictCheckBox.IsChecked == true;
        bool identityConfirmed = IdentityConfirmedCheckBox.IsChecked == true;
        bool sourceVerified = SourceVerifiedCheckBox.IsChecked == true;

        string verdict = EvaluateContract(timestampConflict, identityConfirmed, sourceVerified);
        VerdictTextBlock.Text = verdict;
        ExplanationTextBlock.Text = ExplainVerdict(verdict);
    }

    private static string EvaluateContract(
        bool timestampConflict,
        bool identityConfirmed,
        bool sourceVerified)
    {
        if (timestampConflict == true)
        {
            return "HOLD";
        }
        else if (identityConfirmed == false || sourceVerified == false) 
        {
            return "REVIEW";
        }
        else
        {
            return "CLEAR";
        }
    }

    private static string ExplainVerdict(string verdict)
    {
        // Customize these consequences for your runner. This function returns text.
        if (verdict == "HOLD")
        {
            return "Short holds the contract and investigates the conflicting timestamps.";
        }
        else if (verdict == "CLEAR")
        {
            return "Short sends the checked record to Captain Vale. The checks agree; they do not establish guilt.";
        }
        else
        {
            return "Short asks for another verified source before moving the contract.";
        }
    }
}
