// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Web;

namespace Castle.MonoRail.Framework.Routing
{
	using System.Collections;

	/// <summary>
	/// The default RouteContext
	/// </summary>
	public class RouteContext : IRouteContext
	{
		private readonly string applicationPath;
		private readonly HttpResponse response;
		private readonly IDictionary contextItems;
		private readonly IRequest request;

		/// <summary>
		/// Creates a new RouteContext
		/// </summary>
		/// <param name="request">The request.</param>
		/// <param name="response">The response.</param>
		/// <param name="applicationPath">The application path.</param>
		/// <param name="contextItems">The context items.</param>
		public RouteContext(IRequest request, HttpResponse response, string applicationPath, IDictionary contextItems)
		{
			this.request = request;
			this.response = response;
			this.applicationPath = applicationPath;
			this.contextItems = contextItems;
		}

		/// <summary>
		/// The ApplicationPath
		/// </summary>
		public string ApplicationPath
		{
			get { return applicationPath; }
		}

		/// <summary>
		/// The Http Request
		/// </summary>
		public IRequest Request
		{
			get { return request; }
		}

		/// <summary>
		/// Gets the Http response.
		/// </summary>
		/// <value>The response.</value>
		public HttpResponse Response
		{
			get { return response; }
		}

		/// <summary>
		/// Gets the context items.
		/// </summary>
		/// <value>The context items.</value>
		public IDictionary ContextItems
		{
			get { return contextItems; }
		}
	}
}
