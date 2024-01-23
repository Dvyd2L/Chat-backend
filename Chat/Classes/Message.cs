namespace Chat.Classes;

public class Message
{
    public required string User { get; set; }
    public required string Text { get; set; }
    public required string Avatar { get; set; }
    public required string Room { get; set; }

    public int? Id { get; set; }
    public DateTime Fecha { get; set; }
}
