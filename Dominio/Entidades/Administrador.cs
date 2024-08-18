namespace MinimalApi.Dominio.Entidades;

public classe Administrador
{
    public int ID { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public string Perfil { get; set; } = default!;
}