﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CafeCMU.Module.BusinessObjects.CafeCMU
{

    public partial class Nhacungcap
    {
        public Nhacungcap(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}