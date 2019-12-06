using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using le_site.Core.UnitOfWorkGeneric;
using le_site.Data.Dto;
using le_site.Data.Entity;
using le_site.Repository.PersonneRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace le_site.web.Controllers
{
    [Route("api/Persone")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IPersonneRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public PersonneController(IMapper mapper, IPersonneRepository repository, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        //CRUD Create
        [HttpPost()]
        public async Task<IActionResult> CreatePersonne(PersonneDto personneDto)
        {
            var personne = mapper.Map<PersonneDto, Personne>(personneDto);
            repository.AddAsync(personne);
            await unitOfWork.CompletAsync();
            var result = mapper.Map<Personne, PersonneDto>(personne);
            return Ok(result);

        }

        //CRUD Read GetAll()
        [HttpGet()]
        public async Task<IEnumerable<Personne>> GetAll()
        {
            return await repository.GetAllAsync();

        }

        //CRUD Read GetById()
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var personne = await repository.GetAsync(id);
            if (personne == null)
                return BadRequest();

            var result = mapper.Map<Personne, PersonneDto>(personne);
            return Ok(result);
        }

        //CRUD Update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonne(int id,[FromBody]PersonneDto personneDto)
        {
            var personne = await repository.GetAsync(id);
            if (personne == null)
                return BadRequest();

            mapper.Map<PersonneDto, Personne>(personneDto, personne);
            await unitOfWork.CompletAsync();
            var result = mapper.Map<Personne, PersonneDto>(personne);
            return Ok(result);

        }

        //CRUD Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonne(int id)
        {
            var personne = await repository.GetAsync(id);
            if (personne == null)
                return BadRequest();

            repository.Remove(personne);
            await unitOfWork.CompletAsync();
            return Ok(id);
        }

    }
}