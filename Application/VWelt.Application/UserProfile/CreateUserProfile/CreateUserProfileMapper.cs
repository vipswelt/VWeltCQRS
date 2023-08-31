using AutoMapper;

namespace VWelt.Application.UserProfile.CreateUserProfile;

public class CreateUserProfileMapper:Profile
{
    public CreateUserProfileMapper()
    {
        CreateMap<CreateUserProfileRequest, VWelt.Domain.Entities.User.UserProfile>();
    }
}