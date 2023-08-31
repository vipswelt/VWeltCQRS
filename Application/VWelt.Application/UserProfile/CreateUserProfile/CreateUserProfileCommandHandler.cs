using AutoMapper;
using VWelt.Application.Context;
using MediatR;
using System.Linq.Expressions;

namespace VWelt.Application.UserProfile.CreateUserProfile;

public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileRequest, int>
{
    private readonly IVWeltDbContext _vWeltDbContext;
    private readonly IMapper _mapper;
    public CreateUserProfileCommandHandler(IVWeltDbContext vWeltDbContext,
    IMapper mapper)
    {
        _vWeltDbContext = vWeltDbContext;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateUserProfileRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var newUserProfile = _mapper.Map<VWelt.Domain.Entities.User.UserProfile>(request);
            _vWeltDbContext.UserProfiles.Add(newUserProfile);
            await _vWeltDbContext.SaveToDbAsync();
            return newUserProfile.Id;
        }
        catch (Exception ex)
        {
            return 0;
        }
    }
}