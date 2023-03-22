using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SerializationWorkshop
{
    public class Serializator
    {
        public void Save(object obj)
        {
            Type type = obj.GetType();

            StringBuilder result = new StringBuilder();

            foreach (var prop in type.GetProperties())
            {
                result.Append($"{prop.Name}:{prop.GetValue(obj)}|:|");

            }
            using (StreamWriter writer = new StreamWriter($"../../../{type.Name}"))
            {
                writer.Write(writer.ToString());
            }
        }
    }
}
