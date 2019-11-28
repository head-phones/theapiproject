using AutoMapper;
using CapitalData.Models;
using System.Text.RegularExpressions;

namespace DomainLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<APILibrary.ProPublica.Members.ListMembers.Member, MemberViewModel>();

            CreateMap<APILibrary.ProPublica.Members.Member.Result, MemberViewModel>()
                .ForMember(m => m.party, opt => opt.MapFrom( src => src.current_party));
            CreateMap<APILibrary.ProPublica.Members.Member.Role, RoleViewModel>();

            CreateMap<APILibrary.ProPublica.Members.MemberBills.Bill, BillViewModel>()
                .ForMember(m => m.sponsor, opt => opt.MapFrom(src => src.sponsor_name))
                .ForMember(m => m.bill_slug, opt => opt.MapFrom(src => src.bill_id.Replace($"-{src.congress}", string.Empty)));
            CreateMap<APILibrary.ProPublica.Members.MemberBills.CosponsorsByParty, CosponsorsByPartyViewModel>();

            CreateMap<APILibrary.ProPublica.Bills.Bill.Result, BillViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Bill.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Bill.Action, ActionViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Bill.Version, VersionViewModel>();
            CreateMap<APILibrary.ProPublica.Bills.Bill.CosponsorsByParty, CosponsorsByPartyViewModel>();

            CreateMap<APILibrary.ProPublica.Bills.UpcomingBills.Bill, BillViewModel>()
                .ForMember(m => m.title, opt => opt.MapFrom(src => src.description))
                .ForMember(m => m.bill_id, opt => opt.MapFrom(src => src.bill_slug));

            CreateMap<APILibrary.ProPublica.Members.MemberVotes.Bill, BillViewModel>();
            CreateMap<APILibrary.ProPublica.Members.MemberVotes.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Members.MemberVotes.Total, TotalViewModel>();

            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Bill, BillViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Amendment, AmendmentViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Democratic, DemocraticViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Republican, RepublicanViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Independent, IndependentViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RecentVotes.Total, TotalViewModel>();


            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Position, PositionViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Bill, BillViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Democratic, DemocraticViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Republican, RepublicanViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Independent, IndependentViewModel>();
            CreateMap<APILibrary.ProPublica.Votes.RollCallVote.Total, TotalViewModel>();

        }
    }
}
