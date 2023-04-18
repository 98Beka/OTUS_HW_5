using Newtonsoft.Json;

namespace Serilize {
    public class F {
        [JsonProperty]
        public int I1 { get; set; }
        [JsonProperty]
        int i2 { get; set; }
        [JsonProperty]
        int i3 { get; set; }
        [JsonProperty]
        int i4 { get; set; }
        [JsonProperty]
        int i5 { get; set; }
        [JsonProperty]
        double f1 { get; set; }
        public F Get() => new F() { I1 = 11, i2 = 22, i3 = 33, i4 = 44, i5 = 55, f1 = 32.42 };
    }
}
