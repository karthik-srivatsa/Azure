using AzureServiceContract;
using System.IO;

namespace AzureServiceImplementation
{
    public class BlobServices : IBlobService
    {
        public void AppnedBlob(byte[] data)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public Stream GetBlobStream(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public string GetBlobUrl(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void UploadBlob(byte[] data)
        {
            throw new System.NotImplementedException();
        }
    }
}