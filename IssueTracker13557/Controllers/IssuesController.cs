using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IssueTracker13557.Data;
using IssueTracker13557.Models;
using IssueTracker13557.Repository;

namespace IssueTracker13557.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IssueTrackerDbContext _context;
        private readonly IIssuesRepository _issuesRepository;

        public IssuesController(IIssuesRepository issuesRepository)
        {
            _issuesRepository = issuesRepository;
        }

        // GET: api/Issues
        [HttpGet]
        public async Task<IEnumerable<Issue>> GetIssues()
        {
            return await _issuesRepository.GetAllIssues();
        }

        // GET: api/Issues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Issue>> GetIssue(int id)
        {
            var issue = await _issuesRepository.GetSingleIssue(id);

            if (issue == null)
            {
                return NotFound();
            }

            return Ok(issue);
        }

        // PUT: api/Issues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssue(int id, Issue issue)
        {
            if (id != issue.Id)
            {
                return BadRequest();
            }

            await _issuesRepository.UpdateIssue(issue);

            return NoContent();
        }

        // POST: api/Issues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Issue>> PostIssue(Issue issue)
        {
            await _issuesRepository.CreateIssue(issue);

            return CreatedAtAction("GetIssue", new { id = issue.Id }, issue);
        }

        // DELETE: api/Issues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIssue(int id)
        {
            await _issuesRepository.DeleteIssue(id);

            return NoContent();
        }
    }
}
