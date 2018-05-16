﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop2StopDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Stop2ShopContext : DbContext
    {
        public Stop2ShopContext()
            : base("name=Stop2ShopContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<SupplierCategory> SupplierCategories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierTransaction> SupplierTransactions { get; set; }
        public virtual DbSet<BuyingGroup> BuyingGroups { get; set; }
        public virtual DbSet<CustomerCategory> CustomerCategories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SpecialDeal> SpecialDeals { get; set; }
        public virtual DbSet<ColdRoomTemperature> ColdRoomTemperatures { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<PackageType> PackageTypes { get; set; }
        public virtual DbSet<StockGroup> StockGroups { get; set; }
        public virtual DbSet<StockItemHolding> StockItemHoldings { get; set; }
        public virtual DbSet<StockItem> StockItems { get; set; }
        public virtual DbSet<StockItemStockGroup> StockItemStockGroups { get; set; }
        public virtual DbSet<StockItemTransaction> StockItemTransactions { get; set; }
        public virtual DbSet<VehicleTemperature> VehicleTemperatures { get; set; }
        public virtual DbSet<Cities_Archive> Cities_Archive { get; set; }
        public virtual DbSet<Countries_Archive> Countries_Archive { get; set; }
        public virtual DbSet<DeliveryMethods_Archive> DeliveryMethods_Archive { get; set; }
        public virtual DbSet<PaymentMethods_Archive> PaymentMethods_Archive { get; set; }
        public virtual DbSet<People_Archive> People_Archive { get; set; }
        public virtual DbSet<StateProvinces_Archive> StateProvinces_Archive { get; set; }
        public virtual DbSet<TransactionTypes_Archive> TransactionTypes_Archive { get; set; }
        public virtual DbSet<SupplierCategories_Archive> SupplierCategories_Archive { get; set; }
        public virtual DbSet<Suppliers_Archive> Suppliers_Archive { get; set; }
        public virtual DbSet<BuyingGroups_Archive> BuyingGroups_Archive { get; set; }
        public virtual DbSet<CustomerCategories_Archive> CustomerCategories_Archive { get; set; }
        public virtual DbSet<Customers_Archive> Customers_Archive { get; set; }
        public virtual DbSet<ColdRoomTemperatures_Archive> ColdRoomTemperatures_Archive { get; set; }
        public virtual DbSet<Colors_Archive> Colors_Archive { get; set; }
        public virtual DbSet<PackageTypes_Archive> PackageTypes_Archive { get; set; }
        public virtual DbSet<StockGroups_Archive> StockGroups_Archive { get; set; }
        public virtual DbSet<StockItems_Archive> StockItems_Archive { get; set; }
        public virtual DbSet<Customers1> Customers1 { get; set; }
        public virtual DbSet<Suppliers1> Suppliers1 { get; set; }
        public virtual DbSet<VehicleTemperatures1> VehicleTemperatures1 { get; set; }
    
        [DbFunction("Stop2ShopContext", "DetermineCustomerAccess")]
        public virtual IQueryable<DetermineCustomerAccess_Result> DetermineCustomerAccess(Nullable<int> cityID)
        {
            var cityIDParameter = cityID.HasValue ?
                new ObjectParameter("CityID", cityID) :
                new ObjectParameter("CityID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DetermineCustomerAccess_Result>("[Stop2ShopContext].[DetermineCustomerAccess](@CityID)", cityIDParameter);
        }
    
        public virtual int AddRoleMemberIfNonexistent(string roleName, string userName)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddRoleMemberIfNonexistent", roleNameParameter, userNameParameter);
        }
    
        public virtual int Configuration_ApplyAuditing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyAuditing");
        }
    
        public virtual int Configuration_ApplyColumnstoreIndexing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyColumnstoreIndexing");
        }
    
        public virtual int Configuration_ApplyFullTextIndexing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyFullTextIndexing");
        }
    
        public virtual int Configuration_ApplyPartitioning()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyPartitioning");
        }
    
        public virtual int Configuration_ApplyRowLevelSecurity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyRowLevelSecurity");
        }
    
        public virtual int Configuration_ConfigureForEnterpriseEdition()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ConfigureForEnterpriseEdition");
        }
    
        public virtual int Configuration_EnableInMemory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_EnableInMemory");
        }
    
        public virtual int Configuration_RemoveAuditing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_RemoveAuditing");
        }
    
        public virtual int Configuration_RemoveRowLevelSecurity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_RemoveRowLevelSecurity");
        }
    
        public virtual int CreateRoleIfNonexistent(string roleName)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateRoleIfNonexistent", roleNameParameter);
        }
    
        public virtual int Configuration_ApplyDataLoadSimulationProcedures()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_ApplyDataLoadSimulationProcedures");
        }
    
        public virtual int Configuration_RemoveDataLoadSimulationProcedures()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Configuration_RemoveDataLoadSimulationProcedures");
        }
    
        public virtual int DeactivateTemporalTablesBeforeDataLoad()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeactivateTemporalTablesBeforeDataLoad");
        }
    
        public virtual int PopulateDataToCurrentDate(Nullable<int> averageNumberOfCustomerOrdersPerDay, Nullable<int> saturdayPercentageOfNormalWorkDay, Nullable<int> sundayPercentageOfNormalWorkDay, Nullable<bool> isSilentMode, Nullable<bool> areDatesPrinted)
        {
            var averageNumberOfCustomerOrdersPerDayParameter = averageNumberOfCustomerOrdersPerDay.HasValue ?
                new ObjectParameter("AverageNumberOfCustomerOrdersPerDay", averageNumberOfCustomerOrdersPerDay) :
                new ObjectParameter("AverageNumberOfCustomerOrdersPerDay", typeof(int));
    
            var saturdayPercentageOfNormalWorkDayParameter = saturdayPercentageOfNormalWorkDay.HasValue ?
                new ObjectParameter("SaturdayPercentageOfNormalWorkDay", saturdayPercentageOfNormalWorkDay) :
                new ObjectParameter("SaturdayPercentageOfNormalWorkDay", typeof(int));
    
            var sundayPercentageOfNormalWorkDayParameter = sundayPercentageOfNormalWorkDay.HasValue ?
                new ObjectParameter("SundayPercentageOfNormalWorkDay", sundayPercentageOfNormalWorkDay) :
                new ObjectParameter("SundayPercentageOfNormalWorkDay", typeof(int));
    
            var isSilentModeParameter = isSilentMode.HasValue ?
                new ObjectParameter("IsSilentMode", isSilentMode) :
                new ObjectParameter("IsSilentMode", typeof(bool));
    
            var areDatesPrintedParameter = areDatesPrinted.HasValue ?
                new ObjectParameter("AreDatesPrinted", areDatesPrinted) :
                new ObjectParameter("AreDatesPrinted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PopulateDataToCurrentDate", averageNumberOfCustomerOrdersPerDayParameter, saturdayPercentageOfNormalWorkDayParameter, sundayPercentageOfNormalWorkDayParameter, isSilentModeParameter, areDatesPrintedParameter);
        }
    
        public virtual int ReactivateTemporalTablesAfterDataLoad()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReactivateTemporalTablesAfterDataLoad");
        }
    
        public virtual int GetCityUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetCityUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual int GetCustomerUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetCustomerUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual int GetEmployeeUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetEmployeeUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual ObjectResult<GetMovementUpdates_Result> GetMovementUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMovementUpdates_Result>("GetMovementUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual ObjectResult<GetOrderUpdates_Result> GetOrderUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOrderUpdates_Result>("GetOrderUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual int GetPaymentMethodUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetPaymentMethodUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual ObjectResult<GetPurchaseUpdates_Result> GetPurchaseUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPurchaseUpdates_Result>("GetPurchaseUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual ObjectResult<GetSaleUpdates_Result> GetSaleUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSaleUpdates_Result>("GetSaleUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual ObjectResult<GetStockHoldingUpdates_Result> GetStockHoldingUpdates()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStockHoldingUpdates_Result>("GetStockHoldingUpdates");
        }
    
        public virtual int GetStockItemUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetStockItemUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual int GetSupplierUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetSupplierUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual int GetTransactionTypeUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetTransactionTypeUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual ObjectResult<GetTransactionUpdates_Result> GetTransactionUpdates(Nullable<System.DateTime> lastCutoff, Nullable<System.DateTime> newCutoff)
        {
            var lastCutoffParameter = lastCutoff.HasValue ?
                new ObjectParameter("LastCutoff", lastCutoff) :
                new ObjectParameter("LastCutoff", typeof(System.DateTime));
    
            var newCutoffParameter = newCutoff.HasValue ?
                new ObjectParameter("NewCutoff", newCutoff) :
                new ObjectParameter("NewCutoff", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTransactionUpdates_Result>("GetTransactionUpdates", lastCutoffParameter, newCutoffParameter);
        }
    
        public virtual int ReseedAllSequences()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReseedAllSequences");
        }
    
        public virtual int ReseedSequenceBeyondTableValues(string sequenceName, string schemaName, string tableName, string columnName)
        {
            var sequenceNameParameter = sequenceName != null ?
                new ObjectParameter("SequenceName", sequenceName) :
                new ObjectParameter("SequenceName", typeof(string));
    
            var schemaNameParameter = schemaName != null ?
                new ObjectParameter("SchemaName", schemaName) :
                new ObjectParameter("SchemaName", typeof(string));
    
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var columnNameParameter = columnName != null ?
                new ObjectParameter("ColumnName", columnName) :
                new ObjectParameter("ColumnName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ReseedSequenceBeyondTableValues", sequenceNameParameter, schemaNameParameter, tableNameParameter, columnNameParameter);
        }
    
        public virtual int ActivateWebsiteLogon(Nullable<int> personID, string logonName, string initialPassword)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("PersonID", personID) :
                new ObjectParameter("PersonID", typeof(int));
    
            var logonNameParameter = logonName != null ?
                new ObjectParameter("LogonName", logonName) :
                new ObjectParameter("LogonName", typeof(string));
    
            var initialPasswordParameter = initialPassword != null ?
                new ObjectParameter("InitialPassword", initialPassword) :
                new ObjectParameter("InitialPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActivateWebsiteLogon", personIDParameter, logonNameParameter, initialPasswordParameter);
        }
    
        public virtual int ChangePassword(Nullable<int> personID, string oldPassword, string newPassword)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("PersonID", personID) :
                new ObjectParameter("PersonID", typeof(int));
    
            var oldPasswordParameter = oldPassword != null ?
                new ObjectParameter("OldPassword", oldPassword) :
                new ObjectParameter("OldPassword", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("NewPassword", newPassword) :
                new ObjectParameter("NewPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangePassword", personIDParameter, oldPasswordParameter, newPasswordParameter);
        }
    
        public virtual int InsertCustomerOrders(Nullable<int> ordersCreatedByPersonID, Nullable<int> salespersonPersonID)
        {
            var ordersCreatedByPersonIDParameter = ordersCreatedByPersonID.HasValue ?
                new ObjectParameter("OrdersCreatedByPersonID", ordersCreatedByPersonID) :
                new ObjectParameter("OrdersCreatedByPersonID", typeof(int));
    
            var salespersonPersonIDParameter = salespersonPersonID.HasValue ?
                new ObjectParameter("SalespersonPersonID", salespersonPersonID) :
                new ObjectParameter("SalespersonPersonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCustomerOrders", ordersCreatedByPersonIDParameter, salespersonPersonIDParameter);
        }
    
        public virtual int InvoiceCustomerOrders(Nullable<int> packedByPersonID, Nullable<int> invoicedByPersonID)
        {
            var packedByPersonIDParameter = packedByPersonID.HasValue ?
                new ObjectParameter("PackedByPersonID", packedByPersonID) :
                new ObjectParameter("PackedByPersonID", typeof(int));
    
            var invoicedByPersonIDParameter = invoicedByPersonID.HasValue ?
                new ObjectParameter("InvoicedByPersonID", invoicedByPersonID) :
                new ObjectParameter("InvoicedByPersonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InvoiceCustomerOrders", packedByPersonIDParameter, invoicedByPersonIDParameter);
        }
    
        public virtual int RecordColdRoomTemperatures()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RecordColdRoomTemperatures");
        }
    
        public virtual int RecordVehicleTemperature(string fullSensorDataArray)
        {
            var fullSensorDataArrayParameter = fullSensorDataArray != null ?
                new ObjectParameter("FullSensorDataArray", fullSensorDataArray) :
                new ObjectParameter("FullSensorDataArray", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RecordVehicleTemperature", fullSensorDataArrayParameter);
        }
    
        public virtual ObjectResult<string> SearchForCustomers(string searchText, Nullable<int> maximumRowsToReturn)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var maximumRowsToReturnParameter = maximumRowsToReturn.HasValue ?
                new ObjectParameter("MaximumRowsToReturn", maximumRowsToReturn) :
                new ObjectParameter("MaximumRowsToReturn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SearchForCustomers", searchTextParameter, maximumRowsToReturnParameter);
        }
    
        public virtual ObjectResult<string> SearchForPeople(string searchText, Nullable<int> maximumRowsToReturn)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var maximumRowsToReturnParameter = maximumRowsToReturn.HasValue ?
                new ObjectParameter("MaximumRowsToReturn", maximumRowsToReturn) :
                new ObjectParameter("MaximumRowsToReturn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SearchForPeople", searchTextParameter, maximumRowsToReturnParameter);
        }
    
        public virtual ObjectResult<string> SearchForStockItems(string searchText, Nullable<int> maximumRowsToReturn)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var maximumRowsToReturnParameter = maximumRowsToReturn.HasValue ?
                new ObjectParameter("MaximumRowsToReturn", maximumRowsToReturn) :
                new ObjectParameter("MaximumRowsToReturn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SearchForStockItems", searchTextParameter, maximumRowsToReturnParameter);
        }
    
        public virtual ObjectResult<string> SearchForStockItemsByTags(string searchText, Nullable<int> maximumRowsToReturn)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var maximumRowsToReturnParameter = maximumRowsToReturn.HasValue ?
                new ObjectParameter("MaximumRowsToReturn", maximumRowsToReturn) :
                new ObjectParameter("MaximumRowsToReturn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SearchForStockItemsByTags", searchTextParameter, maximumRowsToReturnParameter);
        }
    
        public virtual ObjectResult<string> SearchForSuppliers(string searchText, Nullable<int> maximumRowsToReturn)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var maximumRowsToReturnParameter = maximumRowsToReturn.HasValue ?
                new ObjectParameter("MaximumRowsToReturn", maximumRowsToReturn) :
                new ObjectParameter("MaximumRowsToReturn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SearchForSuppliers", searchTextParameter, maximumRowsToReturnParameter);
        }
    }
}
