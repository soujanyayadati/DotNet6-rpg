using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet6_rpg.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt  { get; set; }
        //This was we are able to select all characters of a particular user
        //one to many relationship
        public List<Character>? Characters { get; set; }


    }
}