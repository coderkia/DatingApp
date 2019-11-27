using System;

public class MessageForCreationDto
{
    public int SenderId { get; set; }
    public int RecipientId { get; set; }
    public DateTime MessageDate { get; set; }
    public string Content { get; set; }
    public MessageForCreationDto()
    {
        MessageDate = DateTime.Now;
    }

}