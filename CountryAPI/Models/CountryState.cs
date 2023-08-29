namespace CountryAPI.Models
{


    public class CountryState
    {
        public bool error { get; set; }
        public string msg { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string name { get; set; }
        public State[] states { get; set; }
    }

    public class State
    {
        public string name { get; set; }
        public string state_code { get; set; }
    }

}
