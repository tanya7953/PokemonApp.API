using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Contracts
{

    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonOwner> PokemonOwner { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
