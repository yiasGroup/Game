
using System;
using PublicClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Serializable]
    [Table("UserGames")]
    [ModelAttribute("UserGames", "")]
    public class TheUserGamesInfo : BaseMODEL
    {
        
        private int? _ID;
        /// <summary>
        /// 主键
        /// </summary>
        [ModelAttribute(4,"","主键")]
        [Key]
        public int? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        private string _gamename;
        /// <summary>
        /// 游戏名称
        /// </summary>
        [ModelAttribute(128,0,false,"","游戏名称")]
        
        public string gamename
        {
            get { return _gamename; }
            set { _gamename = value; }
        }


        private string _UserName;
        /// <summary>
        /// 用户名称
        /// </summary>
        [ModelAttribute(128,0,false,"","用户名称")]
        
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }


        private int? _totalSales;
        /// <summary>
        /// 总销售量
        /// </summary>
        [ModelAttribute(4,0,false,"","总销售量")]
        
        public int? totalSales
        {
            get { return _totalSales; }
            set { _totalSales = value; }
        }


        private decimal? _gop;
        /// <summary>
        /// 毛利润
        /// </summary>
        [ModelAttribute(9,2,false,"","毛利润")]
        
        public decimal? gop
        {
            get { return _gop; }
            set { _gop = value; }
        }


        private int? _failedCount;
        /// <summary>
        /// 未交付次数
        /// </summary>
        [ModelAttribute(4,0,false,"","未交付次数")]
        
        public int? failedCount
        {
            get { return _failedCount; }
            set { _failedCount = value; }
        }


        private decimal? _failedFind;
        /// <summary>
        /// 未交付罚款
        /// </summary>
        [ModelAttribute(9,2,false,"","未交付罚款")]
        
        public decimal? failedFind
        {
            get { return _failedFind; }
            set { _failedFind = value; }
        }


        private int? _stock0day;
        /// <summary>
        /// 期初库存
        /// </summary>
        [ModelAttribute(4,0,false,"","期初库存")]
        
        public int? stock0day
        {
            get { return _stock0day; }
            set { _stock0day = value; }
        }


        private int? _onway0day;
        /// <summary>
        /// 期初在途
        /// </summary>
        [ModelAttribute(4,0,false,"","期初在途")]
        
        public int? onway0day
        {
            get { return _onway0day; }
            set { _onway0day = value; }
        }


        private int? _stockEndDay;
        /// <summary>
        /// 期末库存
        /// </summary>
        [ModelAttribute(4,0,false,"","期末库存")]
        
        public int? stockEndDay
        {
            get { return _stockEndDay; }
            set { _stockEndDay = value; }
        }


        private int? _onwayEndDay;
        /// <summary>
        /// 期末库存
        /// </summary>
        [ModelAttribute(4,0,false,"","期末库存")]
        
        public int? onwayEndDay
        {
            get { return _onwayEndDay; }
            set { _onwayEndDay = value; }
        }


        private int? _orderCount;
        /// <summary>
        /// 总采购数
        /// </summary>
        [ModelAttribute(4,0,false,"","总采购数")]
        
        public int? orderCount
        {
            get { return _orderCount; }
            set { _orderCount = value; }
        }


        private int? _orderQty;
        /// <summary>
        /// 总采购量
        /// </summary>
        [ModelAttribute(4,0,false,"","总采购量")]
        
        public int? orderQty
        {
            get { return _orderQty; }
            set { _orderQty = value; }
        }


        private int? _reciveQty;
        /// <summary>
        /// 收货总量
        /// </summary>
        [ModelAttribute(4,0,false,"","收货总量")]
        
        public int? reciveQty
        {
            get { return _reciveQty; }
            set { _reciveQty = value; }
        }


        private decimal? _transPrice;
        /// <summary>
        /// 运输单价
        /// </summary>
        [ModelAttribute(9,2,false,"","运输单价")]
        
        public decimal? transPrice
        {
            get { return _transPrice; }
            set { _transPrice = value; }
        }


        private decimal? _transCost;
        /// <summary>
        /// 运输成本
        /// </summary>
        [ModelAttribute(9,2,false,"","运输成本")]
        
        public decimal? transCost
        {
            get { return _transCost; }
            set { _transCost = value; }
        }


        private decimal? _totalCost;
        /// <summary>
        /// 总成本
        /// </summary>
        [ModelAttribute(9,2,false,"","总成本")]
        
        public decimal? totalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }


        private decimal? _totalProfit;
        /// <summary>
        /// 总利润
        /// </summary>
        [ModelAttribute(9,2,false,"","总利润")]
        
        public decimal? totalProfit
        {
            get { return _totalProfit; }
            set { _totalProfit = value; }
        }


        private DateTime? _gamedate;
        /// <summary>
        /// 游戏日期
        /// </summary>
        [ModelAttribute(8,3,false,"","游戏日期")]
        
        public DateTime? gamedate
        {
            get { return _gamedate; }
            set { _gamedate = value; }
        }


        /// <summary>
        /// 数据枚举
        /// </summary>
        public enum QueryItem
        {
           ID , gamename , UserName , totalSales , gop , failedCount , failedFind , stock0day , onway0day , stockEndDay , onwayEndDay , orderCount , orderQty , reciveQty , transPrice , transCost , totalCost , totalProfit , gamedate 
        }
    }
}

