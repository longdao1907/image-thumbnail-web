using System;

namespace ImgThumbnailApp.Web.Models;

public class DownloadThumbnailDto
{
  public Guid ImageId { get; set; }
  public Stream ThumbnailStream { get; set; } = new MemoryStream();
  public string ContentType { get; set; } = string.Empty;
  public long? FileSize { get; set; }

}
