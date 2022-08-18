# toDo
### Yeni bir console uygulamasý açarak bir 3 kolondan oluþan bir TODO uygulamasý yazýnýz. Uygulamada olmasý gereken özellikler aþaðýdaki gibidir.

- Kart Ekle
- Kart Güncelle
- Kart Sil
- Kart Taþý
- Board Listeleme

Kart Ýçeriði



Baslýk
Icerik
Atanan Kisi (Takým üyeleriþnden biri olmalý)
Büyüklük (XS, S, M, L, XL)


Açýklama:



Board TODO - IN PROGRESS - DONE kolonlarýndan oluþmalý.


Varsayýlan olarak bir board tanýmlý olmalý ve 3 tane de kart barýndýrmalý.(Kartlar herhangi bir line'da yani kolonda olabilir.)


Kartlar ancak takýmdan birine atanabilir. Takýmdaki kiþiler ise varsayýlan olarak tanýmlanmalý. Takým üyeleri Dictionary kullanýlarak key-value pair þeklinde ya da bir sýnýf aracýlýðýyla tutulabilir. Kartlara atama yapýlýrken takým üyeleri ID leri ile atanacak. Yani kullanýlacak yapýnýn mutlaka bir ID içermesi gerekir.


Uygulama ilk baþladýðýnda kullanýcýya yapmak istediði iþlem seçtirilir.

 Lütfen yapmak istediðiniz iþlemi seçiniz :) 
  *******************************************
  (1) Board Listelemek
  (2) Board'a Kart Eklemek
  (3) Board'dan Kart Silmek
  (4) Kart Taþýmak
  
  (1) Board Listelemek


 TODO Line
 ************************
 Baþlýk      :
 Ýçerik      :
 Atanan Kiþi :
 Büyüklük    :
 -
 Baþlýk      :
 Ýçerik      :
 Atanan Kiþi :
 Büyüklük    :
 
 
 IN PROGRESS Line
 ************************
 Baþlýk      :
 Ýçerik      :
 Atanan Kiþi :
 Büyüklük    :
 -
 Baþlýk      :
 Ýçerik      :
 Atanan Kiþi :
 Büyüklük    :


 DONE Line
 ************************
 ~ BOÞ ~


(2) Board'a Kart Eklemek


 Baþlýk Giriniz                                  : 
 Ýçerik Giriniz                                  :
 Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :
 Kiþi Seçiniz                                    : 
**Büyüklükler Enum olarak saklanmalý. Kart üzerinde gösterilirken XS olarak gösterilmeli. Giriþ yapýlýrken kullanýcýdan 1 alýnmalýdýr.



**Takým üyeleri mevcut bir listede daha tanýmlanmýþ olamlýdýr.(Program içerisinde dinamik tanýmlanmasýna gerek yok.) Kart tanýmlarken takým üyesinin ID'si istenmeli. Tanýmlý bir ID deðilse "Hatalý giriþler yaptýnýz!" uyarýsý ile iþlem iptal edilebilir.



(3) Board'a Kart Silmek


 Öncelikle silmek istediðiniz kartý seçmeniz gerekiyor.
 Lütfen kart baþlýðýný yazýnýz:  


Kart bulunamaz ise:



 Aradýðýnýz krtiterlere uygun kart board'da bulunamadý. Lütfen bir seçim yapýnýz.
 * Silmeyi sonlandýrmak için : (1)
 * Yeniden denemek için : (2)
** Ayný isimde birden fazla kart bulunursa her ikisi de silinebilir.



(4) Kart Taþýmak


 Öncelikle silmek istediðiniz kartý seçmeniz gerekiyor.
 Lütfen kart baþlýðýný yazýnýz:  


Kart bulunamaz ise:



 Aradýðýnýz krtiterlere uygun kart board'da bulunamadý. Lütfen bir seçim yapýnýz.
 * Ýþlemi sonlandýrmak için : (1)
 * Yeniden denemek için : (2)


Kart bulunur ise:



 Bulunan Kart Bilgileri:
 **************************************
 Baþlýk      :
 Ýçerik      :
 Atanan Kiþi :
 Büyüklük    :
 Line        :

 Lütfen taþýmak istediðiniz Line'ý seçiniz: 
 (1) TODO
 (2) IN PROGRESS
 (3) DONE
** Doðru bir seçim yapýlýrsa board listelenerek (1) Board Listelemek kullanýlarak kullanýcýya gösterilir. Seçim doðru deðil ise "Hatalý bir seçim yaptýnýz!" bilgisi ile iþlem sonlandýrýlabilir.


NOT: Uygulamanýn yapýsý genel olarak aþaðýdaki gibi olmalýdýr:


Board 3 tane Line dan oluþur.
Her bir line bir kart listesi tutar
Kartlarýn büyüklükleri pre-defined olan bir enum'da tutulur.
Kart sadece takým üyelerinden birine atanabilir.
Takým üyeleri daha önceden varsayýla olarak tanýmlanmýþ bir listede olmalý. Struct, class ya da bir koleksiyon kullanýlabilir.
