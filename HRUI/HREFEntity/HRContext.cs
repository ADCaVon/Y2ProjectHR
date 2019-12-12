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

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<EFconfig_file_second_kind> EFconfig_file_second_kind { get; set; }

        public DbSet<EFconfig_file_third_kind> EFconfig_file_third_kind { get; set; }

        public DbSet<EFconfig_question_first_kind> EFconfig_question_first_kind { get; set; }

        public DbSet<EFconfig_question_second_kind> EFconfig_question_second_kind { get; set; }

        public DbSet<EFconfig_public_char> EFconfig_public_char { get; set; }

        public DbSet<EFconfig_primary_key> EFconfig_primary_key { get; set; }

        public DbSet<EFconfig_major_kind> EFconfig_major_kind { get; set; }

        public DbSet<EFconfig_major> EFconfig_major { get; set; }

        public DbSet<EFhuman_file_dig> EFhuman_file_dig { get; set; }

        public DbSet<EFhuman_file> EFhuman_file { get; set; }

        public DbSet<EFsalary_standard_details> EFsalary_standard_details { get; set; }

        public DbSet<EFsalary_standard> EFsalary_standard { get; set; }

        public DbSet<EFbonus> EFbonus { get; set; }

        public DbSet<EFtraining> EFtraining { get; set; }

        public DbSet<EFmajor_change> EFmajor_change { get; set; }

        public DbSet<EFsalary_grant> EFsalary_grant { get; set; }

        public DbSet<EFsalary_grant_details> EFsalary_grant_details { get; set; }

        public DbSet<EFengage_major_release> EFengage_major_release { get; set; }

        public DbSet<EFengage_exam_details> EFengage_exam_details { get; set; }

        public DbSet<EFengage_exam> EFengage_exam { get; set; }

        public DbSet<EFengage_answer> EFengage_answer { get; set; }

        public DbSet<EFengage_answer_details> EFengage_answer_details { get; set; }

        public DbSet<EFengage_subjects> EFengage_subjects { get; set; }

        public DbSet<EFengage_resume> EFengage_resume { get; set; }

        public DbSet<EFengage_interview> EFengage_interview { get; set; }

        public DbSet<EFusers> EFusers { get; set; }

        public DbSet<EFconfig_file_first_kind> EFconfig_file_first_kind { get; set; }
    }
}
