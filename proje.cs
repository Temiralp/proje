using System;

class Program
{
    // Öğretmen ve öğrenci bilgileri için ayrı ayrı değişkenler
    static string teacher1Name;
    static string teacher1Subject;
    static string student1Name;
    static string student1Major;


    // Öğretmen ve öğrenci bilgilerini yazdıran ayrı ayrı fonksiyonlar
    static void PrintTeacherInfo()
    {
        Console.WriteLine("Öğretmen Adı: " + teacher1Name);
        Console.WriteLine("Öğretmenin Dersi: " + teacher1Subject);
    }

    static void PrintStudentInfo()
    {
        Console.WriteLine("Öğrenci Adı: " + student1Name);
        Console.WriteLine("Öğrencinin Bölümü: " + student1Major);
    
    }

    static void Main()
    {
        // Öğretmen ve öğrenci bilgilerini atıyoruz
        teacher1Name = "Ahmet";
        teacher1Subject = "Matematik";
        student1Name = "Ayşe";
        student1Major = "Bilgisayar Mühendisliği";
        student1Advisor = teacher1Name;  // Danışman olarak öğretmeni atıyoruz

        // Bilgileri yazdırıyoruz
        PrintTeacherInfo();
        PrintStudentInfo();
    }

    static void Main2()
    {
        // Öğretmen ve öğrenci bilgilerini atıyoruz
        teacher1Name = "Ahmet";
        teacher1Subject = "Matematik";
        student1Name = "Ayşe";
        student1Major = "Bilgisayar Mühendisliği";
        student1Advisor = teacher1Name;  // Danışman olarak öğretmeni atıyoruz

        // Bilgileri yazdırıyoruz
        PrintTeacherInfo();
        PrintStudentInfo();
    }
    static void Main2()
    {
        // Öğretmen ve öğrenci bilgilerini atıyoruz
        teacher1Name = "Ahmet";
        teacher1Subject = "Matematik";
        student1Name = "Ayşe";
        student1Major = "Bilgisayar Mühendisliği";
        student1Advisor = teacher1Name;  // Danışman olarak öğretmeni atıyoruz

        // Bilgileri yazdırıyoruz
        PrintTeacherInfo();
        PrintStudentInfo();
    }
}