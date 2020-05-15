﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public interface IPasswordValidator
    {
        public bool Ok(IDataPipe pipe, string password, string confirmation);
    }
}
