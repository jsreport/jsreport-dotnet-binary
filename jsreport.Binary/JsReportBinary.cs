using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;

namespace jsreport.Binary
{
    public class JsReportBinary
    {
        /// <summary>
        /// Get jsreport executable from the assembly manifest stream
        /// </summary>        
        public static Stream GetStream()
        { 
            var assembly = typeof(JsReportBinary).GetTypeInfo().Assembly;
            var zip = new ZipArchive(assembly.GetManifestResourceStream("jsreport.Binary.jsreport.zip"));
            return zip.Entries.First().Open();            
        }
    }
}
