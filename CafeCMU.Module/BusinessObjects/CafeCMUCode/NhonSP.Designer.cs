﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CafeCMU.Module.BusinessObjects.CafeCMU
{

    [DefaultProperty("Nhom")]
    public partial class NhonSP : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fTennhom;
        [Size(50)]
        public string Tennhom
        {
            get { return fTennhom; }
            set { SetPropertyValue<string>(nameof(Tennhom), ref fTennhom, value); }
        }
        string fPhanloai;
        public string Phanloai
        {
            get { return fPhanloai; }
            set { SetPropertyValue<string>(nameof(Phanloai), ref fPhanloai, value); }
        }
        [Association(@"SanphamReferencesNhonSP"), Aggregated]
        public XPCollection<Sanpham> Sanphams { get { return GetCollection<Sanpham>(nameof(Sanphams)); } }
    }

}