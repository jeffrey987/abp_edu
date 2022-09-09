using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  AutoCodeHistories : AuditedAggregateRoot<Guid>
    {
     
     
        /// <summary>
        /// 
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(TypeName ="text")]
        public string RequestMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(TypeName = "text")]
        public string AutoCodePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Column(TypeName="text")]
        [Description("zhushi")]
        public string InjectionMeta { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string StructName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string StructCnName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ApiIds { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Flag { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Package { get; set; }
        
    }
}