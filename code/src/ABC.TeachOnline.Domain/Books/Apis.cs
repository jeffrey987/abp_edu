using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  Apis : AuditedAggregateRoot<Guid>
    {
 
        
        /// <summary>
        /// api路径
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// api中文描述
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// api组
        /// </summary>
        public string ApiGroup { get; set; }
        
        /// <summary>
        /// 方法
        /// </summary>
        public string Method { get; set; }
        
    }
}