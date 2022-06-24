using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OP1
{
    class Polynomejson
    {
        public static void Serialize(Polynome polynome)
        {
            string objectToSerialize = JsonConvert.SerializeObject(polynome);
            File.WriteAllText("C:/Users/Sasha/OneDrive/Desktop/Лабы/ОП/OP1/OP1/OP1/1.json", objectToSerialize);
        }

        public static Polynome Deserialize(string path)
        {
            string json = File.ReadAllText(path);
            Polynome polynome = JsonConvert.DeserializeObject<Polynome>(json);
            return polynome;

        }
    }
}

