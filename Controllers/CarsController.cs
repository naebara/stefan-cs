using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cars")]
public class CarsController : ControllerBase
{

    private AppDbContext _db;

    public CarsController(AppDbContext db)
    {
        _db = db;
    }


    [HttpGet]
    public ActionResult<List<Car>> GetAll()
    {

       var allcars = _db.Cars.ToList();
       return Ok(allcars);
    }

    [HttpGet("{id}")]
    public ActionResult<Car> GetCarById(int id)
    {
        Car car = _db.Cars.Find(id);

        return car == null ?
            NotFound(new GeneralIssue($"Car with id {id} was not found")) :
            Ok(car);
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car car)
    {
        _db.Cars.Add(car);
        _db.SaveChanges();
        return Ok(car);
    }

    [HttpPut]
    public ActionResult<Car> updateCar([FromBody] Car car)
    {
        Car c = _db.Cars.Find(car.Id);

        if (c == null)
        {
            return NotFound(new GeneralIssue($"Car with id {car.Id} was not found."));
        }

        c.Brand = car.Brand;
        c.Model = car.Model;
        c.Motorizare = car.Motorizare;
        c.Hp = car.Hp;
        c.Price = car.Price;

        _db.SaveChanges();

        return Ok(c);
    }


    [HttpDelete("{id}")]
    public ActionResult RemoveCar(int id)
    {
        Car c = _db.Cars.Find(id);

        if (c == null)
        {
            return NotFound(new GeneralIssue($"Car with id {id} was not found in car list"));
        }

        _db.Cars.Remove(c);
        _db.SaveChanges();
        return NoContent();
    }

 
    // am ceva nou
    // am altceva nou

}