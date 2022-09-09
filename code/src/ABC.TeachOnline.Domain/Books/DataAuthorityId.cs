using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  DataAuthorityId : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid AuthorityAuthorityId { get; set; }
        
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid DataAuthorityIdAuthorityId { get; set; }
        
    }
}