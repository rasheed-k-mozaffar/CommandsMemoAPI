using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsMemoAPI.Data;
using CommandsMemoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommandsMemoAPI.Controllers
{

    [Route("api/[controller]")]
    public class DataProviderController : Controller
    {
        private readonly CommandsContext _context;

        public DataProviderController(CommandsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var commands = ReadFromJsonFile();

            return Ok(commands);
        }


        [HttpPost]
        public ActionResult PostToProvide()
        {
            var commands = ReadFromJsonFile();

            AddCommandsToDB(commands);

            return Ok();
        }


        public void AddCommandsToDB(Command[] commands)
        {
            foreach (var command in commands)
            {
                _context.CommandItems.Add(command);
                _context.SaveChanges();
            }
        }

        public Command[] ReadFromJsonFile()
        {
            using (var reader = new StreamReader("commands.json"))
            {
                string jsonData = reader.ReadToEnd();
                var commands = JsonConvert.DeserializeObject<Command[]>(jsonData);
                return commands!;
            }
        }
    }
}

