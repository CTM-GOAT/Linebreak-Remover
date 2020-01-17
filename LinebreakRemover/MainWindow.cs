using System;
using System.Text.RegularExpressions;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    { 
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnRemoveBreaksClicked(object sender, EventArgs e)
    {
        TextboxProgramOutput.Buffer.Text = "";
        string SingleLineString = RemoveBreaks(TextboxUserEntry.Buffer.Text);
        TextboxProgramOutput.Buffer.Text = SingleLineString;
    }

    protected void OnBtnClearClicked(object sender, EventArgs e)
    {
        TextboxProgramOutput.Buffer.Text = "";
        TextboxUserEntry.Buffer.Text = "";
    }

    static string RemoveBreaks(string InputText)
    {
        return Regex.Replace(InputText, @"\t|\n|\r", " ");
    }

}
