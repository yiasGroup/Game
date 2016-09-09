
using System;
using PublicClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Serializable]
    [Table("gameModels")]
    [ModelAttribute("gameModels", "")]
    public class ThegameModelsInfo : BaseMODEL
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


        private string _modelName;
        /// <summary>
        /// 模版名称
        /// </summary>
        [ModelAttribute(128,0,false,"","模版名称")]
        
        public string modelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }


        /// <summary>
        /// 数据枚举
        /// </summary>
        public enum QueryItem
        {
           ID , modelName 
        }
    }
}

