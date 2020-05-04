using GoodReads.Domain;

namespace Infrastructure
{
    public interface IBookLibraryRepository
    {
        Book GetById(int id);
    }
}