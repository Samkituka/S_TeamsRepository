using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDatabase.DataAccess.EF.Context;
using MyDatabase.DataAccess.EF.Models;
using MyDatabase.DataAccess.EF.Repositories;

namespace MyDatabaseWebApps.Models
{
    public class SoccerViewModel
    {
        private SoccerRepository _repo;
        public List<Soccer> SoccerList { get; set; }
        public Soccer CurrentSoccer { get; set; }
        public bool IsActionSuccess { get; set; }
        public string ActionMessage { get; set; }


        public SoccerViewModel(MydatabaseContext context)
        {
            _repo = new SoccerRepository(context);
            SoccerList =  GetAllSoccer();
            CurrentSoccer = SoccerList.FirstOrDefault();
        }


        public SoccerViewModel(MydatabaseContext context, int SoccerId)
        {
            _repo = new SoccerRepository(context);

            SoccerList = GetAllSoccer();

            if (SoccerId > 0)
            {
                CurrentSoccer = GetSoccer(SoccerId);
            }
            else
            {
                CurrentSoccer = new Soccer();
            }

        }

        public void SaveSoccer(Soccer soccer)
        {
            if (soccer.SoccerId > 0)
            {
                _repo.Update(soccer);
            }
            else
            {
                soccer.SoccerId = _repo.Create(soccer);
            }

            SoccerList = GetAllSoccer();
            CurrentSoccer = GetSoccer(soccer.SoccerId);
        }
    
       public void RemoveSoccer(int SoccerId)
       {

        _repo.Delete(SoccerId);
        SoccerList = GetAllSoccer();
        CurrentSoccer = SoccerList.FirstOrDefault();
       }

       public List<Soccer> GetAllSoccer()
       {
        return _repo.GetAllSoccer();
       }

        public Soccer GetSoccer(int SoccerId)
        {
        return _repo.GetSoccerById(SoccerId);
        }
    }
}
