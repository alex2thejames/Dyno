using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace Dyno.Models
{
    public class Topic
    {
        [Key]
        public int TopicId {get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 characters or longer!")]
        public string TopicName {get;set;}
        
        public User CreatedBy {get;set;}

        public List<Interest> Interests {get;set;}
    }
}