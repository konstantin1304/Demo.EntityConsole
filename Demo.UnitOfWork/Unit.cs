using Demo.AppContext;
using Demo.Repositories;

namespace Demo.UnitOfWork
{
    public static class Unit
    {
        private static MyAppDbContext _context;

        static Unit()
        {
            _context = new MyAppDbContext("MyAppConnStr");
            DepartmentsRepository = new DepartmentsRepository(_context);
            TeachersRepository = new TeachersRepository(_context);
        }
        
        public static AddressesRepository AddressesRepository { get; }
        public static ClassroomsRepository ClassroomsRepository { get; }
        public static DepartmentsRepository DepartmentsRepository { get; }
        public static GroupsRepository GroupsRepository { get; }
        public static GroupTimetablesRepository GroupTimetablesRepository { get; }
        public static MarksRepository MarksRepository { get; }
        public static PairTimetablesRepository PairTimetablesRepository { get; }
        public static PhonesRepository PhonesRepository { get; }
        public static SpecialitiesRepository SpecialitiesRepository { get; }
        public static StudentsRepository StudentsRepository { get; }
        public static SubjectsRepository SubjectsRepository { get; }
        public static TeachersRepository TeachersRepository { get; }
        public static TeachSubjsRepository TeachSubjsRepository { get; }
        public static TimetablesRepository TimetablesRepository { get; }




}
}
