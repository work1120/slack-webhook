using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlackWebhook.Domain.Models.Entity
{
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        static public UserEntity Create(string name, string password)
        {
            return new UserEntity{
                Name = name,
                Password = password
            };
        }
    }
}
