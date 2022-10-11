using System;
using Volo.Abp.Application.Dtos;

namespace ABC.TeachOnline.Dtos
{
    public class UserDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// UUID
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        ///名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 用户侧边主题
        /// </summary>
        public string SideMode { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeaderImg { get; set; }
        /// <summary>
        /// 基础颜色
        /// </summary>
        public string BaseColor { get; set; }
        /// <summary>
        /// 活跃颜色
        /// </summary>
        public string ActiveColor { get; set; }
        /// <summary>
        /// 用户角色ID
        /// </summary>
        public Guid AuthorityId { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Email { get; set; }


        public AuthorityDto Authority { get; set; }
    }
}