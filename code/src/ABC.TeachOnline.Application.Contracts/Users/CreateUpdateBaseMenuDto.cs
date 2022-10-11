using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Dtos
{
    public class  CreateUpdateBaseMenuDto : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int MenuLevel { get; set; }
        
        /// <summary>
        /// 父菜单ID
        /// </summary>
        public string ParentId { get; set; }
        
        /// <summary>
        /// 路由path
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// 路由name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 是否在列表隐藏
        /// </summary>
        public int Hidden { get; set; }
        
        /// <summary>
        /// 对应前端文件路径
        /// </summary>
        public string Component { get; set; }
        
        /// <summary>
        /// 排序标记
        /// </summary>
        public int Sort { get; set; }
        
        /// <summary>
        /// 附加属性
        /// </summary>
        public int KeepAlive { get; set; }
        
        /// <summary>
        /// 附加属性
        /// </summary>
        public int DefaultMenu { get; set; }
        
        /// <summary>
        /// 附加属性
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// 附加属性
        /// </summary>
        public string Icon { get; set; }
        
        /// <summary>
        /// 附加属性
        /// </summary>
        public int CloseTab { get; set; }
        
    }
}