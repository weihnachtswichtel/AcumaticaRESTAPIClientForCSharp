using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class ProjectTemplateTaskApi : BaseEndpointApi<ProjectTemplateTask>
	{
		public ProjectTemplateTaskApi(Session session) : base(session)
		{ }
	}
}