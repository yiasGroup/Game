
using System;
using PublicClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Serializable]
    [Table("Sys_JueSe_YongHu")]
    [ModelAttribute("Sys_JueSe_YongHu", "")]
    public class TheSysJueSeYongHuInfo : BaseMODEL
    {
        
        private int? _jsID;
        /// <summary>
        /// 
        /// </summary>
        [ModelAttribute(4,"","")]
        [Key]
        public int? jsID
        {
            get { return _jsID; }
            set { _jsID = value; }
        }


        private int? _yhID;
        /// <summary>
        /// 
        /// </summary>
        [ModelAttribute(4,"","")]
        [Key]
        public int? yhID
        {
            get { return _yhID; }
            set { _yhID = value; }
        }


        /// <summary>
        /// 数据枚举
        /// </summary>
        public enum QueryItem
        {
           jsID , yhID 
        }
    }
}

