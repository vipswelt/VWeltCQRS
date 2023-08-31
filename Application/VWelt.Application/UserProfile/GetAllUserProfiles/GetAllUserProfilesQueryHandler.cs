using MediatR;
using AutoMapper;
using VWelt.Application.Context;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

namespace VWelt.Application.UserProfile.GetAllUserProfiles;

public class GetAllUserProfilesQueryHandler : IRequestHandler<GetAllUserProfilesRequest, List<GetAllUserProfilesResponse>>
{
    private readonly IVWeltDbContext _vWeltDbContext;
    private readonly IMapper _mapper;

    public GetAllUserProfilesQueryHandler(IVWeltDbContext vWeltDbContext,
    IMapper mapper)
    {
        _vWeltDbContext = vWeltDbContext;
        _mapper = mapper;
    }

    public Task<List<GetAllUserProfilesResponse>> Handle(GetAllUserProfilesRequest request, CancellationToken cancellationToken)
    {
        return _vWeltDbContext.UserProfiles.ProjectTo<GetAllUserProfilesResponse>(_mapper.ConfigurationProvider)
        .ToListAsync();
    }
}