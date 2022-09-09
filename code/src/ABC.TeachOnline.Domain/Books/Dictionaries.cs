using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  SysDictionaries : AuditedAggregateRoot<Guid>
    {
     
        
        /// <summary>
        /// 字典名（中）
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 字典名（英）
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }
        
    }
}