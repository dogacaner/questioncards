namespace QuestionCards.PersistenceEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        Answer_Id = c.Int(),
                        QuestionSet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.Answer_Id)
                .ForeignKey("dbo.QuestionSets", t => t.QuestionSet_Id)
                .Index(t => t.Answer_Id)
                .Index(t => t.QuestionSet_Id);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Text = c.String(),
                        IsTrue = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Choices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        IsTrue = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        Answer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.Answer_Id)
                .Index(t => t.Answer_Id);
            
            CreateTable(
                "dbo.QuestionSets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.Int(),
                        LastModifiedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "QuestionSet_Id", "dbo.QuestionSets");
            DropForeignKey("dbo.Questions", "Answer_Id", "dbo.Answers");
            DropForeignKey("dbo.Choices", "Answer_Id", "dbo.Answers");
            DropIndex("dbo.Choices", new[] { "Answer_Id" });
            DropIndex("dbo.Questions", new[] { "QuestionSet_Id" });
            DropIndex("dbo.Questions", new[] { "Answer_Id" });
            DropTable("dbo.QuestionSets");
            DropTable("dbo.Choices");
            DropTable("dbo.Answers");
            DropTable("dbo.Questions");
        }
    }
}
