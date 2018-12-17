namespace RSTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyrequistion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requisitions", "SigningDateOfDivisionHead", c => c.DateTime(nullable: false));
            AddColumn("dbo.Requisitions", "SubmissionDateOfReuisitionToHR", c => c.DateTime(nullable: false));
            AddColumn("dbo.Requisitions", "ApprovalDateOfCEO", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requisitions", "ApprovalDateOfCEO");
            DropColumn("dbo.Requisitions", "SubmissionDateOfReuisitionToHR");
            DropColumn("dbo.Requisitions", "SigningDateOfDivisionHead");
        }
    }
}
