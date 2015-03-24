using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TianWei.Utility
{
    public static class EFHelper
    {
        /// <summary>
        /// 扩展查询方法加排序
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="source"></param>
        /// <param name="orderByProperty"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string orderByProperty,
bool desc) where TEntity : class
        {
            string command = desc ? "OrderByDescending" : "OrderBy";
            var type = typeof(TEntity);
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));
            return source.Provider.CreateQuery<TEntity>(resultExpression);
        }

        /// <summary>
        /// 返回排序字段
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expr"></param>
        /// <returns></returns>
        public static string GetPropertyName<T>(Expression<Func<T, object>> expr)
        {
            var rtn = "";
            if (expr.Body is UnaryExpression)
            {
                rtn = ((MemberExpression)((UnaryExpression)expr.Body).Operand).Member.Name;
            }
            else if (expr.Body is MemberExpression)
            {
                rtn = ((MemberExpression)expr.Body).Member.Name;
            }
            else if (expr.Body is ParameterExpression)
            {
                rtn = ((ParameterExpression)expr.Body).Type.Name;
            }
            return rtn;
        }

        public static void NoLockInvokeDB(Action action)
        {
            var transactionOptions = new System.Transactions.TransactionOptions();
            transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted;
            using (var transactionScope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, transactionOptions))
            {
                try
                {
                    action();
                }
                finally
                {
                    transactionScope.Complete();
                }
            }
        }

    }
}
