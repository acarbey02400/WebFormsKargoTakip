using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsKargoTakip.DataAccess.Contexts;
using WebFormsKargoTakip.Model;

namespace WebFormsKargoTakip.DataAccess.Repositories
{
    public class UserRepository:RepositoryBase<KargoTakipWebFormsDbContext,User>,IUserRepository
    {
    }
}