using System;

namespace operatorler
{
  class Program
  {
    static void Main(string[] args)
    { 
      for (int i = 0; i < 2; i++) 
      {
        int kredi = 200;
        int bakiye = 100;

      Console.WriteLine("X bank'a hosgeldiniz.");  
      Console.WriteLine("Isminiz ne?"); 
      string username = Console.ReadLine();
      Console.WriteLine("Welcome " + username); 
      Console.WriteLine("Para cekme = 1 || Para yatirma = 2");
      Console.WriteLine("Islem numarasini giriniz: ");
      int choice = Convert.ToInt32(Console.ReadLine());
     
      if (choice == 1)
      {
          Console.WriteLine("Islem para cekme islemini sectiniz"); 
          Console.WriteLine("Bakiyeniz :" + bakiye); 
          Console.WriteLine("Ne kadar para cekeceksiniz?"); 
          int paracekme = Convert.ToInt32(Console.ReadLine());
          if (paracekme > bakiye)
           {
             Console.WriteLine("Paran yok kardesim ama istersen kredi cekebilirsin. Istiyor musun? (Evet / Hayir)"); 
             string kredistate = Console.ReadLine();
             if(kredistate ==  "Evet" ||  kredistate == "Hayir")
             {
               if(kredistate == "Evet")
               {
                     Console.WriteLine("Ne kredisi cekecen?"); 
                     Console.WriteLine("Ev = 1 || Araba = 2");
                     int choicekredituru = Convert.ToInt32(Console.ReadLine());
                     switch(choicekredituru)
                     {
                        case 1:
                           Console.WriteLine("Ne kadar kredi cekeceksiniz?"); 
                           int kredicekme = Convert.ToInt32(Console.ReadLine());
                           Console.WriteLine("Kac ay olacak?"); 
                           string kredimonth = Console.ReadLine();
                           float taksit = kredicekme / Convert.ToInt32(kredimonth);
                           Console.WriteLine("Aylik taksit : " + taksit); 
                           Console.WriteLine("Hayirli olsun evin"); 
                           break;
                        case 2:
                           Console.WriteLine("Ne kadar kredi cekeceksiniz?"); 
                           int kredicekme2 = Convert.ToInt32(Console.ReadLine());
                           Console.WriteLine("Kac ay olacak?"); 
                           string kredimonth2 = Console.ReadLine();
                           float taksit2 = kredicekme2 / Convert.ToInt32(kredimonth2);
                           Console.WriteLine("Aylik taksit : " + taksit2); 
                           Console.WriteLine("Hayirli olsun araban"); 
                           break;
                     }
                    
               }
               if(kredistate == "Hayir")
               {
                  Console.WriteLine("Iyi günler"); 
               }
             }
             else
             {
               Console.WriteLine("Lütfen bu ikisinden birini yaz Evet / Hayir"); 
             }
           }
           else
           {
            bakiye = bakiye - paracekme;
             Console.WriteLine("Bu kadar para cektiniz:" + paracekme); 
             Console.WriteLine("Bu kadar paraniz kaldi:" + bakiye); 
           } 
      } 
      else if  (choice == 2)
      {
         Console.WriteLine("Islem para yatirma"); 
      }
          Console.WriteLine("*********************************************************"); 
      }
    }
  }
}