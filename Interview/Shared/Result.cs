using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Shared
{
    public interface IResult
    {
        bool IsSuccess { get; }
        bool IsFailure { get; }
        string Message { get; }
    }
    public interface IValue<out T>
    {
        T Data { get; }
    }
    public class Result:IResult
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public string Message { get; }

        protected Result(bool success,string message)
        {
            IsSuccess = success;
            Message = message;
        }

        public static Result Ok() => new Result(true,string.Empty);
        public static Result Fail(string message) => new Result(false,message);
    }
    public class Result<T> : IResult,IValue<T>
    {
        public T Data { get; set; }

        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;

        public string Message { get; }

        private Result(bool success,T data,string message)
        {
            IsSuccess = success;
            Message = message;
            Data = data;
        }
        public static Result<T> Ok(T data) => new Result<T>(true, data, string.Empty);
     

        public static implicit operator Result(Result<T> result)
        => result.IsSuccess ?
                Result.Ok() :
                Result.Fail(result.Message);

        public static implicit operator Result<T>(Result result)
        => result.IsSuccess ?
                Result.Ok() :
                Result.Fail(result.Message);
    }
}
