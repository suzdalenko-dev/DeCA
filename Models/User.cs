using System.ComponentModel.DataAnnotations;
public class User
{
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string Email { get; set; } = string.Empty;
    public string? Password { get; set; }
    public string? Token { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") is string ? DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) : DateTime.Now;
    public DateTime? LastLoginAt { get; set; }
}