using static System.Console;

namespace Book.Chapter_4{
    class MotorWay
    {
        // props
        public string Name { get; set;} 
        public string Type { get; set;} 
        public string Direction { get; set;} 
        public string Surface { get; set;} 
        public string Party { get; set;} 
        public int Lanes { get; set;} 
        public bool Toll { get; set; } 

        // default
        public MotorWay() { }

        // params
        public MotorWay(
            string name = "",
            string type = "Road",
            string direction = "W",
            string surface = "blacktop",
            string party ="",
            int lanes = 1,
            bool toll = false
        )
        {
            Name = name;
            Type = type;
            Direction = direction;
            Surface = surface;
            Party = party;
            Lanes = lanes > 0 ? lanes : 1;
            Toll = toll;
        }
            
        // display fullname
        public string FullName()
        {
            return $"Full name: {Name}, {Type}, {Direction}, {Surface}, {Party}";
        }
        public string FullNameToll()
        {
            return $"{FullName()}\n"
                + $"Toll: {(Toll ? "Yes" : "No")}"
            ;
        }

        // fullname+lanes
        public string FullNameLanes()
        {
            return $"{FullName()}\n"
                + $"Lanes: {Lanes}"
            ;
        }

        // override
        public override string ToString()
        {
            return $"Name: {Name}\n"
                + $"Type: {Type}\n"
                + $"Direction: {Direction}\n"
                + $"Surface: {Surface}\n"
                + $"Party: {Party}\n"
                + $"Lanes: {Lanes}\n"
                + $"Toll: {(Toll ? "Yes" : "No")}\n"                
            ;         
        }

    }
    class Question_3 {
        public static void Solution() {
            MotorWay way = new(
                name: InStr("name"),
                type: InStr("type"),
                direction: InStr("direction"),
                surface: InStr("surface"),
                party: InStr("party"),
                lanes: InInt("lanes"),
                toll: InBool("toll (y/n)")
            );
            WriteLine(way.FullName());
            WriteLine(way.FullNameToll());
            WriteLine(way.FullNameLanes());
            WriteLine(way.ToString());
        }
        static string InStr(string label)
        {
            Write($"Input {label}: ");
            return ReadLine();
        }
        static int InInt(string label)
        {
            return int.TryParse(InStr(label), out int value) ? value : 0;
        }
        static bool InBool(string label)
        {
            return InStr(label).ToLower() == "y";
        }
    }
}