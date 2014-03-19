using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VIdme.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace VIdme.Controllers
{
    public class CandidatesQuery
    {
        public IEnumerable<Candidate> Execute()
        {
            return new List<Candidate>()
            {
                new Candidate()
                {
                    CandidateId = new Guid("9d7b51a9-a0b2-4d26-af8e-1b8fbee2c33c"),
                    Email = "Christian@vidme.com",
                    Name = "Andreas Møller",
                    Image = "Content/Images/Candidates/andreas_moeller.png",
                    Rating = 3,
                },
                new Candidate()
                {
                    CandidateId = new Guid("1b91e5e3-3c8e-428e-abd7-cafe1a576fc4"),
                    Email = "Christina@vidme.com",
                    Name = "Claus Frost",
                    Image = "Content/Images/Candidates/claus_frost.png",
                    Rating = 3,
                },
                new Candidate()
                {
                    CandidateId = new Guid("3dc7c5ec-b84f-4978-bf6d-b7a004a31589"),
                    Email = "HansHenrik@vidme.com",
                    Name = "Johanne Lund",
                    Image = "Content/Images/Candidates/johannelund.png",
                    Rating = 3,
                },
                new Candidate()
                {
                    CandidateId = new Guid("cd73a27d-38c6-496b-a6be-86ea161f5deb"),
                    Email = "Kate@vidme.com",
                    Name = "Mette Holm",
                    Image = "Content/Images/Candidates/metteholm.png",
                    Rating = 5,
                },
				 new Candidate()
                {
                    CandidateId = new Guid("cd73a27d-38c6-496b-a6be-86ea161f5deb"),
                    Email = "Kate@vidme.com",
                    Name = "Peter Simonsen",
                    Image = "Content/Images/Candidates/PeterSimonsen.png",
                    Rating = 5,
                },
				 new Candidate()
                {
                    CandidateId = new Guid("cd73a27d-38c6-496b-a6be-86ea161f5deb"),
                    Email = "Kate@vidme.com",
                    Name = "Peter Johansen",
                    Image = "Content/Images/Candidates/peterjohansen.png",
                    Rating = 5,
                },
            };
        }
    }
}
