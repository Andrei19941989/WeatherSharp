namespace Weather
{
    public class Weatherclass
    {
        public Main main;
        public WeatherMain[] weather;
        public string name;

        public override string ToString()
        {
            string k = name + " " + (main.temp -273) + " " + " " + main.pressure + "\n" + weather[0].main + " " +
                       weather[0].description;
            return k;

        }
    }
    
}