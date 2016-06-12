﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Thêm mới 1 đối tượng
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Update thông tin 1 đối tượng
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Xóa 1 đối tượng
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
        void Delete(int id);

        /// <summary>
        /// Xóa nhiều đối tượng
        /// </summary>
        /// <param name="where">Điều kiện xóa</param>
        void DeleteMulti(Expression<Func<T, bool>> where);

        /// <summary>
        /// Get 1 đối tượng theo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetSingleById(int id);

        /// <summary>
        /// Lấy 1 đối tượng theo điều kiện
        /// </summary>
        /// <param name="expression">Điều kiện</param>
        /// <param name="includes">Các bảng con</param>
        /// <returns></returns>
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        /// <summary>
        /// Lấy toàn bộ
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        IQueryable<T> GetAll(string[] includes = null);

        /// <summary>
        /// Lấy toàn bộ kèm điều kiện
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        /// <summary>
        /// Lấy toàn bộ có phân trang
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="total"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        /// <summary>
        /// Đếm số bản ghi
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> where);

        /// <summary>
        /// Kiểm tra tồn tại
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}