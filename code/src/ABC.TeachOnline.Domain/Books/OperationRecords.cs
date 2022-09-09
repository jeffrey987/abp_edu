using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  OperationRecords : AuditedAggregateRoot<Guid>
    {
      
        /// <summary>
        /// 请求ip
        /// </summary>
        public string Ip { get; set; }
        
        /// <summary>
        /// 请求方法
        /// </summary>
        public string Method { get; set; }
        
        /// <summary>
        /// 请求路径
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// 请求状态
        /// </summary>
        public int Status { get; set; }
        
        /// <summary>
        /// 延迟
        /// </summary>
        public int Latency { get; set; }
        
        /// <summary>
        /// 代理
        /// </summary>
        public string Agent { get; set; }
        
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
        
        /// <summary>
        /// 请求Body
        /// </summary>
        public string Body { get; set; }
        
        /// <summary>
        /// 响应Body
        /// </summary>
        public string Resp { get; set; }
        
        /// <summary>
        /// 用户id
        /// </summary>
        public Guid UserId { get; set; }
        
    }
}