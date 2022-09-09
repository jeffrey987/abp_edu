using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  BaseMenuParameters : AuditedAggregateRoot<Guid>
    {
       
        /// <summary>
        /// 
        /// </summary>
        public Guid BaseMenuId { get; set; }
        
        /// <summary>
        /// 地址栏携带参数为params还是query
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// 地址栏携带参数的key
        /// </summary>
        public string Key { get; set; }
        
        /// <summary>
        /// 地址栏携带参数的值
        /// </summary>
        public string Value { get; set; }
        
    }
}