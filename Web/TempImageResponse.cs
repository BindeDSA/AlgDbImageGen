using Nancy.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Nancy;

namespace PuzzleImageGenerator.Web
{
    public class TempImageResponse : Response
    {
        private Stream source;
        private string filePathSource;
        public TempImageResponse(string filePathSource, string contentType)
        {
            Func<Stream> source = () => File.OpenRead(filePathSource);
            this.filePathSource = filePathSource;
            this.Contents = GetResponseBodyDelegate(source);
            this.ContentType = contentType;
            this.StatusCode = HttpStatusCode.OK;
        }

        private Action<Stream> GetResponseBodyDelegate(Func<Stream> sourceDelegate)
        {
            return stream =>
            {
                using (this.source = sourceDelegate.Invoke())
                {
                    this.source.CopyTo(stream);
                }
            };
        }

        public override void Dispose()
        {
            if (this.source != null)
            {
                this.source.Dispose();
            }
            File.Delete(filePathSource);
        }
    }
}