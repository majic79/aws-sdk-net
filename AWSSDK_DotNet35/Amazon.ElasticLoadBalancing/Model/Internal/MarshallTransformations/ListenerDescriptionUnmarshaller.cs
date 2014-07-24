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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListenerDescription Object
    /// </summary>  
    public class ListenerDescriptionUnmarshaller : IUnmarshaller<ListenerDescription, XmlUnmarshallerContext>, IUnmarshaller<ListenerDescription, JsonUnmarshallerContext>
    {
        public ListenerDescription Unmarshall(XmlUnmarshallerContext context)
        {
            ListenerDescription unmarshalledObject = new ListenerDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Listener", targetDepth))
                    {
                        var unmarshaller = ListenerUnmarshaller.Instance;
                        unmarshalledObject.Listener = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyNames/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PolicyNames.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public ListenerDescription Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ListenerDescriptionUnmarshaller _instance = new ListenerDescriptionUnmarshaller();        

        public static ListenerDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}