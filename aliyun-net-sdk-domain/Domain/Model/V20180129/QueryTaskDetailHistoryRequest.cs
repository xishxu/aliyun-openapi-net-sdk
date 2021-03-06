/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class QueryTaskDetailHistoryRequest : RpcAcsRequest<QueryTaskDetailHistoryResponse>
    {
        public QueryTaskDetailHistoryRequest()
            : base("Domain", "2018-01-29", "QueryTaskDetailHistory", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string domainName;

		private int? taskStatus;

		private string userClientIp;

		private string taskNo;

		private int? pageSize;

		private string taskDetailNoCursor;

		private string lang;

		private string domainNameCursor;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public int? TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
				DictionaryUtil.Add(QueryParameters, "TaskStatus", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string TaskNo
		{
			get
			{
				return taskNo;
			}
			set	
			{
				taskNo = value;
				DictionaryUtil.Add(QueryParameters, "TaskNo", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string TaskDetailNoCursor
		{
			get
			{
				return taskDetailNoCursor;
			}
			set	
			{
				taskDetailNoCursor = value;
				DictionaryUtil.Add(QueryParameters, "TaskDetailNoCursor", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string DomainNameCursor
		{
			get
			{
				return domainNameCursor;
			}
			set	
			{
				domainNameCursor = value;
				DictionaryUtil.Add(QueryParameters, "DomainNameCursor", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryTaskDetailHistoryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTaskDetailHistoryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
