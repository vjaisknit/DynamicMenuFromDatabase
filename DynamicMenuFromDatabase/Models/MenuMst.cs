using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicMenuFromDatabase.Models
{
    public class MenuMst
    {
        public MenuMst()
        {
            MenuList = new List<MenuMst>();
        }
        [Key]
        public int ID { get; set; }
        public string MenuText { get; set; }
        public int? PerentID { get; set; }
        public string MenuUrl { get; set; }
        [NotMapped]
       public List<MenuMst> MenuList { get; set; }

        public List<MenuMst> MenuTree(List<MenuMst> menuList,int? parentid )
        {
            return menuList.Where(x => x.PerentID == parentid).Select(
               x=> new MenuMst
               {
                   ID=x.ID,
                   MenuText=x.MenuText,
                   PerentID=x.PerentID,
                   MenuUrl=x.MenuUrl,
                   MenuList=MenuTree(menuList,x.ID)
                   
               }).ToList();
        }

    }
}