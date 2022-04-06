using AutoMapper;
using Commander.Data;
using Commander.DTOs;
using Commander.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/command
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
        }

        //GET api/command/{id}
        [HttpGet("{id}", Name = "GetCommandById")]

        public ActionResult <CommandReadDTO> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            if (commandItem != null){
                return Ok(_mapper.Map<CommandReadDTO>(commandItem));
            }

            return NotFound();
        }

        //POST api/commands
        [HttpPost()]
        public ActionResult <CommandReadDTO> CreateCommand(CommandCreateDTO commandCreateDTO)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDTO);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDTO = _mapper.Map<CommandReadDTO>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new {Id = commandReadDTO.Id}, commandReadDTO);
        }

        //PUT api/commands/{id}
        [HttpPut("{id}")]
        public ActionResult <CommandReadDTO> UpdateCommand(int id, CommandUpdateDTO commandUpdateDTO)
        {
            var commandItem = _repository.GetCommandById(id);

            if (commandItem == null)
            {
                return NotFound();
            }

            _mapper.Map(commandUpdateDTO, commandItem);

            _repository.UpdateCommand(commandItem);
            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult <CommandReadDTO> PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDTO> patchDoc)
        {
            var commandItem = _repository.GetCommandById(id);

            if (commandItem == null)
            {
                return NotFound();
            }

            var commandToPatch = _mapper.Map<CommandUpdateDTO>(commandItem);
            patchDoc.ApplyTo(commandToPatch, ModelState);

            if(!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(commandToPatch, commandItem);

            _repository.UpdateCommand(commandItem);
            _repository.SaveChanges();

            return NoContent();
        }

        
        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            if (commandItem == null)
            {
                return NotFound();
            }
            
            _repository.DeleteCommand(commandItem);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}