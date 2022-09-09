using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  AuthorityMenus : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid BaseMenuId { get; set; }
        
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid  AuthorityAuthorityId { get; set; }
        
    }
}