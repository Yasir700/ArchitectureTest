Bu proje aşağıda belirtilen kararlara bir örnek olarak tasarlandı.

-  Componentler olabildiğince kendiyle ve child'larıyla etkileşim halinde olacaklar. Dışarıdaki objelerle iletişimleri olmamalı.
-  Sabit datalar singleton ya da static varlıklar yerine scriptable objelerle tutulabilir. Bunun temel faydası prefablara dahi inspector üzerinden aktarılabilmeleridir.
-  Varlıklar birbirlerini dinleyerek etkide bulunmalılar. Direk tanıyıp kullanma durumları pek sağlıklı değildir.
-  İnterface'ler ilgili kısımlarda bulunacaklar. Daha genele hitap edenler için özel yer açılacak.

-  Component'ler data tutanlar ve işlem yapanlar olarak ikiye ayrılacaklar. Data tutanlara data, mantık bulunduranlara da system denecektir.
-  System'lar iletişimleri sadece ortak data noktalarıyla yapacaklar. Birbirlerini aynı obje üzerinde bulunsalar dahi tanımayacaklar.
-  Update start gibi metotlar içerisinde kullanılan metotların adedine dikkat edilmeli. Muhtemelen orada kullanılan metot adedi o sınıfın sorumluluğuyla doğru orantılı.
-  Unity tarafından sağlanan componentlerle ilgili işlemler için ilgili component'ten türeyen system'lar oluşturulup yaratılan işlemlerin ilgili dataları dinlemesi sağlanabilir.
-  Hiç bir dış gameobje componentler tarafından bilinmemeli. Tüm işlemler yaratılan componentlerin dataları dinlemesiyle sağlanmalı. Örneğin bir objenin aktifliğini değiştirmek için o obje ilgili sınıfa aktarılmamalı, bunun yerine o obje üzerine aktifliğini set eden bir system yerleştirilip ilgili dataları dinlemesi sağlanmalı.
-  Hiç bir system public olan hiçbirşeye sahip olmamalı. Public yapma eğiliminde olduğumuz değişkenler çok yüksek ihtimalle ortak data noktalarında barınması gereken değişkenlerdir.
-  Bir system içerisinde bir şekilde başka bir system'ın sorumluluğuna ihtiyaç duyularsa yüksek ihtimalle soyutlama ihtiyacı vardır. Genel yapı tekrar gözden geçirilmelidir. Hiç bir şekilde o niteliğin olduğu componente bağlanılıp o method public yapılarak kullanılmamalıdır.
-  Sistemlerin datayı tutan sınıfları awake ya da start içerisinde bir değişkene aktarmaları gerekir. Kod içerisinde bir bağlantı yaratmak iyi değildir.
-  Bir entity üzerindeki birden fazla sistem başka bir entity'e ait bir datayı dinlemesi durumunda bu datayı dinleyen sistemlerin olduğu entity'nin data sınıfına diğer entity'nin o datasına göre güncellenecek bir data eklemek mantıklı olabilir. (?)
-  Bir sistem tanıması gereken prefabları inspector içerisinden kendine özel olarak alacaktır. Bu işlemin ortak data noktalarıyla bir alakası yoktur.
-  Her işlem sınıfı (system) monobehaviour olmalıdır.
-  System'ler içerisinde bir yerden fazla kullanılan matematiksel veya kıyaslama gibi işlemler static ve içsel durumu olmayan sınıflar içerisinde barındırılmalı ya da Monobehaviour olmayan sınıflarda geliştirilip gereken sınıfları conseptleriyle el yapımı bir ioc container ile aktarılmalıdırlar. İkincinin daha sağlıklı olduğunu düşünüyorum fakat overachitecture'a kaçma ihtimali var.
-  Oyunun genel akışıda daha küçük sistemlerin çalışması gereken zamanlara karar verme yöntemimiz olan bir datayı dinleme yoluyla sağlanmalı. GameFlow adında bir enum tipinde değişken yaratılıp bunun değişme zamanları ilgili bölgeler tarafından dinlenebilir.
-  Yukarıda belirtilenlerin getireceği önemli faydalardan biriside manager ihtiyacını ortadan kaldırmasıdır. Çünkü her işlem birimi çalışması gereken zamanı bir datayı takip ederek bulacaktır.
