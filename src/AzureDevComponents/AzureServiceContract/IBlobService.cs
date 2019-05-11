using System.IO;

namespace AzureServiceContract
{
    public interface IBlobService
    {
        string GetBlobUrl(string fileName);

        Stream GetBlobStream(string fileName);

        void UploadBlob(byte[] data);

        void Delete(string fileName);

        void AppnedBlob(byte[] data);
    }
}