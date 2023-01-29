using System;
using System.Collections.Generic;


namespace MapChanger
{
    public class Config
    {
        public List<Map> Maps { get; set; }

        public string TrainingMap { get; set; }


        public string TrainingImage { get; set; }

        public string DefaultImage { get; set; }

        public string ButtonIdle { get; set; }

        public string ButtonHover { get; set; }

        public string Assets { get; set; }

        public string PaladinsFolder { get; set; }

        public string GetImage(string filename)
        {
            return Assets + "\\" + filename + ".png";
        }

        public string GetMap(string filename)
        {
            return Assets + "\\" + filename + ".upk";
        }



    }
}
