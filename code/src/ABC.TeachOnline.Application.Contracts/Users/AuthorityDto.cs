using System;
using Volo.Abp.Application.Dtos;

namespace ABC.TeachOnline.Dtos
{
    public class AuthorityDto:AuditedEntityDto<Guid>
    {
        /// <summary>
           /// 角色ID
           /// </summary>
        public string AuthorityId { get; set; }

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