using PantheonApi.DTOs.Subject;

namespace PantheonApi.Repositories.Interfaces
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<SubjectDto>> GetAllSubjectsAsync();
        Task<SubjectDto> GetSubjectByIdAsync(string id);
        Task<IEnumerable<dynamic>> GetFilteredSubjectsAsync(string fields);
    }
}