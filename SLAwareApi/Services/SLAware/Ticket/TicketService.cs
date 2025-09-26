using AutoMapper;
using SLAwareApi.Entities.SLAware;
using SLAwareApi.Entities.TFTAPPEntities;
using SLAwareApi.Interfaces.SLAware;
using SLAwareApi.Models.SLAware;
using SLAwareApi.Services.SLAware.Base;
using System;
using System.Net.Sockets;
using TFTShuttiAPI.TFTEntities.Helpers;
using static SLAwareApi.Enums.Enums;
using static SLAwareApi.Models.SLAware.Ticket.TicketModel;
using static SLAwareApi.Models.SLAware.TicketStatus.TicketStatusModels;
using static SLAwareApi.Models.TFTApp.GlobalsModels;

namespace SLAwareApi.Services.SLAware
{
    public class TicketService : ClinicalServiceBase, ITicketService
    {
        private readonly ISlaSeverityService _slaSeverityService;
        private readonly EntityHelper _entityHelper;
        private readonly IGlobalService _globalService;


        public TicketService(EntityHelper entityHelper, TftAppContext context, IGlobalService globalService, slaware_dataContext slawareContext, IMapper mapper, ISlaSeverityService slaSeverityService) : base(context, slawareContext, mapper)
        {
            _slaSeverityService = slaSeverityService;
            _entityHelper = entityHelper;
            _globalService = globalService;

        }

        //public async Task<ReturnModel> CreateTicket(CreatetTicketModel createtTicket)
        //{

        //    ReturnModel Result = new ReturnModel();



        //    try
        //    {
        //        //Create ticket
        //        var ticketModel = new Ticket();
        //        ticketModel.Subject = createtTicket.Subject;
        //        ticketModel.Description = createtTicket.Description;
        //        ticketModel.TicketStatusId = createtTicket.TicketStatusId;
        //        ticketModel.SeverityLevelId = createtTicket.SeverityLevelId;
        //        ticketModel.CreatedById = createtTicket.CreateById;
        //        ticketModel.CreatedAt = DateTime.Now;
        //        ticketModel.SubCategoryId = createtTicket.SubCategorylId;
        //        _slawareContext.Tickets.Add(ticketModel);
        //        //_slaware_DataContext.SaveChanges();

        //        //Create message
        //        var messageModel = new TicketMessage();
        //        messageModel.TicketId = ticketModel.Id;
        //        messageMosdel.MessageContent = createtTicket.Message;
        //        messageModel.CreatedAt = DateTime.Now;
        //        _slawareContext.TicketMessages.Add(messageModel);
        //        //_slaware_DataContext.SaveChanges();

        //        //SLA tracking
        //        foreach (var sev in createtTicket.SlaSeverities)
        //        {
        //            var track = new TicketSlaTracking();
        //            track.TicketId = ticketModel.Id;
        //            track.SlaSeverityLevelId = sev.Id;
        //            track.ResponseDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)sev.InitialResponseHours, 0, 0));
        //            track.ResolutionDueDtm = _slaSeverityService.CalculateSlaDue(ticketModel.CreatedAt, new TimeSpan((int)sev.TargetResolutionHours, 0, 0));
        //            track.CreatedAt = DateTime.Now;
        //            _slawareContext.TicketSlaTrackings.Add(track);
        //            //_slaware_DataContext.SaveChanges();
        //        }


        //        if (ticketModel != null)
        //        {
        //            Result.Status = true;
        //            Result.Result = ticketModel;
        //            Result.error = null;
        //        }
        //        else
        //        {
        //            Result.Status = false;
        //            Result.Result = null;
        //            Result.error = "Internal server error.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Gathering All the Error Details to be saved
        //        var Err = new ErrorTemplate
        //        {
        //            ErrCallingFunction = "Ticket Service: Get Ticket List",
        //            ErrErrorMessage = ex.Message.ToString(),
        //            ErrStacktrace = ex.StackTrace.ToString(),
        //        };
        //        //await _globalService.LogError(Err);

        //    }
        //    return Result;
        //}


        public async Task<ReturnModel> GetTicket(long id)
        {
            ReturnModel Result = new ReturnModel();
            TicketReturnModel TicketReturn = new TicketReturnModel();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(x => x.Id == id)
                    .Select(x => new TicketReturnModel()
                    {
                        Id = x.Id,
                        TicketNumber = x.TicketNumber,
                        Description = x.Description,
                        Subject = x.Subject,
                        TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(ts => ts.Name).FirstOrDefault(),
                        SeverityLevelId = x.SeverityLevelId,
                        CreatedById = x.CreatedById,
                        AssignedToId = x.AssignedToId,
                        Category = _slawareContext.TicketCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),
                        SubCategory = _slawareContext.TicketSubCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),
                        CreatedAt = x.CreatedAt
                    }).FirstOrDefault();

                if (TicketReturn != null)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
                    Result.error = $"Ticket details for id: {id} not found";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get Ticket",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;

        }

        public async Task<ReturnModel> GetAllTickets()
        {
            ReturnModel Result = new ReturnModel();
            List<TicketReturnModel> TicketReturn = new List<TicketReturnModel>();

            try
            {
                TicketReturn = _slawareContext.Tickets.Select(x => new TicketReturnModel()
                {
                    Id = x.Id,
                    TicketNumber = x.TicketNumber,
                    Description = x.Description,
                    Subject = x.Subject,
                    //TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(tn => tn.Name).FirstOrDefault(),
                    SeverityLevelId = x.SeverityLevelId,
                    CreatedById = x.CreatedById,
                    AssignedToId = x.AssignedToId,
                    TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(ts => ts.Name).FirstOrDefault(),

                    Category = _slawareContext.TicketCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),
                    SubCategory = _slawareContext.TicketSubCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),

                    CreatedAt = x.CreatedAt
                }).ToList();

                if (TicketReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
                    Result.error = "Internal server error.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get All Tickets",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;


        }

        public async Task<ReturnModel> GetClientTickets(long userId)
        {
            ReturnModel Result = new ReturnModel();
            List<TicketReturnModel> TicketReturn = new List<TicketReturnModel>();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(t => t.CreatedById == userId)
                    .Select(x => new TicketReturnModel()
                    {
                        Id = x.Id,
                        TicketNumber = x.TicketNumber,
                        Subject = x.Subject,
                        Description = x.Description,
                        SeverityLevelId = x.SeverityLevelId,
                        CreatedById = x.CreatedById,
                        AssignedToId = x.AssignedToId,
                        TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(ts => ts.Name).FirstOrDefault(),
                        Category = _slawareContext.TicketCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),
                        SubCategory = _slawareContext.TicketSubCategories.Where(c => c.Id == x.SubCategoryId).Select(c => c.Name).FirstOrDefault(),

                        CreatedAt = x.CreatedAt,

                    }).ToList();

                if (TicketReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
                    Result.error = "No Tickets found.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get Client Tickets",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;


        }

        public async Task<ReturnModel> GetAssignedTickets(long userId)
        {
            ReturnModel Result = new ReturnModel();
            List<TicketReturnModel> TicketReturn = new List<TicketReturnModel>();

            try
            {
                TicketReturn = _slawareContext.Tickets.Where(t => t.AssignedToId == userId)
                    .Select(x => new TicketReturnModel()
                    {
                        Id = x.Id,
                        TicketNumber = x.TicketNumber,
                        Description = x.Description,
                        Subject = x.Subject,
                        //TicketStatus = x.TicketStatusId,
                        SeverityLevelId = x.SeverityLevelId,
                        CreatedById = x.CreatedById,
                        AssignedToId = x.AssignedToId,
                        TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(ts => ts.Name).FirstOrDefault(),

                        Category = _slawareContext.TicketCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),
                        SubCategory = _slawareContext.TicketSubCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),

                        CreatedAt = x.CreatedAt,


                    }).ToList();

                if (TicketReturn.Count > 0)
                {
                    Result.Status = true;
                    Result.Result = TicketReturn;
                    Result.error = null;
                }
                else
                {
                    Result.Status = false;
                    Result.Result = TicketReturn;
                    Result.error = "No Tickets found.";
                }

            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service : Get Assigned Tickets",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                //await _globalService.LogError(Err);
            }
            return Result;


        }


        public async Task<ReturnModel> DeleteTicket(long id)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;
            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.Tickets.Where(a => a.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Ticket ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    


                    //_slawareContext.Tickets.Remove(exists);  // mark entity for deletion
                    exists.IsActive = false;

                    _slawareContext.SaveChanges();

                    Result.Status = true;
                    Result.Result = null;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Status Service: Delete Status",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }

        public async Task<ReturnModel> CreateTicket(CreateTicketModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketReturnModel ticketReturn = null;

            try
            {
                var priority = _slawareContext.SubCategorySeverityLevels.Where(sc => sc.SubCategoryId == RequestModel.SubCategoryId).Select(sc => sc.SlaSeverityLevelId).FirstOrDefault();
                Console.WriteLine("priority: " + priority);
                //Populating the Ticket model to be inserted

                var random = new Random();
                var ticketNumber = $"TCK-{DateTime.Now.Year}-{random.Next(100000, 999999)}";

                Ticket NewTicket = new Ticket()
                {
                    TicketNumber = ticketNumber,
                    Subject = RequestModel.Subject,
                    Description = RequestModel.Description,
                    TicketStatusId = 1,
                    SeverityLevelId = priority,
                    CreatedById = RequestModel.CreatedById,
                    CategoryId = RequestModel.CategoryId,
                    SubCategoryId = RequestModel.SubCategoryId,
                    CreatedAt = DateTime.Now,
                    IsActive = true
                };

                _slawareContext.Tickets.Add(NewTicket);
                _slawareContext.SaveChanges();

                //// Generate ticket number
                //NewTicket.TicketNumber = $"TCK-{DateTime.Now.Year}-{NewTicket.Id:D6}";
                //_slawareContext.Tickets.Update(NewTicket);
                //await _slawareContext.SaveChangesAsync();


                //TicketSlaTracking ticketSlaTracking = new TicketSlaTracking();
                //{

                //    TicketId = 
                //};


                ticketReturn = new TicketReturnModel()
                {
                    Id = NewTicket.Id,
                    Subject = NewTicket.Subject,
                    Description = NewTicket.Description,
                    SeverityLevelId = NewTicket.SeverityLevelId,
                    TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == NewTicket.TicketStatusId).Select(ts =>  ts.Name).FirstOrDefault(),
                    SubCategory = _slawareContext.TicketSubCategories.Where(ts => ts.Id == NewTicket.SubCategoryId).Select(ts =>  ts.Name).FirstOrDefault(),
                    Category = _slawareContext.TicketCategories.Where(ts => ts.Id == NewTicket.CategoryId).Select(ts =>  ts.Name).FirstOrDefault(),
                    CreatedById = NewTicket.CreatedById,
                    IsActive = NewTicket.IsActive,
                };

                Result.Status = true;
                Result.Result = NewTicket;
                Result.error = null;
            }
            catch (Exception ex)
            {
                Result.Result = null;
                Result.Status = false;
                Result.error = ex.Message.ToString();

                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Service: Create Ticket",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;

        }

        public async Task<ReturnModel> AssignTicketToAgent(long ticketId, long userId)
        {
            ReturnModel Result = new ReturnModel();
            TicketReturnModel ticketReturn = null;

            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    Result.Status = false;
                    Result.Result = null;
                    Result.error = $"User ID {userId} does not exist!";
                    return Result;
                }

                var ticket = _slawareContext.Tickets.FirstOrDefault(t => t.Id == ticketId);
                if (ticket == null)
                {
                    Result.Status = false;
                    Result.Result = null;
                    Result.error = $"Ticket ID {ticketId} does not exist!";
                    return Result;
                }

                // Assign
                ticket.AssignedToId = userId;
                await _slawareContext.SaveChangesAsync();

                // Return updated ticket
                ticketReturn = _slawareContext.Tickets
                    .Where(x => x.Id == ticketId)
                    .Select(x => new TicketReturnModel
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Subject = x.Subject,
                        TicketStatus = _slawareContext.TicketStatuses.Where(ts => ts.Id == x.TicketStatusId).Select(ts => ts.Name).FirstOrDefault(),
                        Category = _slawareContext.TicketCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),
                        SubCategory = _slawareContext.TicketSubCategories.Where(c => c.Id == x.CategoryId).Select(c => c.Name).FirstOrDefault(),

                        AssignedToId = x.AssignedToId,
                        IsActive = x.IsActive,
                    })
                    .FirstOrDefault();

                Result.Status = true;
                Result.Result = ticketReturn;
                Result.error = null;
            }
            catch (Exception ex)
            {
                Result.Status = false;
                Result.Result = null;
                Result.error = ex.Message;
            }

            return Result;
        }

        public async Task<ReturnModel> UpdateTicket(long id, UpdateTicketRequestModel RequestModel)
        {

            ReturnModel Result = new ReturnModel();
            TicketStatusReturnModel ticketStatusReturn = null;

            try
            {

                //Check to see if the application already exists
                var exists = _slawareContext.Tickets.Where(ts => ts.Id == id).FirstOrDefault();

                if (exists == null)
                {
                    Result.Status = false;
                    Result.Result = ticketStatusReturn;
                    Result.error = $"Ticket ID does not exist!";
                }
                else
                {
                    //Populating the application model to be updated    
                    // Updating Name
                    //if (!string.IsNullOrWhiteSpace(RequestModel))
                    //{
                    //    exists.Name = RequestModel.Name;
                    //}

                    //// Updating IsActive
                    //if (RequestModel.Active.HasValue)
                    //{
                    //    exists.Active = RequestModel.Active.Value;
                    //}

                    //// Updating Description
                    //if (!string.IsNullOrWhiteSpace(RequestModel.Description))
                    //{
                    //    exists.Description = RequestModel.Description;
                    //}


                    _slawareContext.SaveChanges();

                    ticketStatusReturn = _slawareContext.TicketStatuses.Where(x => x.Id == id).Select(x => new TicketStatusReturnModel()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Name = x.Name,
                        Active = x.Active,
                    }).FirstOrDefault();

                    Result.Status = true;
                    Result.Result = ticketStatusReturn;
                    Result.error = null;

                }
            }
            catch (Exception ex)
            {
                //Gathering All the Error Details to be saved
                var Err = new ErrorTemplate
                {
                    ErrCallingFunction = "Ticket Status Service: Update Ticket Status",
                    ErrErrorMessage = ex.Message.ToString(),
                    ErrStacktrace = ex.StackTrace.ToString(),
                };
                await _globalService.LogError(Err);
            }
            return Result;


        }
    }
}
