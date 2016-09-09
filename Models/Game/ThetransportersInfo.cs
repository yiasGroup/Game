
using System;
using PublicClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Serializable]
    [Table("transporters")]
    [ModelAttribute("transporters", "")]
    public class ThetransportersInfo : BaseMODEL
    {
        
        private int? _ID;
        /// <summary>
        /// 
        /// </summary>
        [ModelAttribute(4,"","")]
        [Key]
        public int? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        private string _transporterName;
        /// <summary>
        /// 运输商名称
        /// </summary>
        [ModelAttribute(128,0,false,"","运输商名称")]
        
        public string transporterName
        {
            get { return _transporterName; }
            set { _transporterName = value; }
        }


        private int? _minQty;
        /// <summary>
        /// 最小起运数
        /// </summary>
        [ModelAttribute(4,0,false,"","最小起运数")]
        
        public int? minQty
        {
            get { return _minQty; }
            set { _minQty = value; }
        }


        private int? _transCyc;
        /// <summary>
        /// 运输周期
        /// </summary>
        [ModelAttribute(4,0,false,"","运输周期")]
        
        public int? transCyc
        {
            get { return _transCyc; }
            set { _transCyc = value; }
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


        /// <summary>
        /// 数据枚举
        /// </summary>
        public enum QueryItem
        {
           ID , transporterName , minQty , transCyc , transPrice 
        }
    }
}

