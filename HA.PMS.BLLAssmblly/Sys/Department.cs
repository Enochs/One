﻿/**
 Version :HaoAi 1.0
 File Name :好爱1.0
 Author:杨洋
 Date:2013.3.12
 Description:部门
 History:实现ICRUDInterface<T> 接口中的方法
 
 Author:杨洋
 date:2013.3.12
 version:好爱1.0
 description:修改描述
 添加部门 的增删改查方法以及分页方法
 
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HA.PMS.DataAssmblly;
using HA.PMS.BLLInterface;
using HA.PMS.BLLAssmblly.PublicTools;
using System.Data.Objects;
using System.Data.EntityClient;
using HA.PMS.ToolsLibrary;

namespace HA.PMS.BLLAssmblly.Sys
{
    public class Department : ICRUDInterface<Sys_Department>
    {
        HA.PMS.DataAssmblly.PMS_WeddingEntities ObjEntity = new PMS_WeddingEntities();

        public int GetDepartmentManager(int DepartmentID)
        {
            var ManagerValue = ObjEntity.Sys_Department.FirstOrDefault(C => C.DepartmentID == DepartmentID).DepartmentManager;
            if (ManagerValue > 0)
            {
                return ManagerValue.Value;
            }
            return -1;
        }


        /// <summary>
        /// 根据部门的ID来进行删除操作
        /// </summary>
        /// <param name="ObjectT">部门实体类</param>
        /// <returns></returns>
        public int Delete(Sys_Department ObjectT)
        {
            if (ObjectT != null)
            {
                //ObjEntity.Sys_Department.Remove(
                //   ObjEntity.Sys_Department.FirstOrDefault(
                //   C => C.DepartmentID == ObjectT.DepartmentID)
                //);

                Sys_Department objDepartment = GetByID(ObjectT.DepartmentID);
                objDepartment.IsDelete = true;
                return ObjEntity.SaveChanges();

            }
            return 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public List<Sys_Department> GetMyManagerDepartment(int EmployeeID)
        {
            using (EntityConnection ObjEntityconn = new EntityConnection("name=PMS_WeddingEntities"))
            {
                List<int> ObjKeyList = new List<int>();
                ObjectContext ObjDataContext = new ObjectContext(ObjEntityconn);
                var MyDepartmentList = ObjEntity.Sys_Department.Where(C => C.DepartmentManager == EmployeeID);
                List<Sys_Department> ObjDepartmentList = new List<Sys_Department>();
                foreach (var ObjDepartment in MyDepartmentList)
                {
                    ObjDepartmentList.AddRange(ObjDataContext.CreateQuery<Sys_Department>("Select VALUE c from PMS_WeddingEntities.Sys_Department as c where c.SortOrder  Like '%" + ObjDepartment.SortOrder + "%' and c.IsDelete=false").ToList<Sys_Department>());
                }
                return ObjDepartmentList;
            }

        }
        /// <summary>
        /// 返回部门表中所有的信息
        /// </summary>
        /// <returns></returns>
        public List<Sys_Department> GetByAll()
        {
            return ObjEntity.Sys_Department.Where(C => C.IsDelete == false && C.SortOrder != null && C.ItemLevel != null).OrderBy(C => C.SortOrder).ToList();
        }

        public IEnumerable<Sys_Department> Where(Func<Sys_Department, bool> predicate)
        {
            return ObjEntity.Sys_Department.Where(predicate);
        }

        /// <summary>
        /// 根据SortOrder获取本部和下级部门
        /// </summary>
        /// <param name="SortOrder"></param>
        /// <returns></returns>
        public List<Sys_Department> GetbyChildenByDepartmetnID(int? DepartmentID)
        {
            int SourceCount = 0;
            var SortOrder = this.GetByID(DepartmentID).SortOrder;
            List<PMSParameters> ObjParameterList = new List<PMSParameters>();
            ObjParameterList.Add("SortOrder", SortOrder, NSqlTypes.LIKE);
            ObjParameterList.Add("IsDelete", false, NSqlTypes.Bit);

            //return PublicDataTools<Sys_Department>.GetDataByParameter(new Sys_Department(), ObjParameterList.ToArray());
            List<Sys_Department> DataList = PublicDataTools<Sys_Department>.GetDataByWhereParameter(ObjParameterList, "SortOrder", 10, 1, out SourceCount);
            return DataList;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public List<Sys_Department> GetByDataSourceDepartment(string Classtype)
        {
            Employee ObjEmployeeBLL = new Employee();
            UserJurisdiction ObjUserJurisdictionBLL = new UserJurisdiction();
            Channel ObjChannelBLL = new Channel();
            var ObjChannelList = ObjChannelBLL.GetbyClassType(Classtype);
            var ObjEmpLoyeeKeyList = ObjUserJurisdictionBLL.GetEmpLoyeeByChannel(ObjChannelList.ChannelID);

            ///获得所有用户
            var ObjEmployeeList = ObjEmployeeBLL.GetByEmpLoyeeKeysList(ObjEmpLoyeeKeyList.ToArray());
            List<int> ObjDepartKeyList = new List<int>();
            foreach (var ObjKey in ObjEmployeeList)
            {
                ObjDepartKeyList.Add(ObjKey.DepartmentID);
            }

            return this.GetByKeysList(ObjDepartKeyList.Distinct().ToArray());

            //var ObjModel = ObjEntity.Sys_Department.FirstOrDefault(C=>C.DepartmentID==DepartmentID);
            //return ObjEntity.Sys_Department.Where(C => C.DataSource == ObjModel.DataSource).ToList();
        }

        /// <summary>
        /// 根据部门ID获取下级部门
        /// </summary>
        /// <param name="SortOrder"></param>
        /// <returns></returns>
        public List<Sys_Department> GetbySublevelByDepartmetnID(int? DepartmentID)
        {
            var query = ObjEntity.Sys_Department.Where(C => C.Parent == DepartmentID && C.IsDelete == false).ToList();

            return query;
        }
        /// <summary>
        /// 根据主键返回单个部门信息
        /// </summary>
        /// <param name="KeyID">主键值</param>
        /// <returns>根据查询之后的结果，如果为空则返回默认实例</returns>
        public Sys_Department GetByID(int? KeyID)
        {
            if (KeyID.HasValue)
            {
                Sys_Department depar = ObjEntity.Sys_Department.FirstOrDefault(
                    C => C.DepartmentID == KeyID);
                if (depar != null)
                {
                    return depar;
                }

            }

            return new Sys_Department();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public string GetFirstSortOrder(int ParentID, int DepartmentID)
        {

            //if (ParentID == 0)
            //{
            //    return (10000 * ObjEntity.FD_QuotedCatgory.Count(C => C.Parent == ParentID) + ObjEntity.FD_QuotedCatgory.Count(C => C.Parent == ParentID) + 1).ToString();
            //}
            //else
            //{
            //    var Parent = ObjEntity.FD_QuotedCatgory.FirstOrDefault(C => C.QCKey == QCKey).Parent;
            //    return int.Parse(ObjEntity.FD_QuotedCatgory.FirstOrDefault(C => C.QCKey == QCKey).SortOrder) + string.Empty + (ObjEntity.FD_QuotedCatgory.Count(C => C.Parent == QCKey) + 1);
            //}
            if (ParentID == 0)
            {
                return (10000 * ObjEntity.Sys_Department.Count(C => C.Parent == ParentID) + ObjEntity.Sys_Department.Count(C => C.Parent == ParentID) + 1).ToString();
            }
            else
            {
                var Parent = ObjEntity.Sys_Department.FirstOrDefault(C => C.DepartmentID == DepartmentID).Parent;
                return int.Parse(ObjEntity.Sys_Department.FirstOrDefault(C => C.DepartmentID == DepartmentID).SortOrder) + string.Empty + (ObjEntity.Sys_Department.Count(C => C.Parent == DepartmentID) + 1);
            }
        }


        public int? GetItemLevel(int ParentDepartmentID)
        {
            if (ParentDepartmentID == 0)
            {
                return 1;
            }
            else
            {
                return ObjEntity.Sys_Department.FirstOrDefault(C => C.DepartmentID == ParentDepartmentID).ItemLevel + 1;
            }
        }
        /// <summary>
        /// 对于部门表的分页操作
        /// </summary>
        /// <param name="PageSize">一页多少条</param>
        /// <param name="PageIndex">当前第几页</param>
        /// <param name="SourceCount">out 输出一共有多少条记录</param>
        /// <returns>返回部门表的集合</returns>
        public List<Sys_Department> GetByIndex(int PageSize, int PageIndex, out int SourceCount)
        {
            SourceCount = ObjEntity.Sys_Department.Count(C => C.IsDelete == false);

            List<Sys_Department> resultList = ObjEntity.Sys_Department.Where(C => C.IsDelete == false && C.SortOrder != null)
                //进行排序功能操作，不然系统会抛出异常
                   .OrderBy(C => C.SortOrder)
                   .Skip(PageSize * (PageIndex - 1)).Take(PageSize).ToList();

            if (resultList.Count == 0)
            {
                resultList = new List<Sys_Department>();
            }
            return resultList;

        }
        /// <summary>
        /// 添加部门信息
        /// </summary>
        /// <param name="ObjectT">部门实体类</param>
        /// <returns>返回新添加部门信息的编号</returns>
        public int Insert(Sys_Department ObjectT)
        {
            if (ObjectT != null)
            {
                ObjEntity.Sys_Department.Add(ObjectT);
                if (ObjEntity.SaveChanges() > 0)
                {
                    return ObjectT.DepartmentID;
                }

            }
            return 0;
        }
        /// <summary>
        /// 根据部门ID，修改某个部门的信息
        /// </summary>
        /// <param name="ObjectT">部门类实体</param>
        /// <returns>返回被修改的某个部门的DepartmentID</returns>
        public int Update(Sys_Department ObjectT)
        {
            if (ObjectT != null)
            {
                if (ObjEntity.SaveChanges() > 0)
                {

                    return ObjectT.DepartmentID;
                }
            }
            return 0;
        }

        /// <summary>
        /// 根据部门ID组
        /// </summary>
        /// <returns></returns>
        public List<Sys_Department> GetByKeysList(int[] ObjKeyList)
        {
            return (from C in ObjEntity.Sys_Department
                    where (ObjKeyList).Contains(C.DepartmentID)
                    select C).Where(C => C.SortOrder != null).ToList();
        }

    }
}
