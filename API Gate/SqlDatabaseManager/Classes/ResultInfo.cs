namespace SqlDatabaseManager.Classes
{
    public class ResultInfo
    {
        public readonly string MethodName;
        public readonly string Message;
        public readonly Exception Exception;
        public readonly bool Success;

        public ResultInfo(string methodName, string message, Exception exception, bool success)
        {
            MethodName = methodName;
            Message = message;
            Exception = exception;
            Success = success;
        }

    }
}
