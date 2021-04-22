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

namespace cv11
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Vyuka")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMark(Mark instance);
    partial void UpdateMark(Mark instance);
    partial void DeleteMark(Mark instance);
    partial void InsertRegistration(Registration instance);
    partial void UpdateRegistration(Registration instance);
    partial void DeleteRegistration(Registration instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertSubject(Subject instance);
    partial void UpdateSubject(Subject instance);
    partial void DeleteSubject(Subject instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::cv11.Properties.Settings.Default.VyukaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Mark> Marks
		{
			get
			{
				return this.GetTable<Mark>();
			}
		}
		
		public System.Data.Linq.Table<Registration> Registrations
		{
			get
			{
				return this.GetTable<Registration>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Subject> Subjects
		{
			get
			{
				return this.GetTable<Subject>();
			}
		}
		
		public System.Data.Linq.Table<StudentCountView> StudentCountViews
		{
			get
			{
				return this.GetTable<StudentCountView>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Marks")]
	public partial class Mark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentId;
		
		private string _Subject;
		
		private System.Nullable<System.DateTime> _Date;
		
		private System.Nullable<double> _Mark1;
		
		private EntityRef<Student> _Student;
		
		private EntityRef<Subject> _Subject1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnMark1Changing(System.Nullable<double> value);
    partial void OnMark1Changed();
    #endregion
		
		public Mark()
		{
			this._Student = default(EntityRef<Student>);
			this._Subject1 = default(EntityRef<Subject>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					if (this._Subject1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Mark", Storage="_Mark1", DbType="Float")]
		public System.Nullable<double> Mark1
		{
			get
			{
				return this._Mark1;
			}
			set
			{
				if ((this._Mark1 != value))
				{
					this.OnMark1Changing(value);
					this.SendPropertyChanging();
					this._Mark1 = value;
					this.SendPropertyChanged("Mark1");
					this.OnMark1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Mark", Storage="_Student", ThisKey="StudentId", OtherKey="Id", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Marks.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Marks.Add(this);
						this._StudentId = value.Id;
					}
					else
					{
						this._StudentId = default(int);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Mark", Storage="_Subject1", ThisKey="Subject", OtherKey="Abbreviation", IsForeignKey=true)]
		public Subject Subject1
		{
			get
			{
				return this._Subject1.Entity;
			}
			set
			{
				Subject previousValue = this._Subject1.Entity;
				if (((previousValue != value) 
							|| (this._Subject1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subject1.Entity = null;
						previousValue.Marks.Remove(this);
					}
					this._Subject1.Entity = value;
					if ((value != null))
					{
						value.Marks.Add(this);
						this._Subject = value.Abbreviation;
					}
					else
					{
						this._Subject = default(string);
					}
					this.SendPropertyChanged("Subject1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Registration")]
	public partial class Registration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentId;
		
		private string _Subject;
		
		private EntityRef<Student> _Student;
		
		private EntityRef<Subject> _Subject1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    #endregion
		
		public Registration()
		{
			this._Student = default(EntityRef<Student>);
			this._Subject1 = default(EntityRef<Subject>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					if (this._Subject1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Registration", Storage="_Student", ThisKey="StudentId", OtherKey="Id", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Registrations.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Registrations.Add(this);
						this._StudentId = value.Id;
					}
					else
					{
						this._StudentId = default(int);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Registration", Storage="_Subject1", ThisKey="Subject", OtherKey="Abbreviation", IsForeignKey=true)]
		public Subject Subject1
		{
			get
			{
				return this._Subject1.Entity;
			}
			set
			{
				Subject previousValue = this._Subject1.Entity;
				if (((previousValue != value) 
							|| (this._Subject1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subject1.Entity = null;
						previousValue.Registrations.Remove(this);
					}
					this._Subject1.Entity = value;
					if ((value != null))
					{
						value.Registrations.Add(this);
						this._Subject = value.Abbreviation;
					}
					else
					{
						this._Subject = default(string);
					}
					this.SendPropertyChanged("Subject1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private EntitySet<Mark> _Marks;
		
		private EntitySet<Registration> _Registrations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDateChanged();
    #endregion
		
		public Student()
		{
			this._Marks = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks), new Action<Mark>(this.detach_Marks));
			this._Registrations = new EntitySet<Registration>(new Action<Registration>(this.attach_Registrations), new Action<Registration>(this.detach_Registrations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="Date")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Mark", Storage="_Marks", ThisKey="Id", OtherKey="StudentId")]
		public EntitySet<Mark> Marks
		{
			get
			{
				return this._Marks;
			}
			set
			{
				this._Marks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Registration", Storage="_Registrations", ThisKey="Id", OtherKey="StudentId")]
		public EntitySet<Registration> Registrations
		{
			get
			{
				return this._Registrations;
			}
			set
			{
				this._Registrations.Assign(value);
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
		
		private void attach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
		
		private void attach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subjects")]
	public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Abbreviation;
		
		private string _Name;
		
		private EntitySet<Mark> _Marks;
		
		private EntitySet<Registration> _Registrations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAbbreviationChanging(string value);
    partial void OnAbbreviationChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Subject()
		{
			this._Marks = new EntitySet<Mark>(new Action<Mark>(this.attach_Marks), new Action<Mark>(this.detach_Marks));
			this._Registrations = new EntitySet<Registration>(new Action<Registration>(this.attach_Registrations), new Action<Registration>(this.detach_Registrations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abbreviation", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Abbreviation
		{
			get
			{
				return this._Abbreviation;
			}
			set
			{
				if ((this._Abbreviation != value))
				{
					this.OnAbbreviationChanging(value);
					this.SendPropertyChanging();
					this._Abbreviation = value;
					this.SendPropertyChanged("Abbreviation");
					this.OnAbbreviationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Mark", Storage="_Marks", ThisKey="Abbreviation", OtherKey="Subject")]
		public EntitySet<Mark> Marks
		{
			get
			{
				return this._Marks;
			}
			set
			{
				this._Marks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Registration", Storage="_Registrations", ThisKey="Abbreviation", OtherKey="Subject")]
		public EntitySet<Registration> Registrations
		{
			get
			{
				return this._Registrations;
			}
			set
			{
				this._Registrations.Assign(value);
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
		
		private void attach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Subject1 = this;
		}
		
		private void detach_Marks(Mark entity)
		{
			this.SendPropertyChanging();
			entity.Subject1 = null;
		}
		
		private void attach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Subject1 = this;
		}
		
		private void detach_Registrations(Registration entity)
		{
			this.SendPropertyChanging();
			entity.Subject1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentCountView")]
	public partial class StudentCountView
	{
		
		private string _Subject;
		
		private System.Nullable<int> _Students;
		
		public StudentCountView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this._Subject = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Students", DbType="Int")]
		public System.Nullable<int> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				if ((this._Students != value))
				{
					this._Students = value;
				}
			}
		}
	}
}
#pragma warning restore 1591