using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace API.Controllers

{
    public class ActivitiesController : BaseApiController
    {
       private readonly DataContext _Context;
        public ActivitiesController(DataContext context)
        {
            _Context = context;
          
        }
    
            [HttpGet] //api/activities
         public async Task <ActionResult<List<Activity>>>GetActivities()
         {
            return await _Context.Activities.ToListAsync();
         }

          [HttpGet("{id}")] //api/activities//id
         public async Task <ActionResult<Activity>>GetActivity(Guid id)
         {
        
     return await _Context.Activities.FindAsync(id);

         }
    }
       
}

// using Domain;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Persistence;

// namespace API.Controllers
// {
//     public class ActivitiesController : BaseApiController
//     {
//         private readonly DataContext _context;
//         public ActivitiesController(DataContext context)
//         {
//             _context = context;
//         }

//         [HttpGet] //api/activities
//         public async Task<ActionResult<List<Activity>>> GetActivities()
//         {
//             return await _context.Activities.ToListAsync();
//         }

//         [HttpGet("{id}")] //api/activities/fdfkdffdfd
//         public async Task<ActionResult<Activity>> GetActivity(Guid id)
//         {
//             return await _context.Activities.FindAsync(id);
//         }
//     }
// }