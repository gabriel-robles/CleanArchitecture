using BuberDinner.Domain.MenuAggregate;
using ErrorOr;
using MediatR;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Application.Common.Interfaces.Persistence;

namespace BuberDinner.Application.Menus.Commands.CreateMenu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
    {
        private readonly IMenuRepository _menuRepository;

        public CreateMenuCommandHandler(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<ErrorOr<Menu>> Handle(
            CreateMenuCommand request,
            CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var menu = Menu.Create(
                name: request.Name,
                description: request.Description,
                sections: request.Sections.ConvertAll(section => MenuSection.Create(
                    section.Name,
                    section.Description,
                    section.Items.ConvertAll(item => MenuItem.Create(
                        item.Name,
                        item.Description)))),
                hostId: HostId.CreateUnique());

            _menuRepository.Add(menu);

            return menu;
        }
    }
}