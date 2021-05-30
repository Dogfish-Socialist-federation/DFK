using System;
using System.Collections.Generic;

namespace CommonUtility
{
    public static class CommonUtility 
    {
        /// <summary>
        /// 通过给定条件寻找数组中满足条件的元素
        /// </summary>
        /// <param name="array"></param>
        /// <param name="condition"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T FindByCondition<T>(this T[] array, Func<T, bool> condition)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (condition(array[i]))
                {
                    return array[i];
                }
            }
            return default;
        }
    }

}
