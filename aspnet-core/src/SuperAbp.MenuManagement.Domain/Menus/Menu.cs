using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SuperAbp.MenuManagement.Menus
{
    public class Menu : FullAuditedEntity<Guid>
    {
        protected Menu()
        {
        }

        public Menu(Guid id) : base(id)
        {
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 路由
        /// </summary>
        public string Route { get; set; }

        public string Key { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        public bool Group { get; set; }

        /// <summary>
        /// 在Breadcrumb隐藏
        /// </summary>
        public bool HideInBreadcrumb { get; set; }

        public Guid? ParentId { get; set; }

        public virtual Menu Parent { get; set; }
    }
}