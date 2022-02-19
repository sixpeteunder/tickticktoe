using TickTickToe.Core;

namespace TickTickToe.Web.Server.Models;

public class Game
{
    public Guid Id { get; set; }
    public Grid Grid = new();
    public byte[] PasswordHash { get; set; } = null!;
    public byte[] PasswordSalt { get; set; } = null!;
    public virtual ApplicationUser PlayerOne { get; set; } = null!;
    public virtual ApplicationUser PlayerTwo { get; set; } = null!;
    public virtual ApplicationUser Winner { get; set; } = null!;
    public DateTime CreatedAt { get; private set; } = DateTime.Now;

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();
    public virtual ICollection<Move> Moves { get; set; } = new List<Move>();
}