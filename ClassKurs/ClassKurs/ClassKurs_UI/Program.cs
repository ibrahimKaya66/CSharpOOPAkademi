using System;
using Classes;

namespace ClassKurs_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Katmanlı yapıda bir akademi örneği(.Net Core) 
             * İlk katman sadece main metodu olacak(program.cs)
             * Diğer katmanlarda Classlar olacak
             * 
             * User diye bir base class bu class abstract olacak
             * User clası ad,soyad,ctor da tüm kurslar listesini görüntüleyebilsin,abstract metodu Kursları Listele 
             * 
             * Kurs Class
             * property:ad,toplam_sure,haftalık_saat,
             * baslangictarih,bitis tarihi
             * ctor 2 yazılacak
             * Encapculation adı en 3 en fazla 20
             * baslangıc tarihi datetime.now dan önce olmaz
             * Egitmeni olacak
             * 
             * 
             * Eğitmen Class : User
             * kurs listele List<Kurs>kurslar 
             * kurs oluşturacacak metot(Kurs kurs)
             * 
             * Ogrenci Class : User
             * kurs listele List<Kurs>kurslar 
             * kursa katıl(kurs kurs)
             * 
             * 
             * program.cs
             * Eğitmen oluşturacak
             * Eğitmen.KursOluştur(new kurs())
             * 
             * Ogrenciler nesnesi kursa katılacak
             * 
             * Kurs bilgileri
             * ad,baslangıc tarihi,
             * bitiş tarihi,
             * eğitmen adını,
             * Öğrenci sayısı
              */

            Course web = new Course("Web-Akşam", 600, 25, DateTime.Now.AddDays(7));
            Course sistem = new Course("Sistem-Sabah", 400, 25, DateTime.Now.AddDays(10));
            Course erp = new Course("Erp-Akşam", 500, 25, DateTime.Now.AddDays(8));

            CourseManager.courses.Add(web);
            CourseManager.courses.Add(sistem);
            CourseManager.courses.Add(erp);
            Educator ibrahim = new Educator("ibrahim", "kaya");
            Educator hakan = new Educator("Hakan", "Üstün");

            Student yusuf = new Student("Yusuf", "Uluocak");
            Student omer = new Student("Omer", "ilker");
            Student onur = new Student("Onur", "Püsküllü");
            Student omer2 = new Student("Omer", "Kavak");
            Student Atahan = new Student("Atahan", "Yıldırım");

            ibrahim.CreateCourse(web);
            ibrahim.CreateCourse(erp);
            hakan.CreateCourse(sistem);

            yusuf.joinCourse(web);
            omer.joinCourse(web);
            onur.joinCourse(sistem);
            omer2.joinCourse(sistem);
            Atahan.joinCourse(erp);

            Console.WriteLine("İbrahim hocanın vermiş olduğu kurslar");
            ibrahim.CoursesToList().ForEach(x => Console.WriteLine($"{x.Name} {x.educator.name} {x.educator.surname} {x.totalHour} {x.students.Count}  {x.StartDate} -  {x.endDate}"));

            Console.WriteLine("Yusuf un Almış olduğu kurslar");
            yusuf.CoursesToList().ForEach(x => Console.WriteLine($"{x.Name} {x.educator.name} {x.educator.surname} {x.totalHour}"));

            Console.WriteLine($"Web Kursu Listesi {web.educator.name} {web.educator.surname}");
            web.students.ForEach(x => Console.WriteLine($"{x.name} {x.surname}"));

            Console.WriteLine("Bütün Kurslar Bilgisi");
            CourseManager.CourseList();

            Console.Read();

        }
    }
}
