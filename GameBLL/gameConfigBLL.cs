using DBHelp;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBLL
{
    public class gameConfigBLL : BLLBase<ThegameConfigInfo>
    {
        public List<ThegameConfigInfo> GetListByModelID(int mid)
        {
            query.Where(DBWhereType.AND, ThegameConfigInfo.QueryItem.gameModelID, DBTermType.Equal, mid);
            return query.SelectList("");
        }

        public void AddList(int mid, List<ThegameConfigInfo> list)
        {
            exec.ExecuteSQL("DELETE FROM gameConfig WHERE gameModelID=@MID", new List<DataParameter>() { new DataParameter() { Key = "@MID", Value = mid } });
            foreach (var item in list)
            {
                exec.Add(item);
            }
            exec.DBCommit();
        }
    }
}
