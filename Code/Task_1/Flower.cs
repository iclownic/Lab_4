using System;

namespace Task_1
{
    class Petal //Пелюстки
    {
        public string Colour { get; set; }
        public Petal (string colour)
        { 
            Colour = colour; 
        }

        public override bool Equals(object obj)
        {
            if (obj is Petal petal)
                return Colour == petal.Colour;
            return false;
        }

        public override int GetHashCode()
        {
            return Colour.GetHashCode();
        }

        public override string ToString()
        {
            return $"Колiр пелюстки: {Colour}";
        }
    }


    class Bud // Бутон
    {
        public string Colour { get; set; }
        public bool IsOpen { get; set; }

        public Bud (string colour, bool open)
        {
            Colour=colour;
            IsOpen=open;
        }
        public override bool Equals(object obj)
        {
            if (obj is Bud bud)
                return Colour == bud.Colour && IsOpen == bud.IsOpen;
            return false;
        }

        public override int GetHashCode()
        {
            return Colour.GetHashCode() & IsOpen.GetHashCode();
        }

        public override string ToString()
        {
            return $"Колiр бутону: {Colour} \nБутон розкритий? {IsOpen}";
        }
    }

    class Flower //Квітка
    {
        private Petal [] petals;
        private Bud bud;

        public Flower(Bud bud, params Petal[] petals)

        {
            this.bud = bud;
            this.petals = petals;

        }

        public void Blossom()
        {
            if (bud.IsOpen)
            {
                Console.WriteLine("\n*Квiтка цвiте*\n");
                foreach (var petal in petals)
                {
                    Console.WriteLine(petal);
                }
            }
            else
                Console.WriteLine("\n*Квiтка в'яне*");
        }
    }
}
