using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EAS.Data;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;

namespace TService.Entities
{
   /// <summary>
   /// 数据上下文。
   /// </summary>
   public class DbEntities:DataContext
   {
        #region 字段定义

        private DataEntityQuery<tbl_Requirement> m_tbl_Requirements;
        private DataEntityQuery<tbl_User> m_tbl_Users;
        private DataEntityQuery<tbl_RequirementDetail> m_tbl_RequirementDetails;
        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        public DbEntities()
        {
        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dbProvider">数据库访问程序提供者。</param>
        public DbEntities(IDbProvider dbProvider)
            : base(dbProvider)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        public DbEntities(IDataAccessor dataAccessor)
            : base(dataAccessor)
        {

        }

        /// <summary>
        /// 初始化DbEntities对象实例。
        /// </summary>
        /// <param name="dataAccessor">数据访问器。</param>
        /// <param name="ormAccessor">Orm访问器。</param>
        public DbEntities(IDataAccessor dataAccessor, IOrmAccessor ormAccessor)
            : base(dataAccessor, ormAccessor)
        {

        }

        #endregion

        #region 查询定义

        /// <summary>
        /// 需求项目。
        /// </summary>
        public DataEntityQuery<tbl_Requirement> tbl_Requirements
        {
            get
            {
                if (this.m_tbl_Requirements == null)
                {
                    this.m_tbl_Requirements = base.CreateQuery<tbl_Requirement>();
                }
                return this.m_tbl_Requirements;
            }
        }

        /// <summary>
        /// 用户表。
        /// </summary>
        public DataEntityQuery<tbl_User> tbl_Users
        {
            get
            {
                if (this.m_tbl_Users == null)
                {
                    this.m_tbl_Users = base.CreateQuery<tbl_User>();
                }
                return this.m_tbl_Users;
            }
        }

        /// <summary>
        /// 需求明细。
        /// </summary>
        public DataEntityQuery<tbl_RequirementDetail> tbl_RequirementDetails
        {
            get
            {
                if (this.m_tbl_RequirementDetails == null)
                {
                    this.m_tbl_RequirementDetails = base.CreateQuery<tbl_RequirementDetail>();
                }
                return this.m_tbl_RequirementDetails;
            }
        }


        #endregion

   }
}
