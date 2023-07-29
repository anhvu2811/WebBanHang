﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom03_LapTrinhWeb.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_THIETBIDIENTU")]
	public partial class QLThietBiDienTuDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHangHoa(HangHoa instance);
    partial void UpdateHangHoa(HangHoa instance);
    partial void DeleteHangHoa(HangHoa instance);
    partial void InsertNhomHang(NhomHang instance);
    partial void UpdateNhomHang(NhomHang instance);
    partial void DeleteNhomHang(NhomHang instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    #endregion
		
		public QLThietBiDienTuDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_THIETBIDIENTUConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLThietBiDienTuDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLThietBiDienTuDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLThietBiDienTuDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLThietBiDienTuDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HangHoa> HangHoas
		{
			get
			{
				return this.GetTable<HangHoa>();
			}
		}
		
		public System.Data.Linq.Table<NhomHang> NhomHangs
		{
			get
			{
				return this.GetTable<NhomHang>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HangHoa")]
	public partial class HangHoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHH;
		
		private System.Nullable<int> _MaNhom;
		
		private string _TenHH;
		
		private string _HinhAnh;
		
		private System.Nullable<double> _Gia;
		
		private string _DonViTinh;
		
		private string _NoiSX;
		
		private EntitySet<HoaDon> _HoaDons;
		
		private EntityRef<NhomHang> _NhomHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHHChanging(int value);
    partial void OnMaHHChanged();
    partial void OnMaNhomChanging(System.Nullable<int> value);
    partial void OnMaNhomChanged();
    partial void OnTenHHChanging(string value);
    partial void OnTenHHChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnGiaChanging(System.Nullable<double> value);
    partial void OnGiaChanged();
    partial void OnDonViTinhChanging(string value);
    partial void OnDonViTinhChanged();
    partial void OnNoiSXChanging(string value);
    partial void OnNoiSXChanged();
    #endregion
		
		public HangHoa()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			this._NhomHang = default(EntityRef<NhomHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHH
		{
			get
			{
				return this._MaHH;
			}
			set
			{
				if ((this._MaHH != value))
				{
					this.OnMaHHChanging(value);
					this.SendPropertyChanging();
					this._MaHH = value;
					this.SendPropertyChanged("MaHH");
					this.OnMaHHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhom", DbType="Int")]
		public System.Nullable<int> MaNhom
		{
			get
			{
				return this._MaNhom;
			}
			set
			{
				if ((this._MaNhom != value))
				{
					if (this._NhomHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhomChanging(value);
					this.SendPropertyChanging();
					this._MaNhom = value;
					this.SendPropertyChanged("MaNhom");
					this.OnMaNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHH", DbType="NVarChar(50)")]
		public string TenHH
		{
			get
			{
				return this._TenHH;
			}
			set
			{
				if ((this._TenHH != value))
				{
					this.OnTenHHChanging(value);
					this.SendPropertyChanging();
					this._TenHH = value;
					this.SendPropertyChanged("TenHH");
					this.OnTenHHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="VarChar(50)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Float")]
		public System.Nullable<double> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonViTinh", DbType="NVarChar(50)")]
		public string DonViTinh
		{
			get
			{
				return this._DonViTinh;
			}
			set
			{
				if ((this._DonViTinh != value))
				{
					this.OnDonViTinhChanging(value);
					this.SendPropertyChanging();
					this._DonViTinh = value;
					this.SendPropertyChanged("DonViTinh");
					this.OnDonViTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiSX", DbType="NVarChar(50)")]
		public string NoiSX
		{
			get
			{
				return this._NoiSX;
			}
			set
			{
				if ((this._NoiSX != value))
				{
					this.OnNoiSXChanging(value);
					this.SendPropertyChanging();
					this._NoiSX = value;
					this.SendPropertyChanged("NoiSX");
					this.OnNoiSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HangHoa_HoaDon", Storage="_HoaDons", ThisKey="MaHH", OtherKey="MaHH")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhomHang_HangHoa", Storage="_NhomHang", ThisKey="MaNhom", OtherKey="MaNhom", IsForeignKey=true)]
		public NhomHang NhomHang
		{
			get
			{
				return this._NhomHang.Entity;
			}
			set
			{
				NhomHang previousValue = this._NhomHang.Entity;
				if (((previousValue != value) 
							|| (this._NhomHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhomHang.Entity = null;
						previousValue.HangHoas.Remove(this);
					}
					this._NhomHang.Entity = value;
					if ((value != null))
					{
						value.HangHoas.Add(this);
						this._MaNhom = value.MaNhom;
					}
					else
					{
						this._MaNhom = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhomHang");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.HangHoa = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.HangHoa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhomHang")]
	public partial class NhomHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNhom;
		
		private string _TenNhom;
		
		private EntitySet<HangHoa> _HangHoas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhomChanging(int value);
    partial void OnMaNhomChanged();
    partial void OnTenNhomChanging(string value);
    partial void OnTenNhomChanged();
    #endregion
		
		public NhomHang()
		{
			this._HangHoas = new EntitySet<HangHoa>(new Action<HangHoa>(this.attach_HangHoas), new Action<HangHoa>(this.detach_HangHoas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhom", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaNhom
		{
			get
			{
				return this._MaNhom;
			}
			set
			{
				if ((this._MaNhom != value))
				{
					this.OnMaNhomChanging(value);
					this.SendPropertyChanging();
					this._MaNhom = value;
					this.SendPropertyChanged("MaNhom");
					this.OnMaNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhom", DbType="NVarChar(50)")]
		public string TenNhom
		{
			get
			{
				return this._TenNhom;
			}
			set
			{
				if ((this._TenNhom != value))
				{
					this.OnTenNhomChanging(value);
					this.SendPropertyChanging();
					this._TenNhom = value;
					this.SendPropertyChanged("TenNhom");
					this.OnTenNhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhomHang_HangHoa", Storage="_HangHoas", ThisKey="MaNhom", OtherKey="MaNhom")]
		public EntitySet<HangHoa> HangHoas
		{
			get
			{
				return this._HangHoas;
			}
			set
			{
				this._HangHoas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HangHoas(HangHoa entity)
		{
			this.SendPropertyChanging();
			entity.NhomHang = this;
		}
		
		private void detach_HangHoas(HangHoa entity)
		{
			this.SendPropertyChanging();
			entity.NhomHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private string _TenHD;
		
		private string _MaNV;
		
		private System.Nullable<int> _MaHH;
		
		private System.Nullable<int> _SoLuong;
		
		private EntityRef<HangHoa> _HangHoa;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnTenHDChanging(string value);
    partial void OnTenHDChanged();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnMaHHChanging(System.Nullable<int> value);
    partial void OnMaHHChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    #endregion
		
		public HoaDon()
		{
			this._HangHoa = default(EntityRef<HangHoa>);
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHD", DbType="NVarChar(50)")]
		public string TenHD
		{
			get
			{
				return this._TenHD;
			}
			set
			{
				if ((this._TenHD != value))
				{
					this.OnTenHDChanging(value);
					this.SendPropertyChanging();
					this._TenHD = value;
					this.SendPropertyChanged("TenHD");
					this.OnTenHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="VarChar(10)")]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHH", DbType="Int")]
		public System.Nullable<int> MaHH
		{
			get
			{
				return this._MaHH;
			}
			set
			{
				if ((this._MaHH != value))
				{
					if (this._HangHoa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHHChanging(value);
					this.SendPropertyChanging();
					this._MaHH = value;
					this.SendPropertyChanged("MaHH");
					this.OnMaHHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HangHoa_HoaDon", Storage="_HangHoa", ThisKey="MaHH", OtherKey="MaHH", IsForeignKey=true)]
		public HangHoa HangHoa
		{
			get
			{
				return this._HangHoa.Entity;
			}
			set
			{
				HangHoa previousValue = this._HangHoa.Entity;
				if (((previousValue != value) 
							|| (this._HangHoa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HangHoa.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._HangHoa.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaHH = value.MaHH;
					}
					else
					{
						this._MaHH = default(Nullable<int>);
					}
					this.SendPropertyChanged("HangHoa");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(string);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _TenNV;
		
		private string _TaiKhoan;
		
		private string _Password;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public NhanVien()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="VarChar(50)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_HoaDons", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
}
#pragma warning restore 1591