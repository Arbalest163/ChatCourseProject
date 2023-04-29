namespace Chat.Domain;
public class User : Entity
{
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string MiddleName { get; set; }
    public virtual DateTimeOffset Birthday { get; set; }
    public virtual string Nickname { get; set; }
    public virtual Role Role { get; set; }
    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();
}
