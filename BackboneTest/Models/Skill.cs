using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BackboneTest.Models
{
    public class Skill
    {
        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        public int id { get; set; }
    }
}