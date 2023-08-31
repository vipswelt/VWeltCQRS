using MediatR;

namespace VWelt.Application.UserProfile.CreateUserProfile;
public class CreateUserProfileRequest:IRequest<int>
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string MobileNo { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}
