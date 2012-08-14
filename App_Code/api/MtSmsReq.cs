﻿/*   
   Copyright 2012 Sajith Lakjaya

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for MtSmsReq
/// </summary>
public class MtSmsReq : Message
{
    public String applicationId {get; set;}
    public String password { get; set; }
    public String version { get; set; }
    public List<String> destinationAddresses { get; set; }
    public String message { get; set; }
    public String sourceAddress { get; set; }
    public String deliveryStatusRequest { get; set; }
    public String encoding { get; set; }
    public String chargingAmount { get; set; }
    public String binaryHeader { get; set; }
}