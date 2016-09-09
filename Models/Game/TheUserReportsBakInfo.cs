
using System;
using PublicClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Serializable]
    [Table("UserReportsBak")]
    [ModelAttribute("UserReportsBak", "")]
    public class TheUserReportsBakInfo : BaseMODEL
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


        private string _username;
        /// <summary>
        /// 玩家名称
        /// </summary>
        [ModelAttribute(128,0,false,"","玩家名称")]
        
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }


        private int? _days;
        /// <summary>
        /// 游戏天数0表示游戏开始前的期初设置内容
        /// </summary>
        [ModelAttribute(4,0,false,"","游戏天数0表示游戏开始前的期初设置内容")]
        
        public int? days
        {
            get { return _days; }
            set { _days = value; }
        }


        private int? _sysSale;
        /// <summary>
        /// 系统随机销量
        /// </summary>
        [ModelAttribute(4,0,false,"","系统随机销量")]
        
        public int? sysSale
        {
            get { return _sysSale; }
            set { _sysSale = value; }
        }


        private int? _sysTrans;
        /// <summary>
        /// 系统随机运输
        /// </summary>
        [ModelAttribute(4,0,false,"","系统随机运输")]
        
        public int? sysTrans
        {
            get { return _sysTrans; }
            set { _sysTrans = value; }
        }


        private int? _userStock;
        /// <summary>
        /// 用户仓库
        /// </summary>
        [ModelAttribute(4,0,false,"","用户仓库")]
        
        public int? userStock
        {
            get { return _userStock; }
            set { _userStock = value; }
        }


        private int? _stage1;
        /// <summary>
        /// 驿站1库存
        /// </summary>
        [ModelAttribute(4,0,false,"","驿站1库存")]
        
        public int? stage1
        {
            get { return _stage1; }
            set { _stage1 = value; }
        }


        private int? _stage5;
        /// <summary>
        /// 驿站5库存
        /// </summary>
        [ModelAttribute(4,0,false,"","驿站5库存")]
        
        public int? stage5
        {
            get { return _stage5; }
            set { _stage5 = value; }
        }


        private int? _stage3;
        /// <summary>
        /// 驿站3库存
        /// </summary>
        [ModelAttribute(4,0,false,"","驿站3库存")]
        
        public int? stage3
        {
            get { return _stage3; }
            set { _stage3 = value; }
        }


        private int? _stage2;
        /// <summary>
        /// 驿站2库存
        /// </summary>
        [ModelAttribute(4,0,false,"","驿站2库存")]
        
        public int? stage2
        {
            get { return _stage2; }
            set { _stage2 = value; }
        }


        private int? _stage4;
        /// <summary>
        /// 驿站4库存
        /// </summary>
        [ModelAttribute(4,0,false,"","驿站4库存")]
        
        public int? stage4
        {
            get { return _stage4; }
            set { _stage4 = value; }
        }


        private int? _orderQty;
        /// <summary>
        /// 采购数量
        /// </summary>
        [ModelAttribute(4,0,false,"","采购数量")]
        
        public int? orderQty
        {
            get { return _orderQty; }
            set { _orderQty = value; }
        }


        private int? _realSale;
        /// <summary>
        /// 实际销售量
        /// </summary>
        [ModelAttribute(4,0,false,"","实际销售量")]
        
        public int? realSale
        {
            get { return _realSale; }
            set { _realSale = value; }
        }


        private int? _isPunish;
        /// <summary>
        /// 是否惩罚
        /// </summary>
        [ModelAttribute(4,0,false,"","是否惩罚")]
        
        public int? isPunish
        {
            get { return _isPunish; }
            set { _isPunish = value; }
        }


        private int? _transid;
        /// <summary>
        /// 运输商id
        /// </summary>
        [ModelAttribute(4,0,false,"","运输商id")]
        
        public int? transid
        {
            get { return _transid; }
            set { _transid = value; }
        }


        /// <summary>
        /// 数据枚举
        /// </summary>
        public enum QueryItem
        {
           ID , gamename , username , days , sysSale , sysTrans , userStock , stage1 , stage5 , stage3 , stage2 , stage4 , orderQty , realSale , isPunish , transid 
        }
    }
}

