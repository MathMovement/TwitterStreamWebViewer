﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2/11/2020 12:06:38 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace TwitterStreamWebViewer
{
    public partial class TwitterUser {

        public TwitterUser()
        {
            OnCreated();
        }

        public virtual long ID
        {
            get;
            set;
        }

        public virtual string TwitterUserID
        {
            get;
            set;
        }

        public virtual string TwitterUserJson
        {
            get;
            set;
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
