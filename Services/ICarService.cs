public interface ICarService
{
    
    List<Car> GetAll();
    Car GetById();
    Car Create(Car car);
    Car Update(Car car);
    void Remove(int id);

}