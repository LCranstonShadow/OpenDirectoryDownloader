﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var crushFtpResponse = CrushFtpResponse.FromJson(jsonString);

namespace OpenDirectoryDownloader.Site.CrushFtp;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public partial class CrushFtpResult
{
	[JsonProperty("privs")]
	public string Privs { get; set; }

	[JsonProperty("comment")]
	public string Comment { get; set; }

	[JsonProperty("path")]
	public string Path { get; set; }

	[JsonProperty("defaultStrings")]
	public string DefaultStrings { get; set; }

	[JsonProperty("site")]
	public string Site { get; set; }

	[JsonProperty("quota")]
	public string Quota { get; set; }

	[JsonProperty("quota_bytes")]
	public string QuotaBytes { get; set; }

	[JsonProperty("bytes_sent")]
	public long BytesSent { get; set; }

	[JsonProperty("bytes_received")]
	public long BytesReceived { get; set; }

	[JsonProperty("max_upload_amount_day")]
	public long MaxUploadAmountDay { get; set; }	

	[JsonProperty("max_upload_amount_month")]
	public long MaxUploadAmountMonth { get; set; }

	[JsonProperty("max_upload_amount")]
	public long MaxUploadAmount { get; set; }

	[JsonProperty("max_upload_amount_available")]
	public long MaxUploadAmountAvailable { get; set; }

	[JsonProperty("max_upload_amount_day_available")]
	public string MaxUploadAmountDayAvailable { get; set; }

	[JsonProperty("max_upload_amount_month_available")]
	public string MaxUploadAmountMonthAvailable { get; set; }

	[JsonProperty("max_download_amount")]
	public long MaxDownloadAmount { get; set; }

	[JsonProperty("max_download_amount_day")]
	public long MaxDownloadAmountDay { get; set; }

	[JsonProperty("max_download_amount_month")]
	public long MaxDownloadAmountMonth { get; set; }

	[JsonProperty("max_download_amount_available")]
	public long MaxDownloadAmountAvailable { get; set; }

	[JsonProperty("max_download_amount_day_available")]
	public string MaxDownloadAmountDayAvailable { get; set; }

	[JsonProperty("max_download_amount_month_available")]
	public string MaxDownloadAmountMonthAvailable { get; set; }

	[JsonProperty("listing")]
	public Listing[] Listing { get; set; }
}

public partial class Listing
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("dir")]
	public string Dir { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("root_dir")]
	public string RootDir { get; set; }

	[JsonProperty("href_path")]
	public string HrefPath { get; set; }

	[JsonProperty("size")]
	public long Size { get; set; }

	[JsonProperty("modified")]
	public string Modified { get; set; }

	[JsonProperty("created")]
	public string Created { get; set; }

	[JsonProperty("owner")]
	public string Owner { get; set; }

	[JsonProperty("group")]
	public string Group { get; set; }

	[JsonProperty("permissionsNum")]
	public string PermissionsNum { get; set; }

	[JsonProperty("keywords")]
	public string Keywords { get; set; }

	[JsonProperty("permissions")]
	public string Permissions { get; set; }

	[JsonProperty("num_items")]
	public long NumItems { get; set; }

	[JsonProperty("preview")]
	public long Preview { get; set; }

	[JsonProperty("dateFormatted")]
	public string DateFormatted { get; set; }

	[JsonProperty("createdDateFormatted")]
	public string CreatedDateFormatted { get; set; }

	[JsonProperty("sizeFormatted")]
	public string SizeFormatted { get; set; }
}

public partial class CrushFtpResult
{
	public static CrushFtpResult FromJson(string json) => JsonConvert.DeserializeObject<CrushFtpResult>(json, Converter.Settings);
}

public static class Serialize
{
	public static string ToJson(this CrushFtpResult self) => JsonConvert.SerializeObject(self, Converter.Settings);
}

internal static class Converter
{
	public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
	{
		MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
		DateParseHandling = DateParseHandling.None,
		Converters =
		{
			new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
		},
	};
}
