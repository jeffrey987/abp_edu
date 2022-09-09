using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  Authorities : AuditedAggregateRoot<Guid>
    {
     
        
        /// <summary>
        /// 角色ID
        /// </summary>
        public  string AuthorityId { get; set; }
        
        /// <summary>
        /// 角色名
        /// </summary>
        public string AuthorityName { get; set; }
        
        /// <summary>
        /// 父角色ID
        /// </summary>
        public string ParentId { get; set; }
        
        /// <summary>
        /// 默认菜单
        /// </summary>
        public string DefaultRouter { get; set; }
        
    }
}