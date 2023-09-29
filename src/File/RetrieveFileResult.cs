namespace NightCloud.Common.QueueMessaging.File;

public interface RetrieveFileResult
{
    public byte[] Bytes { get; }
    public double Size { get; }
}