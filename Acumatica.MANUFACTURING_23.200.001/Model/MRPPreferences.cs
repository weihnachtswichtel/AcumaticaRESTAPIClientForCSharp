using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class MRPPreferences : Entity, ITopLevelEntity
	{

		[DataMember(Name="DaysAfter", EmitDefaultValue=false)]
		public IntValue? DaysAfter { get; set; }

		[DataMember(Name="DaysBefore", EmitDefaultValue=false)]
		public IntValue? DaysBefore { get; set; }

		[DataMember(Name="DefaultType", EmitDefaultValue=false)]
		public StringValue? DefaultType { get; set; }

		[DataMember(Name="DemandTimeFence", EmitDefaultValue=false)]
		public IntValue? DemandTimeFence { get; set; }

		[DataMember(Name="GracePeriod", EmitDefaultValue=false)]
		public IntValue? GracePeriod { get; set; }

		[DataMember(Name="IncludeOnHoldProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldProductionOrders { get; set; }

		[DataMember(Name="IncludeOnHoldPurchaseOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldPurchaseOrders { get; set; }

		[DataMember(Name="IncludeOnHoldSalesOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldSalesOrders { get; set; }

		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue? NumberingSequence { get; set; }

		[DataMember(Name="PlanOrderType", EmitDefaultValue=false)]
		public StringValue? PlanOrderType { get; set; }

		[DataMember(Name="PurchaseCalendarID", EmitDefaultValue=false)]
		public StringValue? PurchaseCalendarID { get; set; }

		[DataMember(Name="StockingMethod", EmitDefaultValue=false)]
		public StringValue? StockingMethod { get; set; }

		[DataMember(Name="TimeFence", EmitDefaultValue=false)]
		public IntValue? TimeFence { get; set; }

		[DataMember(Name="UseFixedManufacturingTimes", EmitDefaultValue=false)]
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}