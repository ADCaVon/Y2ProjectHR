using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HREFEntity
{
    public class HRContext:DbContext
    {
        public HRContext():base("name=sql")
        {
            Database.SetInitializer<HRContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<config_file_second_kind> EFconfig_file_second_kind { get; set; }

        public DbSet<config_file_third_kind> EFconfig_file_third_kind { get; set; }

        public DbSet<config_question_first_kind> EFconfig_question_first_kind { get; set; }

        public DbSet<config_question_second_kind> EFconfig_question_second_kind { get; set; }

        public DbSet<config_public_char> EFconfig_public_char { get; set; }

        public DbSet<config_primary_key> EFconfig_primary_key { get; set; }

        public DbSet<config_major_kind> EFconfig_major_kind { get; set; }

        public DbSet<config_major> EFconfig_major { get; set; }

        public DbSet<human_file_dig> EFhuman_file_dig { get; set; }

        public DbSet<human_file> EFhuman_file { get; set; }

        public DbSet<salary_standard_details> EFsalary_standard_details { get; set; }

        public DbSet<salary_standard> EFsalary_standard { get; set; }

        public DbSet<bonus> EFbonus { get; set; }

        public DbSet<training> EFtraining { get; set; }

        public DbSet<major_change> EFmajor_change { get; set; }

        public DbSet<salary_grant> EFsalary_grant { get; set; }

        public DbSet<salary_grant_details> EFsalary_grant_details { get; set; }

        public DbSet<engage_major_release> EFengage_major_release { get; set; }

        public DbSet<engage_exam_details> EFengage_exam_details { get; set; }

        public DbSet<engage_exam> EFengage_exam { get; set; }

        public DbSet<engage_answer> EFengage_answer { get; set; }

        public DbSet<engage_answer_details> EFengage_answer_details { get; set; }

        public DbSet<engage_subjects> EFengage_subjects { get; set; }

        public DbSet<engage_resume> EFengage_resume { get; set; }

        public DbSet<engage_interview> EFengage_interview { get; set; }

        public DbSet<users> EFusers { get; set; }

        public DbSet<config_file_first_kind> EFconfig_file_first_kind { get; set; }
    }
}
