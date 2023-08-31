using AutoMapper;

namespace VWelt.Application.UserProfile.GetAllUserProfiles;
public class GetAllUserProfilesMapper:Profile
{
    public GetAllUserProfilesMapper()
    {
        CreateMap<VWelt.Domain.Entities.User.UserProfile,GetAllUserProfilesResponse>();
    }
}
