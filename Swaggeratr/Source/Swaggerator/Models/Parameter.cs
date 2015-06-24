﻿/*
 * Copyright (c) 2014 Digimarc Corporation
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Parameter.cs : Parameter model for serialization.
 */


using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Swaggerator.Models
{
	[DataContract]
	internal class Parameter
	{
		//public Parameter()
		//{
		//	allowableValues = new List<string>();
		//}

		[DataMember]
		public string paramType { get; set; }
		[DataMember]
		public string description { get; set; }
		[DataMember]
		public string name { get; set; }
		[DataMember]
		public string type { get; set; }
		[DataMember]
		public bool required { get; set; }
		[DataMember(EmitDefaultValue = false)]
		public List<string> allowableValues { get; set; }
		[DataMember]
		public bool allowMultiple { get; set; }
	}
}