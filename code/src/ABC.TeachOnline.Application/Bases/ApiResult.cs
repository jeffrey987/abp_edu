namespace ABC.TeachOnline.Bases
{
    public class ApiResult
    {
        public int Code { get; internal set; }
        public object Msg { get; internal set; }
       
    }


    public class ApiResult<T> : ApiResult
    {
        /// <summary>
        /// 接口返回值
        /// </summary>
        public T Data;

    }
}