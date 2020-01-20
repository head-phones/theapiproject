using AutoMapper;
using CapitalData.Models;
using System.Text.RegularExpressions;

namespace DomainLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<APILibrary.ProPublica.Members.MemberListItem, MemberViewModel>();

            CreateMap<APILibrary.ProPublica.Members.Member, MemberViewModel>()
                .ForMember(m => m.party, opt => opt.MapFrom( src => src.current_party))
                .ForMember(m => m.id, opt => opt.MapFrom(src => src.member_id));

            CreateMap<APILibrary.ProPublica.Members.Role, RoleViewModel>();


            CreateMap<APILibrary.ProPublica.Bills.Bill, BillViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Action, ActionViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Version, VersionViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.CosponsorsByParty, CosponsorsByPartyViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Amendment, AmendmentViewModel>();

            CreateMap<APILibrary.ProPublica.Bills.UpcomingBill, BillViewModel>()
                .ForMember(m => m.title, opt => opt.MapFrom(src => src.description))
                .ForMember(m => m.bill_id, opt => opt.MapFrom(src => src.bill_slug));


            CreateMap<APILibrary.ProPublica.Votes.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.Position, PositionViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.Democratic, DemocraticViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.Republican, RepublicanViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.Independent, IndependentViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.Total, TotalViewModel>();

            CreateMap<APILibrary.ProPublica.Subject, SubjectViewModel>();
            CreateMap<APILibrary.ProPublica.Members.Expenses, ExpensesViewModel>();
            CreateMap<APILibrary.ProPublica.Statements.Statement, StatementViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.Explanation, ExplanationViewModel>();

            CreateMap<APILibrary.ProPublica.Committee.Committee, CommitteeViewModel>();
            CreateMap<APILibrary.ProPublica.Committee.CommitteeResult, CommitteeViewModel>();
            CreateMap<APILibrary.ProPublica.Committee.Subcommittee, SubcommitteeViewModel>();
            CreateMap<APILibrary.ProPublica.Committee.Hearing, HearingViewModel>();
            CreateMap<APILibrary.ProPublica.Committee.FormerMember, CommitteeMemberViewModel>();
            CreateMap<APILibrary.ProPublica.Committee.CurrentMember, CommitteeMemberViewModel>();

            CreateMap<APILibrary.ProPublica.Lobbying.Filing, FilingViewModel>();
            CreateMap<APILibrary.ProPublica.Lobbying.LobbyingClient, LobbyingClientViewModel>();
            CreateMap<APILibrary.ProPublica.Lobbying.LobbyingRegistrant, LobbyingRegistrantViewModel>();
            CreateMap<APILibrary.ProPublica.Lobbying.LobbyingRepresentation, LobbyingRepresentationViewModel>();
            CreateMap<APILibrary.ProPublica.Lobbying.Lobbyist, LobbyistViewModel>();
        }
    }
}
