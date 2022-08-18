# toDo
### Yeni bir console uygulamas� a�arak bir 3 kolondan olu�an bir TODO uygulamas� yaz�n�z. Uygulamada olmas� gereken �zellikler a�a��daki gibidir.

- Kart Ekle
- Kart G�ncelle
- Kart Sil
- Kart Ta��
- Board Listeleme

Kart ��eri�i



Basl�k
Icerik
Atanan Kisi (Tak�m �yeleri�nden biri olmal�)
B�y�kl�k (XS, S, M, L, XL)


A��klama:



Board TODO - IN PROGRESS - DONE kolonlar�ndan olu�mal�.


Varsay�lan olarak bir board tan�ml� olmal� ve 3 tane de kart bar�nd�rmal�.(Kartlar herhangi bir line'da yani kolonda olabilir.)


Kartlar ancak tak�mdan birine atanabilir. Tak�mdaki ki�iler ise varsay�lan olarak tan�mlanmal�. Tak�m �yeleri Dictionary kullan�larak key-value pair �eklinde ya da bir s�n�f arac�l���yla tutulabilir. Kartlara atama yap�l�rken tak�m �yeleri ID leri ile atanacak. Yani kullan�lacak yap�n�n mutlaka bir ID i�ermesi gerekir.


Uygulama ilk ba�lad���nda kullan�c�ya yapmak istedi�i i�lem se�tirilir.

 L�tfen yapmak istedi�iniz i�lemi se�iniz :) 
  *******************************************
  (1) Board Listelemek
  (2) Board'a Kart Eklemek
  (3) Board'dan Kart Silmek
  (4) Kart Ta��mak
  
  (1) Board Listelemek


 TODO Line
 ************************
 Ba�l�k      :
 ��erik      :
 Atanan Ki�i :
 B�y�kl�k    :
 -
 Ba�l�k      :
 ��erik      :
 Atanan Ki�i :
 B�y�kl�k    :
 
 
 IN PROGRESS Line
 ************************
 Ba�l�k      :
 ��erik      :
 Atanan Ki�i :
 B�y�kl�k    :
 -
 Ba�l�k      :
 ��erik      :
 Atanan Ki�i :
 B�y�kl�k    :


 DONE Line
 ************************
 ~ BO� ~


(2) Board'a Kart Eklemek


 Ba�l�k Giriniz                                  : 
 ��erik Giriniz                                  :
 B�y�kl�k Se�iniz -> XS(1),S(2),M(3),L(4),XL(5)  :
 Ki�i Se�iniz                                    : 
**B�y�kl�kler Enum olarak saklanmal�. Kart �zerinde g�sterilirken XS olarak g�sterilmeli. Giri� yap�l�rken kullan�c�dan 1 al�nmal�d�r.



**Tak�m �yeleri mevcut bir listede daha tan�mlanm�� olaml�d�r.(Program i�erisinde dinamik tan�mlanmas�na gerek yok.) Kart tan�mlarken tak�m �yesinin ID'si istenmeli. Tan�ml� bir ID de�ilse "Hatal� giri�ler yapt�n�z!" uyar�s� ile i�lem iptal edilebilir.



(3) Board'a Kart Silmek


 �ncelikle silmek istedi�iniz kart� se�meniz gerekiyor.
 L�tfen kart ba�l���n� yaz�n�z:  


Kart bulunamaz ise:



 Arad���n�z krtiterlere uygun kart board'da bulunamad�. L�tfen bir se�im yap�n�z.
 * Silmeyi sonland�rmak i�in : (1)
 * Yeniden denemek i�in : (2)
** Ayn� isimde birden fazla kart bulunursa her ikisi de silinebilir.



(4) Kart Ta��mak


 �ncelikle silmek istedi�iniz kart� se�meniz gerekiyor.
 L�tfen kart ba�l���n� yaz�n�z:  


Kart bulunamaz ise:



 Arad���n�z krtiterlere uygun kart board'da bulunamad�. L�tfen bir se�im yap�n�z.
 * ��lemi sonland�rmak i�in : (1)
 * Yeniden denemek i�in : (2)


Kart bulunur ise:



 Bulunan Kart Bilgileri:
 **************************************
 Ba�l�k      :
 ��erik      :
 Atanan Ki�i :
 B�y�kl�k    :
 Line        :

 L�tfen ta��mak istedi�iniz Line'� se�iniz: 
 (1) TODO
 (2) IN PROGRESS
 (3) DONE
** Do�ru bir se�im yap�l�rsa board listelenerek (1) Board Listelemek kullan�larak kullan�c�ya g�sterilir. Se�im do�ru de�il ise "Hatal� bir se�im yapt�n�z!" bilgisi ile i�lem sonland�r�labilir.


NOT: Uygulaman�n yap�s� genel olarak a�a��daki gibi olmal�d�r:


Board 3 tane Line dan olu�ur.
Her bir line bir kart listesi tutar
Kartlar�n b�y�kl�kleri pre-defined olan bir enum'da tutulur.
Kart sadece tak�m �yelerinden birine atanabilir.
Tak�m �yeleri daha �nceden varsay�la olarak tan�mlanm�� bir listede olmal�. Struct, class ya da bir koleksiyon kullan�labilir.
