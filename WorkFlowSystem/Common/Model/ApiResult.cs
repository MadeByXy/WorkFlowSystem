using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Api通用返回结果
    /// </summary>
    /// <typeparam name="T">obj类型</typeparam>
    /// <typeparam name="V">rows类型</typeparam>
    public class ApiResult<T, V>
    {
        /// <summary>
        /// 返回请求是否成功
        /// </summary>
        public bool success { get; set; } = true;

        /// <summary>
        /// 返回结果信息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 单项数据返回
        /// </summary>
        public T obj { get; set; }

        /// <summary>
        /// 多项数据返回
        /// </summary>
        public IEnumerable<V> rows { get; set; }

        /// <summary>
        /// 数据数量
        /// </summary>
        public int total { get; set; } = 0;
    }
}
