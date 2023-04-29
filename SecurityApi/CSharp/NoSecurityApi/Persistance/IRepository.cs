using Model;

namespace Persistance
{
  public interface IRepository
  {
    Worker Get(string index);
    Worker[] GetAll();
    bool Remove(string id);
  }
}