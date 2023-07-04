using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class SalesPricesInquiry : Entity, ITopLevelEntity
	{

		[DataMember(Name="EffectiveAsOf", EmitDefaultValue=false)]
		public DateTimeValue EffectiveAsOf { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClassID", EmitDefaultValue=false)]
		public StringValue ItemClassID { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue PriceClass { get; set; }

		[DataMember(Name="PriceCode", EmitDefaultValue=false)]
		public StringValue PriceCode { get; set; }

		[DataMember(Name="PriceManager", EmitDefaultValue=false)]
		public StringValue PriceManager { get; set; }

		[DataMember(Name="PriceManagerIsMe", EmitDefaultValue=false)]
		public BooleanValue PriceManagerIsMe { get; set; }

		[DataMember(Name="PriceType", EmitDefaultValue=false)]
		public StringValue PriceType { get; set; }

		[DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
		public StringValue PriceWorkgroup { get; set; }

		[DataMember(Name="PriceWorkgroupIsMine", EmitDefaultValue=false)]
		public BooleanValue PriceWorkgroupIsMine { get; set; }

		[DataMember(Name="SalesPriceDetails", EmitDefaultValue=false)]
		public List<SalesPriceDetail> SalesPriceDetails { get; set; }

		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue TaxCalculationMode { get; set; }

		public string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}