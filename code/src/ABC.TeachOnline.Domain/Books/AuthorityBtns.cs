using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  AuthorityBtns : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid AuthorityId { get; set; }
        
        /// <summary>
        /// 菜单ID
        /// </summary>
        public Guid MenuId { get; set; }
        
        /// <summary>
        /// 菜单按钮ID
        /// </summary>
        public Guid BaseMenuBtnId { get; set; }
        
    }
}