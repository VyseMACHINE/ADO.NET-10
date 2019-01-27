using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFMigrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FacultyContext db = new FacultyContext())
            {
                Faculty energyFac = new Faculty { Name = "Энергетический" };
                Faculty economFac = new Faculty { Name = "Экономический" };
                Faculty historyFac = new Faculty { Name = "Истории" };
                db.Faculties.AddRange(new List<Faculty> { energyFac, economFac, historyFac });
                db.SaveChanges();

                Group sep172 = new Group { Name = "SEP172", Faculty = energyFac };
                Group sep272 = new Group { Name = "SEP272", Faculty = energyFac };
                Group sep372 = new Group { Name = "SEP372", Faculty = energyFac };
                Group ep101 = new Group { Name = "EP101", Faculty = economFac };
                Group ep201 = new Group { Name = "EP201", Faculty = economFac };
                Group his103 = new Group { Name = "HIS103", Faculty = historyFac };
                Group his303 = new Group { Name = "HIS303", Faculty = historyFac };
                db.Groups.AddRange(new List<Group> { sep172, sep272, sep372, ep101, ep201, his103, his303 });
                db.SaveChanges();

                db.Students.Add(new Student { Fio = "Сабитов Ильяс Маратович", GroupId = sep172.Id });
                db.Students.Add(new Student { Fio = "Кентаев Талгат Жанатович", GroupId = sep172.Id });
                db.Students.Add(new Student { Fio = "Касенов Касым Аманович", GroupId = sep172.Id });
                db.Students.Add(new Student { Fio = "Таукел Кайрат Есболович", GroupId = sep272.Id });
                db.Students.Add(new Student { Fio = "Головкин Генадий Генадьевич", GroupId = sep272.Id });
                db.Students.Add(new Student { Fio = "Пакьяо Мэнни Дапидран", GroupId = ep101.Id });
                db.Students.Add(new Student { Fio = "Ломаченко Василий Олегович", GroupId = ep101.Id });
                db.Students.Add(new Student { Fio = "Порошенко Петр Порошенович", GroupId = ep101.Id });
                db.Students.Add(new Student { Fio = "Майвезер Флойд Майвезерович", GroupId = ep201.Id });
                db.SaveChanges();

                Console.WriteLine("Данные добавлены!!!");
            }
        }
    }
}
