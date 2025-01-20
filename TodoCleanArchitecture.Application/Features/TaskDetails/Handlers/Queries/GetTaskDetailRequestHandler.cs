using AutoMapper;
using MediatR;
using Dapper;
using ProjectTracker.Application.DTOs.RequestDtos.Tasks;
using ProjectTracker.Application.Features.TaskDetails.Requests.Queries;
using ProjectTracker.Application.Abstractions;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Features.TaskDetails.Handlers.Queries
{
    public class GetTaskDetailRequestHandler : IRequestHandler<GetTaskDetailRequest, IList<TaskItemRequestDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISqlConnectionFactory _connectionFactory;

        public GetTaskDetailRequestHandler(ISqlConnectionFactory connectionFactory, IMapper mapper)
        {
            _mapper = mapper;
            _connectionFactory = connectionFactory;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IList<TaskItemRequestDto>> Handle(GetTaskDetailRequest request, CancellationToken cancellationToken)
        {
            using var connection = _connectionFactory.CreateConnection();
            int projectId = request.ProjectId;
            var sql = "SELECT * FROM TaskItem WHERE ProjectId=@projectId";
            var taskList = await connection.QueryAsync<TaskItem>(sql);
            return _mapper.Map<TaskItemRequestDto[]>(taskList);
        }
    }
}
