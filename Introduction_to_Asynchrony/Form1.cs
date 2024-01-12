namespace Introduction_to_Asynchrony;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Non-async button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = "Non-async button clicked. Pausing thread for 5 seconds..."; // this wont be printed because the ui thread is blocked and not updated.
        Thread.Sleep(5000); // replicating time consuming operation.
        textBox1.Text = "Non-async operation completed.";
    }

    /// <summary>
    /// async button event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void button2_Click(object sender, EventArgs e)
    {
        textBox2.Text = "Async button clicked. delaying task for 5 seconds without pausing thread.";
        await Task.Delay(5000); // replicating time consuming operation.
        textBox2.Text = "Async operation completed.";
    }
}
