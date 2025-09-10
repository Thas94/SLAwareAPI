using SLAwareApi.Entities.SLAware;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;

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

                var query = (from usr in _slaware_DataContext.Users
                             join role in _slaware_DataContext.Roles on usr.RoleId equals role.Id
                             join tier in _slaware_DataContext.ClientTiers on usr.ClientTierId equals tier.Id
                             where usr.FirstName == firstname
                             select new UserModel
                             {
                                 UserId = usr.Id,
                                 FirstName = usr.FirstName,
                                 LastName = usr.LastName,
                                 RoleName = role.RoleName,
                                 ClientTier = tier.Name,
                                 SlaSeverities = (from clientSeverityLevel in _slaware_DataContext.ClientTierSeverityLevels
                                                  join severityLevelRule in _slaware_DataContext.SlaSeverityLevelRules on clientSeverityLevel.SlaSeverityLevelId equals severityLevelRule.SlaSeverityLevelId
                                                  join severityLevel in _slaware_DataContext.SlaSeverityLevels on severityLevelRule.SlaSeverityLevelId equals severityLevel.Id
                                                  where clientSeverityLevel.ClientTierId == usr.ClientTierId
                                                  select new SlaSeverityModel
                                                  {
                                                      SeverityLevels = severityLevel.Name,
                                                      InitialResponseHours = severityLevelRule.InitialResponseHours,
                                                      TargetResolutionHours = severityLevelRule.TargetResolutionHours,
                                                  }).ToList(),
                                 CommunicationTypes = (from comms in _slaware_DataContext.CommunicationTypes
                                                       join commsType in _slaware_DataContext.ClientTierCommunicationTypes on comms.Id equals commsType.CommunicationTypeId
                                                       where commsType.ClientTierId == usr.ClientTierId
                                                       select new CommunicationTypeModel
                                                       {
                                                           Id = comms.Id,
                                                           Type = comms.Name
                                                       }).ToList()
                             }).ToList();
                var tets = "dcd";

            }
            catch
            {

            }
            return user;
        }
    }
}
