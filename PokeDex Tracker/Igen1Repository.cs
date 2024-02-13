using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using PokeDex_Tracker.Models;
namespace PokeDex_Tracker
{
    public interface Igen1Repository
    {
        public IEnumerable<gen_one> GetAll();
        gen_one GetOne(int id);
    }
}
