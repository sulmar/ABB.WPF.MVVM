using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.WPF.MVVM.Models;
using System.IO;
using System.Threading;

namespace ABB.WPF.MVVM.Services
{
    public class FilePageContentService : IPageContentService
    {
        private const string BaseDir = @"DataStore";

        public PageContent Get(string name)
        {
            string filename = Path.Combine(BaseDir, name.ToLower() + ".txt");
                
            var lines = File.ReadAllLines(filename);

            PageContent pageContent = new PageContent();

            foreach (var line in lines)
            {
                pageContent.Items.Add(Map(line));
            }

         //   Thread.Sleep(TimeSpan.FromSeconds(5));

            return pageContent;
        }

        private PageItem Map(string line, char separator = '|')
        {
            string[] values = line.Split(separator);

            PageItem item = new PageItem
            {
                PageItemId = int.Parse(values[0]),
                Name = values[1],
                Type = values[2],
            };

            if (values.Length > 3)
            {
                item.Parameters = values[3];

                switch(item.Type)
                {
                    case "TextBox": item.Value = item.Parameters; break;
                }
                
            }

            return item;

            


        }
    }
}
