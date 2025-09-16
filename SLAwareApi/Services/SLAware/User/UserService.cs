using System.Data;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using static SLAwareApi.Enums.Enums;

namespace SLAwareApi.Services.SLAware
{
    public class UserService : SLAwareBaseService, IUserService
    {
        public UserService(slaware_dataContext slaware_DataContext) : base(slaware_DataContext)
        {

        }

        public async Task<UserModel> Login(string firstname)
        {
            var user = new UserModel();
            try
            {
                if(_slaware_DataContext.Users.FirstOrDefault(x => x.FirstName == firstname) is { } usrr)
                {
                    switch (usrr.RoleId)
                    {
                        case (int)Roles.Client:
                            user = GetClientDetails(usrr);
                            break;
                        case (int)Roles.Agent:

                            break;
                    }
                }
            }
            catch
            {

            }
            return user;
        }

        private UserModel GetClientDetails(User user)
        {
            var model = new UserModel();
            try
            {
                model = (from role in _slaware_DataContext.Roles
                         join tier in _slaware_DataContext.ClientTiers on user.ClientTierId equals tier.Id
                         where role.Id == user.RoleId
                         select new UserModel
                         {
                             Client = new ClientModel
                             {
                                 TierId = tier.Id,
                                 Tier = tier.Name,
                                 CommunicationTypes = (from comms in _slaware_DataContext.CommunicationTypes
                                                       join commsType in _slaware_DataContext.ClientTierCommunicationTypes on comms.Id equals commsType.CommunicationTypeId
                                                       where commsType.ClientTierId == user.ClientTierId
                                                       select new CommunicationTypeModel
                                                       {
                                                           Id = comms.Id,
                                                           Type = comms.Name
                                                       }).ToList()
                             },
                             UserId = user.Id,
                             FirstName = user.FirstName,
                             LastName = user.LastName,
                             RoleName = role.RoleName,
                             RoleId = role.Id
                         }).FirstOrDefault();
            }
            catch
            {

            }
            return model;
        }
    }
}
