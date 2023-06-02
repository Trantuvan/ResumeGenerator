using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ResumeGenerator.Core;
using ResumeGenerator.Services;

namespace ResumeGenerator.API;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    #region [Fields]
    private readonly IPersonRepository _personRepository;
    private readonly IMapper _mapper;
    #endregion

    #region [Ctor]
    public PersonController(IPersonRepository personRepository, IMapper mapper)
    {
        _personRepository = personRepository;
        _mapper = mapper;
    }
    #endregion

    #region [GET]
    [HttpGet("{id}")]
    public async Task<ActionResult<PersonDTO>> GetById(Guid id, CancellationToken token)
    {
        var person = await _personRepository.FindByIdAsync(id, token);

        if (person is null)
        {
            return NotFound();
        }

        return _mapper.Map<PersonDTO>(person);
    }
    #endregion

    #region [POST]
    [HttpPost]
    public async Task<ActionResult> Create([FromBody] PersonDTO request, CancellationToken token)
    {

        var person = _mapper.Map<Person>(request);
        _personRepository.Add(person);

        await _personRepository.SaveChangesAsync(token);

        return CreatedAtAction(nameof(GetById), new { id = person.Id }, _mapper.Map<PersonDTO>(person));
    }
    #endregion

    #region [PUT]
    [HttpPut]
    public async Task<ActionResult> Update([FromBody] PersonDTO request, CancellationToken token)
    {
        var personToUpdate = await _personRepository.FindByIdAsync(request.Id, token);

        if (personToUpdate is null)
        {
            return NotFound($"person does not exist");
        }

        _mapper.Map(request, personToUpdate);

        await _personRepository.SaveChangesAsync(token);

        return CreatedAtAction(nameof(GetById), new { id = personToUpdate.Id }, personToUpdate);
    }
    #endregion

    #region [DELETE]
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid id, CancellationToken token)
    {

        var personToDelete = await _personRepository.FindByIdAsync(id, token);

        if (personToDelete is null)
        {
            return NotFound($"person does not exist");
        }

        _personRepository.Remove(personToDelete);
        await _personRepository.SaveChangesAsync(token);

        return NoContent();
    }
    #endregion
}

