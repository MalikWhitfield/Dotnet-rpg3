using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_rpg3.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Character> Characters { get; set; }
    }

}