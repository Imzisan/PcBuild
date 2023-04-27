using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ModeratorRepo : Repo, IRepo<Moderator, string, Moderator>,IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data =db.Moderators.FirstOrDefault(m=>m.UserName == username && m.Password == password);   
            if (data != null)
                return true;
            return false;
                    
        }

        public Moderator Create(Moderator obj)
        {
            db.Moderators.Add(obj);
            if (db.SaveChanges() > 0) return obj; else return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id); db.Moderators.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Moderator> Read()
        {
            return db.Moderators.ToList();

        }

        public Moderator Read(string id)
        {
            return db.Moderators.Find(id);
        }

        public Moderator Update(Moderator Obj)
        {
            var ex = Read(Obj.UserName);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0) return Obj;
            else return null;
        }
    }
}
