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


            CreateMap<APILibrary.ProPublica.Members.MemberVotes.Bill, BillViewModel>();
            CreateMap<APILibrary.ProPublica.Members.MemberVotes.Vote, VoteViewModel>();
            CreateMap<APILibrary.ProPublica.Members.MemberVotes.Total, TotalViewModel>();


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

        }
    }
}
