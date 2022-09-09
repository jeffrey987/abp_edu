using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  Fileds : AuditedAggregateRoot<Guid>
    {
     
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Size { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Thumbnail { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string  Md5 { get; set; }
        
    }
}