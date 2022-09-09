using System;
using Volo.Abp.Domain.Entities.Auditing;

/*
 * @author : http://www.chiner.com.cn
 * @date : 2022-9-6
 * @desc : 
 */
namespace ABC.TeachOnline.Books
{
    public class  SysDictionaryDetails : AuditedAggregateRoot<Guid>
    {

        
        /// <summary>
        /// 展示值
        /// </summary>
        public string Label { get; set; }
        
        /// <summary>
        /// 字典值
        /// </summary>
        public int Value { get; set; }
        
        /// <summary>
        /// 启用状态
        /// </summary>
        public int Status { get; set; }
        
        /// <summary>
        /// 排序标记
        /// </summary>
        public int Sort { get; set; }
        
        /// <summary>
        /// 关联标记
        /// </summary>
        public Guid  DictionaryId { get; set; }
        
    }
}