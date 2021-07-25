using System;


namespace İnnertypeÖdevProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ürün m1 = new Ürün();
            Ürün.ekmek e1 = new Ürün.ekmek();
            e1.Markalar = "pastek";
            object m10 = new object();
            m10 = 20;
            Console.WriteLine(m10.GetType());
            
        }
    }

    class Ürün
    {
        public string Markalar { get; set; }
        


        public class ekmek : Ürün
        {
            public int agırılık { get; set; }
            public string cesit { get; set; }
            public string tür { get; set; }
        }
    }
    

}
    