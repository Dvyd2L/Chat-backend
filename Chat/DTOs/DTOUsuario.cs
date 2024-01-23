namespace Chat.DTOs;

public class DTOUsuario
{
    //public int? Id { get; set; }
    public string? Nombre { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }

    public string? Rol { get; set; }
}

public class DTOUsuarioLinkChangePassword
{
    public required string Email { get; set; }
}


public class DTOUsuarioChangePassword
{
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Enlace { get; set; }
}