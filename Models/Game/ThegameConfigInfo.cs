
using System;
using PublicClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Serializable]
    [Table("gameConfig")]
    [ModelAttribute("gameConfig", "")]
    public class ThegameConfigInfo : BaseMODEL
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


        private string _congfigname;
        /// <summary>
        /// 选项名称
        /// </summary>
        [ModelAttribute(128,0,false,"","选项名称")]
        
        public string congfigname
        {
            get { return _congfigname; }
            set { _congfigname = value; }
        }


        private string _configtype;
        /// <summary>
        /// 数据类型
        /// </summary>
        [ModelAttribute(128,0,false,"","数据类型")]
        
        public string configtype
        {
            get { return _configtype; }
            set { _configtype = value; }
        }


        private string _configvalue;
        /// <summary>
        /// 选项值
        /// </summary>
        [ModelAttribute(128,0,false,"","选项值")]
        
        public string configvalue
        {
            get { return _configvalue; }
            set { _configvalue = value; }
        }


        private int? _gameModelID;
        /// <summary>
        /// 对应模版ID
        /// </summary>
        [ModelAttribute(4,0,false,"","对应模版ID")]
        
        public int? gameModelID
        {
            get { return _gameModelID; }
            set { _gameModelID = value; }
        }


        /// <summary>
        /// 数据枚举
        /// </summary>
        public enum QueryItem
        {
           ID , congfigname , configtype , configvalue , gameModelID 
        }
    }
}

