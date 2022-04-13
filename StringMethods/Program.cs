string str1="Dersimiz CSharp, Hoşgeldiniz";
string str2="Dersimiz CSharp";

//Karakter Sayısı
Console.WriteLine(str1.Length);

//Tüm harfleri küçült/büyüt
Console.WriteLine(str1.ToUpper());
Console.WriteLine(str2.ToLower());

//Birleştir
Console.WriteLine(string.Concat(str1,"Hello World"));

//Karşılaştır
Console.WriteLine(str1.CompareTo(str2));//0,1,-1 değerlerini geri döner.//ASCII tablosuna göre alfabetik karşlılaştırır.
Console.WriteLine(string.Compare(str1,str2,true));//Büyük, küçük harf duyarsızdır.
Console.WriteLine(string.Compare(str1,str2,false));//Büyük, küçük harf duyarlıdır.

//İçeriyormu
Console.WriteLine(str1.Contains(str2));
Console.WriteLine(str1.EndsWith("World"));
Console.WriteLine(str1.StartsWith("Ders"));

//İndex nosu
Console.WriteLine(str1.IndexOf("Nurgül"));//İçermiyorsa -1 döner
Console.WriteLine(str2.IndexOf("CS"));//İçeriyor index no 9 dan itibaren

//Ekleme yapmak
Console.WriteLine(str1.Insert(0,"Merhaba!"));//0. indexten başalayarak ekler.
Console.WriteLine(str1.LastIndexOf("Nurgül"));//Son indexten başlayarak ekler.

//Boşluk  yakalamak
Console.WriteLine(str1.PadLeft(30));//Karakter sayısını değere tamamlar.Boşluklar ekler/Yada verdiğimiz karakteri ekler.
Console.WriteLine(str1+str2.PadRight(30,'*'));

//Kaldırır
Console.WriteLine(str2.Remove(10));//10. indexten itibaren hepsini kaldırır.
Console.WriteLine(str2.Remove(2,5));//2 dahil 5 dahil değildir.

//Değiştir
Console.WriteLine(str2.Replace("CSharp","C#"));

//Parçalamak
Console.WriteLine(str1.Split(' ')[0]);//Boşluklara göre parçala 0. indexi yaz.

//Alt karakterlere parçalamak
Console.WriteLine(str1.Substring(4));//4.İndexten itibare böl ve devamının al
Console.WriteLine(str1.Substring(4,6));//4.indexten itibaren böl ve 6 karakter al