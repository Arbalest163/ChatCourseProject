namespace Chat.Domain;
public class Chat : Entity
{
    public string Title { get; set; }
    /// <summary>
    /// ������������, ��������� ���
    /// </summary>
    public virtual User User { get; set; }
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    public virtual ICollection<User> Users { get; set; } = new List<User>();
    public virtual DateTimeOffset DateCreateChat { get; set; }
    public virtual bool IsActive { get; set; }
}