using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject
{
    public interface ILog
    {
        void Info(string msg);
        void Warn(string msg);
    }
}
