namespace RSTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyCircular3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Circulars", "CircularEndDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "SendCVToHiringManagerDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "SendCVToHRDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "ScheduleAptitudeTestDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "ConductAptitudeTestDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "ConductTechnicalTestDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "FinalInterviewSelectionDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "ConductFinalInterviewDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "ReferenceCheckDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "FinalMeetingWithCEODate", c => c.DateTime());
            AddColumn("dbo.Circulars", "MedicalTestDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "JoiningLetterDate", c => c.DateTime());
            DropColumn("dbo.Circulars", "WrittentestDate");
            DropColumn("dbo.Circulars", "VivaDate");
            DropColumn("dbo.Circulars", "FinalMeetingWithCEO");
            DropColumn("dbo.Circulars", "ALIssueDate");
            DropColumn("dbo.Circulars", "DateOfJoining");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Circulars", "DateOfJoining", c => c.DateTime());
            AddColumn("dbo.Circulars", "ALIssueDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "FinalMeetingWithCEO", c => c.String());
            AddColumn("dbo.Circulars", "VivaDate", c => c.DateTime());
            AddColumn("dbo.Circulars", "WrittentestDate", c => c.DateTime());
            DropColumn("dbo.Circulars", "JoiningLetterDate");
            DropColumn("dbo.Circulars", "MedicalTestDate");
            DropColumn("dbo.Circulars", "FinalMeetingWithCEODate");
            DropColumn("dbo.Circulars", "ReferenceCheckDate");
            DropColumn("dbo.Circulars", "ConductFinalInterviewDate");
            DropColumn("dbo.Circulars", "FinalInterviewSelectionDate");
            DropColumn("dbo.Circulars", "ConductTechnicalTestDate");
            DropColumn("dbo.Circulars", "ConductAptitudeTestDate");
            DropColumn("dbo.Circulars", "ScheduleAptitudeTestDate");
            DropColumn("dbo.Circulars", "SendCVToHRDate");
            DropColumn("dbo.Circulars", "SendCVToHiringManagerDate");
            DropColumn("dbo.Circulars", "CircularEndDate");
        }
    }
}
