using EFDTO;
using EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFDAL
{
    public class StudentDAL
    {
        public StudentDTO GetById(long id)
        {
            using (DataContext ctx = new DataContext())
            {
                Student student = ctx.Students.AsNoTracking()
                    .Include(e=>e.MinZu).Include(e=>e.Class)
                    .SingleOrDefault(s=>s.Id==id);


                StudentDTO dto = new StudentDTO();
                dto.Id = student.Id;
                dto.Name = student.Name;
                dto.MinZu = student.MinZu.Name;
                dto.ClassName = student.Class.Name;

                return dto;

            }

        }

    }
}
