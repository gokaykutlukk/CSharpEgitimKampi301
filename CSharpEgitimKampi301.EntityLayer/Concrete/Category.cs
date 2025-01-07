using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category

    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public  List<Product> Products{ get; set; }
    }
}













//int x; Field

//public int y {get; set;} bu property

// void test()
//{
//  int x; dersen vairable olur
//}




/*
 //field-variable-property// arasındaki farklar nelerdir  */

//int x; --> Field direkt sınıfın içine tanımlanırsa
//get ve set alırsa sonun aproperty oluyor
//methot içine tanımlanırsa variable