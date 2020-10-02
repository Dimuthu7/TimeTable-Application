﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TimeTable_App.Migrations;
using TimeTable_App.Models;

/*
 *      Class Name      -   TimeTableDbContext
 *      Author          -   Kusal Perera
 *      Date            -   14/08/2020
 *      Description     -   Handle the Entity Framework DB Context 
 *      
 *      Version Control
 *          * [Kusal Perera]
 *              Implement the class to handle Entity Framework DB Context and add AppForms DbSet.
 *      
 */

namespace TimeTable_App.Global
{
    public class TimeTableDbContext : DbContext
    {
        public TimeTableDbContext() : base("DBCON") 
        {
            Database.SetInitializer<TimeTableDbContext>(new Configuration());
        }

        public DbSet<AppFormsModel> AppForms { get; set; }
        public DbSet<LecturersFormModel> Lecturers { get; set; }
        public DbSet<FacultyModel> Faculties { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<CenterModel> Centers { get; set; }
        public DbSet<BuildingModel> Buildings { get; set; }
        public DbSet<EmployeeLevelModel> EmployeeLevels { get; set; }
        public DbSet<AppSubFormsModel> AppSubForms { get; set; }
        public DbSet<WorkingDaySubFormModel> WorkingDays { get; set; }
        public DbSet<TimeSlotSubFormModel> TimeSlots { get; set; }
        public DbSet<ProgrammeModel> Programme { get; set; }
        public DbSet<TagsModel> Tags { get; set; }
        public DbSet<ASYModel> ASY { get; set; }
        public DbSet<GroupsModel> Groups { get; set; }
        public DbSet<GroupIDModel> GroupID { get; set; }
        public DbSet<SubGroupIDModel> SubGroupID { get; set; }
        public DbSet<RoomsModel> Rooms { get; set; }
        public DbSet<SubjectsFormModel> Subjects { get; set; }
        public DbSet<NATLectureModel> NATLecture { get; set; }
        public DbSet<RoomsforTimeNotReservedModel> RoomsforTimeNotReserved { get; set; }
        public DbSet<ConsectiveSessionsModel> ConsectiveSessions { get; set; }
        public DbSet<SessionsSubFormModel> Sessions { get; set; }
        public DbSet<NOSModel> NOS { get; set; }
        public DbSet<RoomsWithTagsModal> RoomsWithTags { get; set; }
        public DbSet<RoomsForASubjectModel> RoomsForASubject { get; set; }
        public DbSet<RoomsforaLecturerModel> RoomsforaLecturer { get; set; }
        public DbSet<RoomsforaSubGroupModel> RoomsforaSubGroup { get; set; }
        public DbSet<RoomsforConsectiveSessionModel> RoomsforConsectiveSession { get; set; }
        public DbSet<RoomsforSessionModel> RoomsforSession { get; set; }
        public DbSet<ParallelSessionModel> ParallelSessions { get; set; }
        public DbSet<TimetableSubFormModel> TimeTable { get; set; }
    }
}
