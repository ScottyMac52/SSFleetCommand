using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SSFleetCommandModels.Util
{
    public class CSVConverter<T> where T : new()
    {
        public string Path { get; set; }
        public int SkipLines { get; set; }
        public int TakeLines { get; set; }
        public List<T> Results { get; protected set; }

        public CSVConverter()
        {
            Properties = typeof(T).GetRuntimeProperties();
            Results = new List<T>();
        }

        protected string[] AllLines { get; set; }
        protected string HeaderLine => AllLines?.Skip(SkipLines).Take(TakeLines).FirstOrDefault();
        protected string[] Headers => HeaderLine?.Split(',');
        protected IEnumerable<string> DataLines => AllLines?.Skip(SkipLines + TakeLines);
        protected IEnumerable<PropertyInfo> Properties { get; set; }

        public async Task<bool> ExecuteAsync()
        {
            AllLines = await File.ReadAllLinesAsync(Path);

            Parallel.ForEach(DataLines, (dataLine) => {
                var result = new T();
                var lineData = dataLine.Split(',');
                int elementCount = 0; 
                Parallel.ForEach(lineData, (element) =>
                {
                    var currentProperty = Properties.FirstOrDefault(prop => prop.Name.ToLower() == Headers?[elementCount]?.ToLower());
                    if (currentProperty != null)
                    {
                        currentProperty.SetValue(result, element);
                    }
                    elementCount++;
                });
                Results.Add(result);
            });
            return true;
        }


        public bool Execute()
        {
            AllLines = File.ReadAllLines(Path);

            foreach(var dataLine in DataLines)
            {
                var result = new T();
                var lineData = dataLine.Split(',');
                int elementCount = 0;

                foreach (var element in lineData )
                {
                    var currentProperty = Properties.FirstOrDefault(prop => prop.Name.ToLower() == Headers?[elementCount]?.ToLower());
                    if(currentProperty != null)
                    {
                        currentProperty.SetValue(result, element);            
                    }
                    elementCount++;
                }
                Results.Add(result);
            }
            return true;

        }
    }
}
