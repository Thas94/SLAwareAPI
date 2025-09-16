using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using SLAwareApi.Services.SLAware.Base;
using System.Data;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Enums.Enums;
using User = SLAwareApi.Entities.SLAware.User;

namespace SLAwareApi.Services.SLAware
{
    public class UserService : ClinicalServiceBase, IUserService
    {
        //public UserService(slaware_dataContext slaware_DataContext) : base(slaware_DataContext)
        //{

        //}

        private readonly EntityHelper _entityHelper;

        public UserService(EntityHelper entityHelper, TftAppContext context, slaware_dataContext slawareContext, IMapper mapper) : base(context, slawareContext, mapper)
        {
            _entityHelper = entityHelper;
        }

        public async Task<UserModel> Login(string firstname)
        {
            var user = new UserModel();
            try
            {
                if(_slawareContext.Users.FirstOrDefault(x => x.FirstName == firstname) is { } usrr)
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
                model = (from role in _slawareContext.Roles
                         join tier in _slawareContext.ClientTiers on user.ClientTierId equals tier.Id
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
