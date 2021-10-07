using System.Data.Entity;

namespace TaskMasterEF.Model
{
   class TaskMasterDBContext : DbContext
   {

      public DbSet<Status> Statuses { get; set; }

      public DbSet<Task> Tasks { get; set; }

   }//class
}//namespace
