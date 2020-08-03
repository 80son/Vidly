namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay As You Go' WHERE ID = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' WHERE ID = 2");
            Sql("Update MembershipTypes Set Name = 'Quarter' WHERE ID = 3");
            Sql("Update MembershipTypes Set Name = 'Annual' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
