using System;

namespace ImgThumbnailApp.Web.Models;

public class FileDownloadDto
{
  public string FileName { get; set; } = string.Empty;
  public string ContentType { get; set; } = string.Empty;
  public Stream FileStream { get; set; } = Stream.Null;
}
