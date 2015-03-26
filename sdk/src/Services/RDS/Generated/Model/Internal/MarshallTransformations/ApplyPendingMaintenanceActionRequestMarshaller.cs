/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplyPendingMaintenanceAction Request Marshaller
    /// </summary>       
    public class ApplyPendingMaintenanceActionRequestMarshaller : IMarshaller<IRequest, ApplyPendingMaintenanceActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ApplyPendingMaintenanceActionRequest)input);
        }
    
        public IRequest Marshall(ApplyPendingMaintenanceActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "ApplyPendingMaintenanceAction");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyAction())
                {
                    request.Parameters.Add("ApplyAction", StringUtils.FromString(publicRequest.ApplyAction));
                }
                if(publicRequest.IsSetOptInType())
                {
                    request.Parameters.Add("OptInType", StringUtils.FromString(publicRequest.OptInType));
                }
                if(publicRequest.IsSetResourceIdentifier())
                {
                    request.Parameters.Add("ResourceIdentifier", StringUtils.FromString(publicRequest.ResourceIdentifier));
                }
            }
            return request;
        }
    }
}