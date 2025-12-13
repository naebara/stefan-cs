
public class CarService : ICarService
{

    private AppDbContext _db;

    public CarService(AppDbContext appDbContext)
    {
        _db = appDbContext;
    }

    Car ICarService.Create(Car car)
    {
        throw new NotImplementedException();
    }

    List<Car> ICarService.GetAll()
    {
        return _db.Cars.ToList();
    }

    Car ICarService.GetById()
    {
        throw new NotImplementedException();
    }

    void ICarService.Remove(int id)
    {
        throw new NotImplementedException();
    }

    Car ICarService.Update(Car car)
    {
        throw new NotImplementedException();
    }
}