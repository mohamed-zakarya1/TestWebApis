using Assn.Dtos.DoctorDtos;

namespace Assn.Repos.DoctorsRepo
{
    public interface IDoctorsRepo
    {
        GetDoctorsAll GetById(int id);
        IList<GetDoctorsAll> GetAll();
        void AddAll(GetDoctorsAll dto);
        void Delete(int id);
        void Update(GetDoctorsAll dto, int id);
    }
}
