using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DAL;
using Student.Model;

namespace Student.BLL
{
    class MenuBll
    {
        private readonly MenuDal dal = new MenuDal();

        public IList<MenuMdl> GetMenuList()
        {
            return dal.GetAllMenuList();
        }

        public IList<MenuMdl> GetUserWinMenu(string sOprCode)
        {
            return dal.GetUserWinMenu(sOprCode);
        } 
    }
}
