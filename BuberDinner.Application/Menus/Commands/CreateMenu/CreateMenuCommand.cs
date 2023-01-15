using BuberDinner.Domain.MenuAggregate;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Menus.Commands.CreateMenu
{
    public record class CreateMenuCommand(
        string Name,
        string Description,
        List<MenuSectionCommand> Sections,
        string HostId) : IRequest<ErrorOr<Menu>>;

    public record class MenuSectionCommand(
        string Name,
        string Description,
        List<MenuItemCommand> Items);

    public record class MenuItemCommand(
        string Name,
        string Description);
}