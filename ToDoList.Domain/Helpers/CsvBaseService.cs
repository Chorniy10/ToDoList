using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Helpers
{
    public class CsvBaseService<T>
    {
        private readonly CsvConfiguration _csvConfiguration;
        public CsvBaseService()
        {
            _csvConfiguration = GetConfiguration();
        }

        public byte[] UploadFile(IEnumerable data)
        {
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(streamWriter, _csvConfiguration))
            {
                csvWriter.WriteRecords(data);
                streamWriter.Flush();
                return memoryStream.ToArray();
            }
        }

        private CsvConfiguration GetConfiguration() 
        {
            return new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                Encoding = Encoding.UTF8,
                NewLine = "\r\n"
            };
        }
    }
}
