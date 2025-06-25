//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Addition_overloading add = new Addition_overloading();
//        int intresult = add.addd(5, 10);
//        float floatresuklt = add.addd(10.2f, 15.15f);
//        Console.WriteLine(floatresuklt);
//        Console.WriteLine(intresult);
//    }
//}



//public class Program
//{
//    public static void Main(string[] args)
//    {
//        tri_sqare ts = new tri_sqare();
//        int squareArea = ts.Area(5); 
//        int triangleArea = ts.Area(5, 10); 
//    }
//}


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        RBI rbi = new RBI();
//        rbi.CalculateIterest(1000, 5, 2);
//        HDFC hdfc = new HDFC();
//        hdfc.CalculateIterest(1000, 5, 3);
//        SBI sbi = new SBI();
//        sbi.CalculateIterest(1000, 5, 4);
//        ICICI icici = new ICICI();
//        icici.CalculateIterest(1000, 5, 5);
//    }
//}


public class Program
{
    public static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        hospital.HospitalDetails();
        Apollo apollo = new Apollo();
        apollo.HospitalDetails();
        Wockhardt wockhardt = new Wockhardt();
        wockhardt.HospitalDetails();
        Gokul_Superspeciality gokul = new Gokul_Superspeciality();
        gokul.HospitalDetails();
    }
}