namespace BuberDinner.Contracts.Menus
{
    public record class CreateMenuRequest(
        string Name,
        string Description,
        List<MenuSection> Sections);

    public record class MenuSection(
        string Name,
        string Description,
        List<MenuItem> Items);

    public record class MenuItem(
        string Name,
        string Description);
}