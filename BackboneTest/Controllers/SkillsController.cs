using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackboneTest.Models;

namespace BackboneTest.Controllers
{
    public class SkillsController : ApiController
    {
        static SkillsController()
        {
            skills = new List<Skill>{
                new Skill() { id = 1, title = "Skill1", description = "Desc1" },
                new Skill() { id = 2, title = "Skill2", description = "Desc2" },
                new Skill() { id = 3, title = "Skill3", description = "Desc3" }
            };
        }

        static List<Skill> skills = new List<Skill>();

        static int skillId = 0;

        [HttpGet]
        public IEnumerable<Skill> GetSkills()
        {
            return skills;
        }

        [HttpPut]
        public HttpResponseMessage AddSkill(Skill skill)
        {
            if (ModelState.IsValid)
            {
                skill.id = skillId++;

                skills.Add(skill);

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.ExpectationFailed);
            }
        }
    }
}
