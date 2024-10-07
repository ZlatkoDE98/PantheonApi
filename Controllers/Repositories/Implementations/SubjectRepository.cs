using Microsoft.EntityFrameworkCore;
using PantheonApi.Models;
using System.Linq.Dynamic.Core;
using PantheonApi.DTOs.Subject;
using PantheonApi.Repositories.Interfaces;

namespace PantheonApi.Repositories.Implementations
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly RsMfDemoContext _context;

        public SubjectRepository(RsMfDemoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubjectDto>> GetAllSubjectsAsync()
        {
            return await _context.THeSetSubjs
                .Select(s => new SubjectDto
                {
                    AcSubject = s.AcSubject,
                    AcName2 = s.AcName2,
                    AcAddress = s.AcAddress,
                    AcCode = s.AcCode,
                    AcPhone = s.AcPhone
                })
                .ToListAsync();
        }

        public async Task<SubjectDto> GetSubjectByIdAsync(string id)
        {
                                                                #pragma warning disable CS8603 // Possible null reference return.
            return await _context.THeSetSubjs
                .Where(s => s.AcSubject == id)
                .Select(s => new SubjectDto
                {
                    AcSubject = s.AcSubject,
                    AcName2 = s.AcName2,
                    AcAddress = s.AcAddress,
                    AcCode = s.AcCode,
                    AcPhone = s.AcPhone
                })
                .FirstOrDefaultAsync();
                                                                #pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<dynamic>> GetFilteredSubjectsAsync(string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                throw new ArgumentException("Fields must be specified", nameof(fields));
            }

            var selectedFields = fields.Split(',');
            var validFields = typeof(THeSetSubj).GetProperties()
                                                .Select(p => p.Name)
                                                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var field in selectedFields)
            {
                if (!validFields.Contains(field.Trim()))
                {
                    throw new ArgumentException($"Field '{field}' is not valid.", nameof(fields));
                }
            }

            var query = _context.THeSetSubjs
                .Select($"new({string.Join(",", selectedFields)})");

            return  await query.ToDynamicListAsync();
            
        }
    }
}