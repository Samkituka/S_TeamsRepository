using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDatabase.DataAccess.EF.Context;
using MyDatabase.DataAccess.EF.Models;

namespace MyDatabase.DataAccess.EF.Repositories
{
    public class SoccerRepository
    {
        private MydatabaseContext _dbContext;

        public SoccerRepository (MydatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
     public SoccerRepository ()
        {

        }
        public int Create ( Soccer soccer  )
        {
            _dbContext.Add(soccer);
            _dbContext.SaveChanges();
            return soccer.SoccerId;
        }

        public int Update (Soccer soccer )
        {
            Soccer existingsoccer = _dbContext.Soccers.Find(soccer.SoccerId);
            
                existingsoccer.SoccerId = soccer.SoccerId;
                existingsoccer.SoccerTeams = soccer.SoccerTeams;
                existingsoccer.BestTeamPlayer = soccer.BestTeamPlayer;
                existingsoccer.GamesPlayed = soccer.GamesPlayed;
                existingsoccer.GamesWon = soccer.GamesWon;
                existingsoccer.GamesLost = soccer.GamesLost;
                existingsoccer.DatePlayed = existingsoccer.DatePlayed;

                _dbContext.SaveChanges();
                return existingsoccer.SoccerId;

            
        }
        public bool Delete (int SoccerId)
        {
            Soccer soccer = _dbContext.Soccers.Find(SoccerId);
            _dbContext.Remove(soccer);
            _dbContext.SaveChanges();
            return true;
        }

        public List <Soccer> GetAllSoccer()
        {
           List<Soccer> SoccerList = _dbContext.Soccers.ToList();
           return SoccerList;
        }

        public Soccer GetSoccerById (int SoccerId)
        {
            Soccer soccer = _dbContext.Soccers.Find(SoccerId);
            return soccer;
        }
   
    }


}
