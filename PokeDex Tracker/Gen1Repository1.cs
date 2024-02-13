using System;
using Dapper;
using System.Collections;
using System.Data;
using PokeDex_Tracker.Models;
using MySql.Data.MySqlClient;

namespace PokeDex_Tracker
{
	public class Gen1Repository1 : Igen1Repository
    {
		private readonly IDbConnection _conn;
		public Gen1Repository1(IDbConnection conn)
		{
			_conn = conn;
		}
		public IEnumerable<gen_one> GetAll() 
		{
			return _conn.Query<gen_one>("SELECT * FROM GEN_ONE");
		}
		public gen_one GetOne(int id)
		{
			return _conn.QuerySingle<gen_one>("SELECT * FROM GEN_ONE WHERE DEXID = @id", new { id = id});
		}
	}
}
