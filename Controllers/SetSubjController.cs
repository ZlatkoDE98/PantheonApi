using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PantheonApi.Models;
using PantheonApi.Repositories.Interfaces;
using System.Linq.Dynamic.Core;

namespace PantheonApi.Controllers
{
    [ApiController]
    [Route("api/subjects")]
    public class SubjectsController : ControllerBase
    {
        private readonly RsMfDemoContext _context;
        private readonly IMapper _mapper;
        private readonly ISubjectRepository _subjectRepository;

        public SubjectsController(IMapper mapper, RsMfDemoContext context, ISubjectRepository subjectRepository)
        {
            _context = context;
            _mapper = mapper;
            _subjectRepository = subjectRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<THeSetSubj>>> GetSubjects()
        {
            var subjects = await _subjectRepository.GetAllSubjectsAsync();

            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<THeSetSubj>> GetSubject(string id)
        {
            var subject = await _subjectRepository.GetSubjectByIdAsync(id);

            if (subject == null)
            {
                return NotFound();
            }

            return Ok(subject);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetFilteredSubjects([FromQuery] string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                return BadRequest("No fields specified.");
            }
            
            var selectedFields = fields.Split(',');
            var validFields = typeof(THeSetSubj).GetProperties()
                                                .Select(p => p.Name)
                                                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var field in selectedFields)
            {
                if (!validFields.Contains(field.Trim()))
                {
                    return BadRequest($"Field '{field}' is not valid.");
                }
            }

            var result = await _subjectRepository.GetFilteredSubjectsAsync(fields);
            return Ok(result);
        }
    }
}