﻿using System.IO;

namespace Module16
{
    public class FileWorker
    {
        private string GetSafeFilename(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }
    }
}