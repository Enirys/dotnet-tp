using CarthageCRUD.Data;
using CarthageCRUD.Models;
using CarthageCRUD.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarthageCRUD.Controllers
{
    public class ConcertsController : Controller
    {
        private readonly MVCDbContext _dbContext;

        public ConcertsController(MVCDbContext mVCDbContext)
        {
            _dbContext = mVCDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var concerts = await _dbContext.Concerts.ToListAsync();
            return View(concerts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddConcertViewModel addConcertRequest)
        {
            var concert = new Concert()
            {
                Id = Guid.NewGuid(),
                Name = addConcertRequest.Name,
                Description = addConcertRequest.Description,
                Location = addConcertRequest.Location,
                Date = addConcertRequest.Date,
                Price = addConcertRequest.Price
            };

            await _dbContext.Concerts.AddAsync(concert);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var concert = await _dbContext.Concerts.FirstOrDefaultAsync(x => x.Id == id);
            if(concert != null)
            {
                var viewModel = new UpdateConcertViewModel()
                {
                    Id = concert.Id,
                    Name = concert.Name,
                    Description = concert.Description,
                    Location = concert.Location,
                    Date = concert.Date,
                    Price = concert.Price
                };

                return await Task.Run(() => View("View", viewModel));
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateConcertViewModel model)
        {
            var concert = await _dbContext.Concerts.FindAsync(model.Id);

            if(concert != null)
            {
                concert.Description = model.Description;
                concert.Location = model.Location;
                concert.Date = model.Date;
                concert.Price = model.Price;
                concert.Name = model.Name;

                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateConcertViewModel model)
        {
            var concert = await _dbContext.Concerts.FindAsync(model.Id);

            if(concert != null)
            {
                _dbContext.Concerts.Remove(concert);

                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
