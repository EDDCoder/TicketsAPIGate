﻿namespace EngineContracts.Logging
{
    public class ResultInfo
    {
        public readonly string MethodName;
        public readonly string Message;
        public readonly Exception Exception;
        public readonly bool Success;

        public ResultInfo(string methodName, string message = null, Exception exception = null, bool success = true)
        {
            MethodName = methodName;
            Message = message;
            Exception = exception;
            Success = success;
        }
    }
}
