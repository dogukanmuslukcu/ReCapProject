﻿using Core.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
    public class DataResult<T> : Result ,IDataResult<T>
    {
        public DataResult(T data,bool success,string message ):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data ,bool success):base(success)
        {
            Data = Data;
        }
        public T Data { get; }
    }
}
