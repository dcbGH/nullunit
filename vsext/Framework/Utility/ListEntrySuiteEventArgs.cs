﻿// Copyright (c) 2011, Jonathan Clark
// All rights reserved.
//
// This software is licensed under the two-clause Simplified BSD License.
// The text of this license is available from:
// http://www.opensource.org/licenses/bsd-license.php

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullUnit.Framework.Utility
{
    public class ListEntrySuiteEventArgs : EventArgs
    {
        public string Suite { get; private set; }
        public string Filename { get; private set; }
        public int LineNumber { get; private set; }

        public ListEntrySuiteEventArgs(string Suite, string Filename, int LineNumber)
        {
            this.Suite = Suite;
            this.Filename = Filename;
            this.LineNumber = LineNumber;
        }
    }
}