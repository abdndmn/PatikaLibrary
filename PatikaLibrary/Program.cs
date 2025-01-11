using PatikaLibrary;

Books book1 = new Books();//New,Nesne olusturma, Default Constructor kullanıldı.

book1.BookName = "Adı Aylin";
book1.AuthorName = "Ayşe";
book1.AuthorSurname = "Kulin";
book1.PageNumber = 398;
book1.Publisher = "Remzi Kitabevi";
book1.RegisterDate = DateTime.Now;

Console.WriteLine("Kitap Adı: "+book1.BookName+"\nYazar Adı, Soyadı : "+book1.AuthorName+" "+book1.AuthorSurname+"\nSayfa Sayısı: "+book1.PageNumber+"\nYayınevi: "+book1.Publisher+"\nKayıt Tarihi: "+book1.RegisterDate);

Books book2 = new Books("Adı Aylin","Ayşe","Kulin",398,"Remzi Kitabevi");//New, Alternatif constructor kullanarak nesne olusturma 

Console.WriteLine("Kitap Adı: " + book2.BookName + "\nYazar Adı, Soyadı : " + book2.AuthorName + " " + book2.AuthorSurname + "\nSayfa Sayısı: " + book2.PageNumber + "\nYayınevi: " + book2.Publisher + "\nKayıt Tarihi: " + book2.RegisterDate);