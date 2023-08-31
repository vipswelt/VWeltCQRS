using FluentValidation;

namespace VWelt.Application.UserProfile.CreateUserProfile;

public class CreateUserProfileValidator : AbstractValidator<CreateUserProfileRequest>
{
    public CreateUserProfileValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.MobileNo).NotEmpty();
        RuleFor(x => x.CreatedOn).NotNull();
        RuleFor(x => x.UpdatedOn).NotNull();
    }

}