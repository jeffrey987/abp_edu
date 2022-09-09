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
    public class  JwtBlacklists : AuditedAggregateRoot<Guid>
    {

        /// <summary>
        /// jwt
        /// </summary>
        [Column(TypeName = "text")]
        [Description("Jwt")]
        public string Jwt { get; set; }
        
    }
}