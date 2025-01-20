using AutoMapper;
using MediatR;
using Dapper;
using ProjectTracker.Application.Features.ProjectInfo.Requests.Queries;
using ProjectTracker.Domain.Data;
using ProjectTracker.Domain.Abstractions;
using Application.DTOs.RequestDtos.Projects;

namespace ProjectTracker.Application.Features.ProjectInfo.Handlers.Queries
{
    public class GetProjectInfoRequestHandler : IRequestHandler<GetProjectInfoRequest,ProjectRequestDto>
    {
        private IMapper _mapper;
        private readonly ISqlConnectionFactory _connectionFactory;

        public GetProjectInfoRequestHandler( IMapper mapper, ISqlConnectionFactory connectionFactory)
        {
            _mapper = mapper;
            _connectionFactory = connectionFactory;
        }
        public async Task<ProjectRequestDto> Handle(GetProjectInfoRequest request, CancellationToken cancellationToken)
        {
            using var connection = _connectionFactory.CreateConnection();
            int id = request.id;
            var sql = "SELECT * FROM Project WHERE id=@id";
            var project= await connection.QueryAsync<Project>(sql);
            return _mapper.Map<ProjectRequestDto>(project);
        }
    }
}
