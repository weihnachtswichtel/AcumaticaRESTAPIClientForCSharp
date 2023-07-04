using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ItemSalesCategory : Entity, ITopLevelEntity
	{

		[DataMember(Name="CategoryID", EmitDefaultValue=false)]
		public IntValue CategoryID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Members", EmitDefaultValue=false)]
		public List<ItemSalesCategoryMember> Members { get; set; }

		[DataMember(Name="ParentCategoryID", EmitDefaultValue=false)]
		public IntValue ParentCategoryID { get; set; }

		[DataMember(Name="Path", EmitDefaultValue=false)]
		public StringValue Path { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue SortOrder { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		public string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}