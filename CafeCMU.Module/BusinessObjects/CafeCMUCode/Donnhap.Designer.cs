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

    [DefaultProperty("Donnhap")]
    public partial class Donnhap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Sanpham fSanphamID;
        [Association(@"DonnhapReferencesSanpham")]
        public Sanpham SanphamID
        {
            get { return fSanphamID; }
            set { SetPropertyValue<Sanpham>(nameof(SanphamID), ref fSanphamID, value); }
        }
        string fNhapID;
        public string NhapID
        {
            get { return fNhapID; }
            set { SetPropertyValue<string>(nameof(NhapID), ref fNhapID, value); }
        }
        double fSoluong;
        public double Soluong
        {
            get { return fSoluong; }
            set { SetPropertyValue<double>(nameof(Soluong), ref fSoluong, value); }
        }
        decimal fGiaban;
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"),
DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")]
        public decimal Giaban
        {
            get { return fGiaban; }
            set { SetPropertyValue<decimal>(nameof(Giaban), ref fGiaban, value); }
        }
        [PersistentAlias("ToDecimal([Soluong]) * [Giaban]")]
        public string Thanhtien
        {
            get { return (string)(EvaluateAlias(nameof(Thanhtien))); }
        }
    }

}
