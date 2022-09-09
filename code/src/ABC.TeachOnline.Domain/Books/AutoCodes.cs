using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  AutoCodes : AuditedAggregateRoot<Guid>
    {
        
        
        /// <summary>
        /// 包名
        /// </summary>
        public string PackageName { get; set; }
        
        /// <summary>
        /// 展示名
        /// </summary>
        public string Label { get; set; }
        
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }
        
    }
}