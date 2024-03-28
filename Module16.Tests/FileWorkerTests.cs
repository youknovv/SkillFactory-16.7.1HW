using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Module16.Tests
{
    [TestFixture]
    public class FileWorkerTests
    {
        [Test]
        public void SaveTicket()
        {
            var fileWorker = new FileWorker();

            PrivateObject obj = new PrivateObject(fileWorker);

            var result = obj.Invoke("GetSafeFilename", "<Привет>");

            Assert.AreEqual(result,"_Привет_");
        }
    }
}