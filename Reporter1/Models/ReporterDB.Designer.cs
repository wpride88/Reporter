﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Метаданные связи EDM

[assembly: EdmRelationshipAttribute("REPORTERModel", "FK_jobs_UsersRP", "UsersRP", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Reporter1.Models.UsersRP), "jobs", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Reporter1.Models.jobs), true)]
[assembly: EdmRelationshipAttribute("REPORTERModel", "FK_jobs_jobtype", "jobtype", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Reporter1.Models.jobtype), "jobs", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Reporter1.Models.jobs), true)]

#endregion

namespace Reporter1.Models
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class REPORTEREntities1 : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект REPORTEREntities1, используя строку соединения из раздела "REPORTEREntities1" файла конфигурации приложения.
        /// </summary>
        public REPORTEREntities1() : base("name=REPORTEREntities1", "REPORTEREntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта REPORTEREntities1.
        /// </summary>
        public REPORTEREntities1(string connectionString) : base(connectionString, "REPORTEREntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта REPORTEREntities1.
        /// </summary>
        public REPORTEREntities1(EntityConnection connection) : base(connection, "REPORTEREntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<jobs> jobs
        {
            get
            {
                if ((_jobs == null))
                {
                    _jobs = base.CreateObjectSet<jobs>("jobs");
                }
                return _jobs;
            }
        }
        private ObjectSet<jobs> _jobs;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<UsersRP> UsersRP
        {
            get
            {
                if ((_UsersRP == null))
                {
                    _UsersRP = base.CreateObjectSet<UsersRP>("UsersRP");
                }
                return _UsersRP;
            }
        }
        private ObjectSet<UsersRP> _UsersRP;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<jobtype> jobtype
        {
            get
            {
                if ((_jobtype == null))
                {
                    _jobtype = base.CreateObjectSet<jobtype>("jobtype");
                }
                return _jobtype;
            }
        }
        private ObjectSet<jobtype> _jobtype;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<dtproperties> dtproperties
        {
            get
            {
                if ((_dtproperties == null))
                {
                    _dtproperties = base.CreateObjectSet<dtproperties>("dtproperties");
                }
                return _dtproperties;
            }
        }
        private ObjectSet<dtproperties> _dtproperties;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<sysdiagrams> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagrams>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagrams> _sysdiagrams;

        #endregion
        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet jobs. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddTojobs(jobs jobs)
        {
            base.AddObject("jobs", jobs);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet UsersRP. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToUsersRP(UsersRP usersRP)
        {
            base.AddObject("UsersRP", usersRP);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet jobtype. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddTojobtype(jobtype jobtype)
        {
            base.AddObject("jobtype", jobtype);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet dtproperties. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddTodtproperties(dtproperties dtproperties)
        {
            base.AddObject("dtproperties", dtproperties);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet sysdiagrams. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddTosysdiagrams(sysdiagrams sysdiagrams)
        {
            base.AddObject("sysdiagrams", sysdiagrams);
        }

        #endregion
    }
    

    #endregion
    
    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="REPORTERModel", Name="dtproperties")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class dtproperties : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта dtproperties.
        /// </summary>
        /// <param name="id">Исходное значение свойства id.</param>
        /// <param name="property">Исходное значение свойства property.</param>
        /// <param name="version">Исходное значение свойства version.</param>
        public static dtproperties Createdtproperties(global::System.Int32 id, global::System.String property, global::System.Int32 version)
        {
            dtproperties dtproperties = new dtproperties();
            dtproperties.id = id;
            dtproperties.property = property;
            dtproperties.version = version;
            return dtproperties;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> objectid
        {
            get
            {
                return _objectid;
            }
            set
            {
                OnobjectidChanging(value);
                ReportPropertyChanging("objectid");
                _objectid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("objectid");
                OnobjectidChanged();
            }
        }
        private Nullable<global::System.Int32> _objectid;
        partial void OnobjectidChanging(Nullable<global::System.Int32> value);
        partial void OnobjectidChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String property
        {
            get
            {
                return _property;
            }
            set
            {
                if (_property != value)
                {
                    OnpropertyChanging(value);
                    ReportPropertyChanging("property");
                    _property = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("property");
                    OnpropertyChanged();
                }
            }
        }
        private global::System.String _property;
        partial void OnpropertyChanging(global::System.String value);
        partial void OnpropertyChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String value
        {
            get
            {
                return _value;
            }
            set
            {
                OnvalueChanging(value);
                ReportPropertyChanging("value");
                _value = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("value");
                OnvalueChanged();
            }
        }
        private global::System.String _value;
        partial void OnvalueChanging(global::System.String value);
        partial void OnvalueChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String uvalue
        {
            get
            {
                return _uvalue;
            }
            set
            {
                OnuvalueChanging(value);
                ReportPropertyChanging("uvalue");
                _uvalue = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("uvalue");
                OnuvalueChanged();
            }
        }
        private global::System.String _uvalue;
        partial void OnuvalueChanging(global::System.String value);
        partial void OnuvalueChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] lvalue
        {
            get
            {
                return StructuralObject.GetValidValue(_lvalue);
            }
            set
            {
                OnlvalueChanging(value);
                ReportPropertyChanging("lvalue");
                _lvalue = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("lvalue");
                OnlvalueChanged();
            }
        }
        private global::System.Byte[] _lvalue;
        partial void OnlvalueChanging(global::System.Byte[] value);
        partial void OnlvalueChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private global::System.Int32 _version;
        partial void OnversionChanging(global::System.Int32 value);
        partial void OnversionChanged();

        #endregion
    
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="REPORTERModel", Name="jobs")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class jobs : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта jobs.
        /// </summary>
        /// <param name="jid">Исходное значение свойства Jid.</param>
        /// <param name="jname">Исходное значение свойства Jname.</param>
        /// <param name="date">Исходное значение свойства Date.</param>
        /// <param name="jtimeh">Исходное значение свойства Jtimeh.</param>
        /// <param name="uid">Исходное значение свойства Uid.</param>
        /// <param name="jtid">Исходное значение свойства Jtid.</param>
        public static jobs Createjobs(global::System.Int32 jid, global::System.String jname, global::System.DateTime date, global::System.Int32 jtimeh, global::System.Int32 uid, global::System.Int32 jtid)
        {
            jobs jobs = new jobs();
            jobs.Jid = jid;
            jobs.Jname = jname;
            jobs.Date = date;
            jobs.Jtimeh = jtimeh;
            jobs.Uid = uid;
            jobs.Jtid = jtid;
            return jobs;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Jid
        {
            get
            {
                return _Jid;
            }
            set
            {
                if (_Jid != value)
                {
                    OnJidChanging(value);
                    ReportPropertyChanging("Jid");
                    _Jid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Jid");
                    OnJidChanged();
                }
            }
        }
        private global::System.Int32 _Jid;
        partial void OnJidChanging(global::System.Int32 value);
        partial void OnJidChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Jname
        {
            get
            {
                return _Jname;
            }
            set
            {
                OnJnameChanging(value);
                ReportPropertyChanging("Jname");
                _Jname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Jname");
                OnJnameChanged();
            }
        }
        private global::System.String _Jname;
        partial void OnJnameChanging(global::System.String value);
        partial void OnJnameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Jtimeh
        {
            get
            {
                return _Jtimeh;
            }
            set
            {
                OnJtimehChanging(value);
                ReportPropertyChanging("Jtimeh");
                _Jtimeh = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Jtimeh");
                OnJtimehChanged();
            }
        }
        private global::System.Int32 _Jtimeh;
        partial void OnJtimehChanging(global::System.Int32 value);
        partial void OnJtimehChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Uid
        {
            get
            {
                return _Uid;
            }
            set
            {
                OnUidChanging(value);
                ReportPropertyChanging("Uid");
                _Uid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Uid");
                OnUidChanged();
            }
        }
        private global::System.Int32 _Uid;
        partial void OnUidChanging(global::System.Int32 value);
        partial void OnUidChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Jtid
        {
            get
            {
                return _Jtid;
            }
            set
            {
                OnJtidChanging(value);
                ReportPropertyChanging("Jtid");
                _Jtid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Jtid");
                OnJtidChanged();
            }
        }
        private global::System.Int32 _Jtid;
        partial void OnJtidChanging(global::System.Int32 value);
        partial void OnJtidChanged();

        #endregion
    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("REPORTERModel", "FK_jobs_UsersRP", "UsersRP")]
        public UsersRP UsersRP
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UsersRP>("REPORTERModel.FK_jobs_UsersRP", "UsersRP").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UsersRP>("REPORTERModel.FK_jobs_UsersRP", "UsersRP").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<UsersRP> UsersRPReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UsersRP>("REPORTERModel.FK_jobs_UsersRP", "UsersRP");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<UsersRP>("REPORTERModel.FK_jobs_UsersRP", "UsersRP", value);
                }
            }
        }
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("REPORTERModel", "FK_jobs_jobtype", "jobtype")]
        public jobtype jobtype
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<jobtype>("REPORTERModel.FK_jobs_jobtype", "jobtype").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<jobtype>("REPORTERModel.FK_jobs_jobtype", "jobtype").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<jobtype> jobtypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<jobtype>("REPORTERModel.FK_jobs_jobtype", "jobtype");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<jobtype>("REPORTERModel.FK_jobs_jobtype", "jobtype", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="REPORTERModel", Name="jobtype")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class jobtype : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта jobtype.
        /// </summary>
        /// <param name="jid">Исходное значение свойства Jid.</param>
        /// <param name="jTitle">Исходное значение свойства JTitle.</param>
        public static jobtype Createjobtype(global::System.Int32 jid, global::System.String jTitle)
        {
            jobtype jobtype = new jobtype();
            jobtype.Jid = jid;
            jobtype.JTitle = jTitle;
            return jobtype;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Jid
        {
            get
            {
                return _Jid;
            }
            set
            {
                if (_Jid != value)
                {
                    OnJidChanging(value);
                    ReportPropertyChanging("Jid");
                    _Jid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Jid");
                    OnJidChanged();
                }
            }
        }
        private global::System.Int32 _Jid;
        partial void OnJidChanging(global::System.Int32 value);
        partial void OnJidChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String JTitle
        {
            get
            {
                return _JTitle;
            }
            set
            {
                OnJTitleChanging(value);
                ReportPropertyChanging("JTitle");
                _JTitle = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("JTitle");
                OnJTitleChanged();
            }
        }
        private global::System.String _JTitle;
        partial void OnJTitleChanging(global::System.String value);
        partial void OnJTitleChanged();

        #endregion
    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("REPORTERModel", "FK_jobs_jobtype", "jobs")]
        public EntityCollection<jobs> jobs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<jobs>("REPORTERModel.FK_jobs_jobtype", "jobs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<jobs>("REPORTERModel.FK_jobs_jobtype", "jobs", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="REPORTERModel", Name="sysdiagrams")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagrams : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта sysdiagrams.
        /// </summary>
        /// <param name="name">Исходное значение свойства name.</param>
        /// <param name="principal_id">Исходное значение свойства principal_id.</param>
        /// <param name="diagram_id">Исходное значение свойства diagram_id.</param>
        public static sysdiagrams Createsysdiagrams(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagrams sysdiagrams = new sysdiagrams();
            sysdiagrams.name = name;
            sysdiagrams.principal_id = principal_id;
            sysdiagrams.diagram_id = diagram_id;
            return sysdiagrams;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="REPORTERModel", Name="UsersRP")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UsersRP : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта UsersRP.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="login">Исходное значение свойства Login.</param>
        public static UsersRP CreateUsersRP(global::System.Int32 id, global::System.String login)
        {
            UsersRP usersRP = new UsersRP();
            usersRP.Id = id;
            usersRP.Login = login;
            return usersRP;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Login
        {
            get
            {
                return _Login;
            }
            set
            {
                OnLoginChanging(value);
                ReportPropertyChanging("Login");
                _Login = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Login");
                OnLoginChanged();
            }
        }
        private global::System.String _Login;
        partial void OnLoginChanging(global::System.String value);
        partial void OnLoginChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Pass
        {
            get
            {
                return _Pass;
            }
            set
            {
                OnPassChanging(value);
                ReportPropertyChanging("Pass");
                _Pass = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Pass");
                OnPassChanged();
            }
        }
        private global::System.String _Pass;
        partial void OnPassChanging(global::System.String value);
        partial void OnPassChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();

        #endregion
    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("REPORTERModel", "FK_jobs_UsersRP", "jobs")]
        public EntityCollection<jobs> jobs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<jobs>("REPORTERModel.FK_jobs_UsersRP", "jobs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<jobs>("REPORTERModel.FK_jobs_UsersRP", "jobs", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}