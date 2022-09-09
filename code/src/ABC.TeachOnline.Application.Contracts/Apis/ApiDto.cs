using System;
using Volo.Abp.Application.Dtos;

namespace ABC.TeachOnline
{
    public class ApiDto:AuditedEntityDto<Guid>
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