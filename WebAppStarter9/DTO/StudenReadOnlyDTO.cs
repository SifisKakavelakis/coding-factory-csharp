namespace WebAppStarter9.DTO
{
    public record StudenReadOnlyDTO(int Id, string? Firstname, string? Lastname)
    {
            public StudenReadOnlyDTO() : this(default, default, default)
            {
        }
    }
}
