class MessageEventArgs : EventArgs
{
    public MessageEventArgs(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}

class Publisher
{
    public delegate void MessageEvent(object sender, EventArgs args);

    public event MessageEvent Message;

    public void SendMessage()
    {
        Message.Invoke(this, EventArgs.Empty);
    }

    // public event EventHandler<MessageEventArgs> Message;

    public void SendMessage(string message)
    {
        Message.Invoke(this, new MessageEventArgs(message));  
    }

}
