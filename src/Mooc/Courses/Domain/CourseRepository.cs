using System.Threading.Tasks;
using CodelyTv.Mooc.Shared.Domain;

namespace CodelyTv.Mooc.Courses.Domain
{
    public interface CourseRepository
    {
        Task Save(Course course);
        Task<Course> Search(CourseId id);
    }
}
