using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.Json;
using System.IO;

namespace GraDetektywistyczna
{
    class JSON2
    {
        public string a;
        public void JSON(string _a)
        {
            a = _a;

            try
            {
                string fileName = a;
                string jsonFromFile = File.ReadAllText(fileName);
                JSON1 objectFromJson = JsonSerializer.Deserialize<JSON1>(jsonFromFile);
                objectFromJson.ShowElements();
            }
            catch (Exception exc)
            {
                WriteLine(exc.Message);
            }

        }
    }
}
