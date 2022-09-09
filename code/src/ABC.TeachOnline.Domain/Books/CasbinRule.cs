using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  CasbinRule : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public string PType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string V0 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string V1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string V2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string V3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string V4 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string V5 { get; set; }
        
    }
}