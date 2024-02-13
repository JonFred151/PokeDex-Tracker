using System;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;


namespace PokeDex_Tracker.Models
{
    public class gen_one
    {
        public int DexID { get; set; }
        public string pokemon { get; set; }
        public string type { get; set; }
        public string obtainable { get; set; }
        public string method { get; set; }

    }
}
