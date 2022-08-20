using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Assignment_1.Models;

namespace Assignment_1.Models
{
    public class MatchDB
    {
        public List<FOOTBALL_LEAGUE> JapanMatchDetails()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MatchDBcontext"].ConnectionString))
            {
                List<FOOTBALL_LEAGUE> japanmatchlist = new List<FOOTBALL_LEAGUE>();
                SqlCommand cmd = new SqlCommand("JapanMatchDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    japanmatchlist.Add(
                        new FOOTBALL_LEAGUE
                        {
                            MatchID = Convert.ToInt32(dr["MatchID"]),
                            TeamName1 = Convert.ToString(dr["TeamName1"]),
                            TeamName2 = Convert.ToString(dr["TeamName2"]),
                            WinningTeam = Convert.ToString(dr["WinningTeam"]),
                            Status = Convert.ToString(dr["Status"]),
                            points = Convert.ToInt32(dr["Points"])
                        });

                }
                return japanmatchlist;

            }
        }
        public List<FOOTBALL_LEAGUE> WinningMatchDetails()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MatchDBcontext"].ConnectionString))
            {
                List<FOOTBALL_LEAGUE> winninglist = new List<FOOTBALL_LEAGUE>();
                SqlCommand cmd = new SqlCommand("WonMatchDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    winninglist.Add(
                        new FOOTBALL_LEAGUE
                        {
                            MatchID = Convert.ToInt32(dr["MatchID"]),
                            TeamName1 = Convert.ToString(dr["TeamName1"]),
                            TeamName2 = Convert.ToString(dr["TeamName2"]),
                            WinningTeam = Convert.ToString(dr["WinningTeam"]),
                            Status = Convert.ToString(dr["Status"]),
                            points = Convert.ToInt32(dr["Points"])
                        });

                }
                return winninglist;

            }
        }

        public List<FOOTBALL_LEAGUE> GetMatchdetails()
        {
            using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MatchDBcontext"].ConnectionString))
            {
                List<FOOTBALL_LEAGUE> MatchDetails= new List<FOOTBALL_LEAGUE>();
                SqlCommand cmd = new SqlCommand("select * from FOOTBALL_LEAGUE", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    MatchDetails.Add(
                        new FOOTBALL_LEAGUE
                        {
                            MatchID = Convert.ToInt32(dr["MatchID"]),
                            TeamName1 = Convert.ToString(dr["TeamName1"]),
                            TeamName2= Convert.ToString(dr["TeamName2"]),
                            WinningTeam = Convert.ToString(dr["WinningTeam"]),
                            Status = Convert.ToString(dr["Status"]),
                            points = Convert.ToInt32(dr["Points"])
                        });
                 
                }
                return MatchDetails;

            }
        }
        public bool AddMatchDetails(FOOTBALL_LEAGUE Match)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MatchDBcontext"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertMatchdetails",con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@id",Match.MatchID);
                cmd.Parameters.AddWithValue("@team1", Match.TeamName1);
                cmd.Parameters.AddWithValue("@team2",Match.TeamName2);
                cmd.Parameters.AddWithValue("@status",Match.Status);
                cmd.Parameters.AddWithValue("@winningteam",Match.WinningTeam);
                cmd.Parameters.AddWithValue("@points",Match.points);

                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                    return true;
                else
                    return false;
            }

        }


    }
}