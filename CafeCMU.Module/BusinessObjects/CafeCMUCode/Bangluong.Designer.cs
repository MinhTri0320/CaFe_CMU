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

    [DefaultProperty("Bangluong")]
    public partial class Bangluong : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhanvien fNhanvienID;
        [Association(@"BangluongReferencesNhanvien")]
        public Nhanvien NhanvienID
        {
            get { return fNhanvienID; }
            set { SetPropertyValue<Nhanvien>(nameof(NhanvienID), ref fNhanvienID, value); }
        }
        int fNam;
        public int Nam
        {
            get { return fNam; }
            set { SetPropertyValue<int>(nameof(Nam), ref fNam, value); }
        }
        long fThang;
        public long Thang
        {
            get { return fThang; }
            set { SetPropertyValue<long>(nameof(Thang), ref fThang, value); }
        }
        double fSogiolam;
        public double Sogiolam
        {
            get { return fSogiolam; }
            set { SetPropertyValue<double>(nameof(Sogiolam), ref fSogiolam, value); }
        }
        string fLuong;
        public string Luong
        {
            get { return fLuong; }
            set { SetPropertyValue<string>(nameof(Luong), ref fLuong, value); }
        }
    }

}