// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	/// <summary>
	/// Represents an add-on service available to a given account
	/// </summary>
	public class Service : ODataObject 
	{
		public string AddOnCode { get; set; }
		public int? Licenses { get; set; }
		public int? LicensesUsed { get; set; }
		/// <summary>
		/// Unit price per license, per billing cycle
		/// </summary>
		public decimal? PricePerLicense { get; set; }
		public int? PlanAddonBundleId { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as Service;
			if(typedSource != null)
			{
				AddOnCode = typedSource.AddOnCode;
				Licenses = typedSource.Licenses;
				LicensesUsed = typedSource.LicensesUsed;
				PricePerLicense = typedSource.PricePerLicense;
				PlanAddonBundleId = typedSource.PlanAddonBundleId;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("AddOnCode", out token) && token.Type != JTokenType.Null)
				{
					AddOnCode = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Licenses", out token) && token.Type != JTokenType.Null)
				{
					Licenses = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("LicensesUsed", out token) && token.Type != JTokenType.Null)
				{
					LicensesUsed = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("PricePerLicense", out token) && token.Type != JTokenType.Null)
				{
					PricePerLicense = (decimal?)serializer.Deserialize(token.CreateReader(), typeof(decimal?));
				}
				if(source.TryGetProperty("PlanAddonBundleId", out token) && token.Type != JTokenType.Null)
				{
					PlanAddonBundleId = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
			}
		}
	}
}