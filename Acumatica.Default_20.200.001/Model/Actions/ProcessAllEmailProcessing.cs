using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProcessAllEmailProcessing : EntityAction<EmailProcessing>
	{
		public ProcessAllEmailProcessing(EmailProcessing entity) : base(entity)
		{ }
		public ProcessAllEmailProcessing() : base()
		{ }
	}
}
