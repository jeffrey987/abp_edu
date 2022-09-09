using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  BaseMenuBtns : AuditedAggregateRoot<Guid>
    {
       
        /// <summary>
        /// 按钮关键key
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Desc { get; set; }
        
        /// <summary>
        /// 菜单ID
        /// </summary>
        public Guid  BaseMenuId { get; set; }
        
    }
}