using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.DAL.Migrations
{
    public partial class candidatevotesview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var view = @" Create View [dbo].[CandidateVotes] AS
                        select c.Id, c.Name, c.Bio, c.Anime, c.ProfilePhoto, COUNT(v.id) as Votes from 
                        Candidates c LEFT JOIN
                        Votes v on c.id = v.CandidateId
                        group by  c.Id, c.Name, c.Bio, c.Anime, c.ProfilePhoto";

            migrationBuilder.Sql(view);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop view [dbo].[CandidateVotes]");
        }
    }
}
