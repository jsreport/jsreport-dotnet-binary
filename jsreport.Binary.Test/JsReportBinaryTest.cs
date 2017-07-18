using NUnit.Framework;
using Shouldly;
using System;
using System.Diagnostics;
using System.IO;

namespace jsreport.Binary.Test
{
    [TestFixture]
    public class JsReportBinaryTest
    {
        [Test]
        public void ExtractAndRunJsReportBinary()
        {            
            var tmpFile = Path.GetTempFileName();

            using (var fs = File.Create(tmpFile))
            {
                JsReportBinary.GetStream().CopyTo(fs);
            }

            var p = Process.Start(tmpFile, "--version");

            p.WaitForExit();

            p.ExitCode.ShouldBe(0);
        }
    }
}
