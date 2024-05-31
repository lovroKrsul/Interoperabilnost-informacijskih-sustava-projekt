using System.Runtime.Serialization;

namespace ISS_RestService.Models
{
    [DataContract]
    public class Game
    {
            [DataMember(Order = 0)]
            public string ID { get; set; }

            [DataMember(Order = 1)]
            public string Publisher { get; set; }

            [DataMember(Order = 2)]
            public string title { get; set; }
            [DataMember(Order = 2)]
            public string ganre { get; set; }
            [DataMember(Order = 2)]
            public string price { get; set; }
            [DataMember(Order = 2)]
            public string desription { get; set; }

    }
    
}