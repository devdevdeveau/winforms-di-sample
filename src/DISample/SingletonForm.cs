namespace DISample;

public class SingletonForm : Form
{
    protected SingletonState State = SingletonState.On;

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            this.Hide();
            return;
        }

        State = SingletonState.Off;
        base.OnFormClosing(e);
    }

    protected override void Dispose(bool disposing)
    {
        if (State == SingletonState.On)
        {
            return;
        }

        base.Dispose(disposing);
    }

    protected enum SingletonState
    {
        On,
        Off
    }
}