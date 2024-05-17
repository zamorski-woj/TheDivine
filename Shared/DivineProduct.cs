using static System.Net.Mime.MediaTypeNames;

namespace TheDivine.Shared
{
    public class DivineProduct
    {
        public string[] imagePaths;
        public string name;
        public string description;

        public DivineProduct(string[] imagePaths, string name = "", string description = "")
        {
            this.imagePaths = imagePaths;
            this.name = name;
            this.description = description;
        }
        public DivineProduct(string imagePath, string name = "", string description = "")
        {
            this.imagePaths = new string[1];
            this.imagePaths[0] = imagePath;
            this.name = name;
            this.description = description;
        }


    }
    public static class ProductList
    {
        public static DivineProduct[] products =
        {
            new DivineProduct( new string[] {"pictures/images.png"}, "Praca wstrzymana", "The Divine nie jest skłonna płacić zleceniobiorcom, w związku z czym, ta strona istenieje zaledwie jako prezentacja możliwości twórcy."),


          new DivineProduct( new string[] {"pictures/rysunki/webp/1.webp", "pictures/rysunki/webp/2.webp", "pictures/rysunki/webp/24.webp"}, "Haute couture", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/5.webp", "pictures/rysunki/webp/7.webp"}, "Elegant", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/3.webp", "pictures/rysunki/webp/4.webp", "pictures/rysunki/webp/8.webp"}, "I'm sorry", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/9.webp", "pictures/rysunki/webp/10.webp", "pictures/rysunki/webp/11.webp"}, "Christmas", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/23.webp", "pictures/rysunki/webp/12.webp", "pictures/rysunki/webp/13.webp"}, "Folk", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/14.webp", "pictures/rysunki/webp/15.webp", "pictures/rysunki/webp/16.webp"}, "Easter", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/17.webp", "pictures/rysunki/webp/18.webp", "pictures/rysunki/webp/19.webp"}, "British", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/20.webp", "pictures/rysunki/webp/21.webp", "pictures/rysunki/webp/22.webp"}, "Warm me up", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/6.webp", "pictures/rysunki/webp/25.webp", "pictures/rysunki/webp/26.webp"}, "Glamour", ""),


          new DivineProduct( new string[] {"pictures/rysunki/webp/28.webp","pictures/rysunki/webp/29.webp", "pictures/rysunki/webp/30.webp"}, "Picnic", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/27.webp", "pictures/rysunki/webp/31.webp", "pictures/rysunki/webp/32.webp"}, "Birthday", ""),

          new DivineProduct( new string[] {"pictures/rysunki/webp/33.webp", "pictures/rysunki/webp/34.webp", "pictures/rysunki/webp/35.webp"}, "Halloween", ""),
    };
        public static string[] GetImages()
        {
            List<string> images = new List<string>();
            foreach (DivineProduct product in products)
            {
                foreach (string s in product.imagePaths)
                {
                    images.Add(s);
                }
            }
            return images.ToArray();
        }

        public static string Miniatures(string imagePath)
        {
            string first = imagePath.Substring(0, "pictures/rysunki/webp/".Length);
            string last = imagePath.Substring("pictures/rysunki/webp/".Length-1);
            imagePath= first + "mini" + last;
            return imagePath;
        }
    }
}
