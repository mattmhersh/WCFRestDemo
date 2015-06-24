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
 * SecondaryService.svc.cs : Sample service implementation
 */

namespace SampleService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SecondaryService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select SecondaryService.svc or SecondaryService.svc.cs at the Solution Explorer and start debugging.
	[Swaggerator.Attributes.Swaggerated("/SecondaryService.svc", "Another endpoint")]
	public class SecondaryService : ISecondaryService
	{
		public void DoWork()
		{
		}
	}
}
