<p align="center">
  <img src="https://github.com/serifaydin/RabbitMQ/blob/master/1.PNG">
</p>
---------
<p align="center">
  <img src="https://github.com/serifaydin/RabbitMQ/blob/master/2.PNG">
</p>
---------
<p align="center">
  <img src="https://github.com/serifaydin/RabbitMQ/blob/master/3.PNG">
</p>


AMQP (Advanced Message Queuing Protocol)
•	Geliþmiþ bir mesajlaþma protokolüdür. 
•	Platform baðýmsýz beberleþme imkaný sunuyor. AMQP destekli bir sunucu var ise, sunucu ile hemen hemen her dil ile Client Baðlantýsý yazýlabilir.
•	AMQP paketlerinde, header, properties ve message alanlarý bulunur.
AMQP protokolünde toplam 4 adet exchange tipi var. Direct, Fanout, Topic ve Header. Direct 
AMQP Mesajlaþma Mimarileri
?	Direct Exchange (Point-to-point)
 
?	Bir mesaj üreticisi tarafýndan (Producer, Publisher) üretilen mesajýn sadece bir Tüketiciye (Consumer) iletildiði yapýdýr. Birden fazla ayný iþi yapan tüketici (Consumer) yazýlmasýna raðmen, mesaj yalnýzca bir tüketici (Consumer) tarafýndan iþlenir. 
?	Mesajlar, mesajýn “binding key” deðeri ile sýranýn “routing key” deðerleri arasýnda bir birleþme vardýr. Elimizde hangi mesajýn hangi sýraya gideceðini belirleme seçeneði vardýr.
?	Eðer Direct Exchange kullanýrken binding_key ve routing_key belirlenmemiþ ise, Direct Exchange Fanout Exchange gibi hareket edip, mesajlarý iliþkide olduðu tüm sýralara gönderecktir.
?	Direct Exchange kullanýrken, Queue oluþturduðumuzda ki Route Key’i Producer belirtmez ise sistemdeki tüm Direct Exchange Queue lere mesaj eklenecektir.
?	Bir Queue’ ye birden fazla Route Key verilir. Publish edilen Route Key’ e göre Queue’ ye mesaj gönderilir.


?	Fanout Exchange (Publish-subscribe)
 
?	Producer’ ler tarafýndan üretilen mesajlarýn, Tüm Consumer’ lara gönderildiði Exchange Type’ dýr.
?	Fanout Exchange’ e baðlý tüm Queue lere Producer’ den gelen mesaj iletilir. 
?	Fanout Exchange’ de Route Key in bir önemi yoktur.
?	Fanout Exchange’ de Producer tarafýndan bir Queue belirtilmelidir. Yoksa sistem kendisi bir Queue oluþturacaktýr.

?	Topic Exchange
 
Topic Exchange Type; Producer tarafýndan gönderilen bir mesajýn, kurallar göz önünde bulundurularak farklý Queue lara gönderilmesi iþleminde kullanýlýr. Kural larý *. Þeklinde belirtebiliyoruz.
Aþaðýdaki örnek Topik Exchange Route Key kurallarý ile kullanýmlarý belirtilmiþtir.
Kural	Kullanýmý
*.serif	2 kelimeden oluþan 2. Kelimesi serif olan
serif.*	2 kelimeden oluþan 1. Kelimesi serif olan
*.serif.*	3 kelimeden oluþan Ortadaki kelimesi serif olan
serif	Sadece serif olucak

?	Header Exchange
 
RabbitMQ ile Queue oluþturuken, Queue larýn Header larýna key-value þeklinde parametreler yazabiliriz. Producer bir Mesaj gönderdiðinde mesajýn Properties’ inde bulunan header bilgisine göre, gerekli Queue kuyruðuna mesaj eklenecektir.


RabbitMQ
RabbitMQ, bir mesaj kuyruðu sistemidir. Publish ve Subscribe mantýðý ile çalýþýr. RabbitMQ Erlang iþletim sistemi ile yazýlmýþtýr.
•	RabbitMQ bir çok yazýlým diline destek vermektedir.
•	RabbitMQ bir çok iþletim sistemi ile çalýþýr.
•	RabbitMQ Open Source dur.
•	RabbitMQ’ yu iþletim sistemine kurmadan önce Erlang dilinin o iþletim sistemine kurulmasý gerekmektedir.
•	RabbitMQ içerisinde bulundurduðu Publish, Subscribe ve Routing mekanizmasý ile Geliþmiþ Mesaj Kuyruðu Protokolü (AMQP) standardýna uygun olarak çalýþmaktadýr
•	RabbitMQ Queue’ si FIFO (First in First out) ilk giren ilk çýkar, mantýðýnda çalýþmaktadýr.
RabbitMQ ile ölçeklenebilir (scakability) bir ortam oluþturabiliriz. Anlýk yapýlmayacak iþlemleri asenkron þekilde gerçekleþtirerek;
•	Uygulamalarýmýzý kullanan kiþileri gereksiz bir response time maliyetinden arýndýrmýþ oluruz.
•	Server üzerindeki concurrent process maliyetini bir nebze ölçeklenebilir bir hale getirmiþ oluruz.
RabbitMQ installer site : http://www.rabbitmq.com/install-windows.html
Erlang installer site : http://www.erlang.org/downloads 
RabbitMQ kullanmak için bazý özel tanýmlarý bilmemiz gerekmektedir.
•	Producer (Publisher) : Kuyruða mesaj gönderen uygulamadýr. Mesajý Exchange’ e gönderir.
•	Consumer : Kuyruktaki mesajý dinleyecek olan uygulamadýr.
•	Queue : Mesajlarýn RabbitMQ tarafýnda eklendiði kuyruktur. Exchange’ den gelen mesajý tutar.
•	Exchange : Mesajý Preducer’ den alýr ve Queue’ ye gönderir. Exchange mecburi deðildir. Bir kaç Exchange tipi bulunmaktadýr. Yaptýðý iþlem ise ilgili Routing Key’ e göre mesajý ilgili Queue’ ye yönlendirmektir.
o	Binding – Exchange içinde tanýmlanan kurallardýr ve hangi mesajýn hangi Queue’ ye iletileceðini belirler.
•	Exchange Type : Ýlgili mesaj’ ýn Routing Key’ e göre hangi Queue’ ye nasýl yönlendireceðini belirlemektir. 4 adettir. Direct, Fanout, Headers, Topic Exchange
 
•	Producer: Queue’ya mesaj gönderen uygulamadýr. Yani Publisher’ýmýz.
•	Consumer: Queue’daki mesajlarý dinleyecek olan uygulamamýzdýr.
Erlang’ i kurduktan sonra, RabbitMQ yu bilgisayarýmýza indirelim ve kuralým. Ardýndan RabbitMQ Command Prompt’ u Administrator Yönetici olarak çalýþtýralým.
Komut Satýrý : rabbitmq-plugins enable rabbitmq_management
 
Yukarýdaki komut satýrýný RabbitMQ Command Prompt’ da çalýþtýrdýðýmýzda, yukarýdaki resimde de görüldüðü üzere Bilgisayar da kurulu olan RabbitMQ servislerini çalýþtýrýr.
Erlang ve RabbitMQ kurulumunu gerçekleþtirdik den sonra. Default olarak http://localhost:15672 adresinden RabbitMW yönetim ekranýný açabiliriz.
 
Servis olarak hizmetlerde çalýþmaktadýr, buradan durdurup veya restart edebiliriz.
 
Windows baþlat menüsüne yukarýdaki RabbitMQ özel komutlarý gelecektir.
http://localhost:15672 ile RabbitMQ Dashboard’ý ýný açabiliriz. Fakat girdiðimizde bizi bir Login ekraný karþýlayacak default olarak aþaðýdaki kullanýcý adý ve þifre girilmelidir.
•	Kullanýcý Adý : guest
•	Þifre : guest

RabbitMQ Menüleri ve Ýþlemleri
 

1.	Overview Menüsü
RabbitMQ server üzerinde ki tüm analiz ve raporlarý buradan canlý olarak takip edebilir gerekirse müdahale edebiliriz.

2.	Connection Menüsü   
RabbitMQ Server’ a baðlý olan Consumer bilgisini canlý olarak buradan tüm detaylý analiz bilgileri ile ulaþabiliriz. 




3.	Channels Menüsü
 
RabbitMQ Server’ a baðlý olan Consumer bilgisini canlý olarak buradan tüm detaylý analiz bilgileri ile ulaþabiliriz. Consumer’ ýn 
•	Virtual host bilgisine ulaþýlabilir. Virtual host
•	Kaç adet mesajý okuduðu bilgisi burada mevcut. Unacked

4.	Exchanges Menüsü
 
•	RabbitMQ’ da 4 adet Exchange tipi vardýr.
•	Bizim de oluþturduðumuz Exchange Tipleri burada listelenir.
5.	Queues Menüsü
 
RabbitMQ server’ da Oluþturulan tüm QUEUE listesine buradan ulaþýyoruz. Buradan Queue ne durumda kaç adet var kýçý iþlendi gibi bir çok Queue özelindeki bilgiye rahatlýkla eriþip yönetebiliyoruz.
•	Ready : Ýletilecek olan mesaj sayýsý
•	Unacked : Consumer lar tafýndan iþlenen mesaj sayýsý
•	Total : Queue içerisindeki mesaj sayýsý.
•	Queue ile ilgili tüm detay bilgilere buradan ulaþabiliriz.

6.	RabbitMQ Admin Ýþlemleri
 
http://localhost:15672/ adýndan default oluþan bir host ile RabbitMQ nun tüm süreçlerini kontrol edebiliyoruz. Þu anda kullanýcý iþlemlerini inceleyeceðiz.
NOT : RabbitMQ’ yu bir server da çalýþtýrdýðýmýzda, farklý bir lokasyondan veya bilgisayardan guest acount’u ile giriþ yapamayýz. Yeni bir Acount oluþturmamýz gerekmektedir.
RabbitMQ’ yu farklý serverlara kurup yönetmek isteyebiliriz. Bunun için yapmamýz gereken bir kaç adým var.
1.	Add a user sekmesine týklayalým ve bir kullanýcý açalým.
 



2.	Yukarýdaki iþlemin ardýndan Add user diyelim ve All users sekmesine dönelim.
 
3.	Açýlan kullanýcýya Virtual Host eklemek için, Admin menüsündeyken Virtual hosts sekmesine týklayalým. 
a.	Default olarak oluþturulan “/” host un içerisine kullanýcýyý ekleyebiliriz
b.	Add virtual host ile yeni Virtual Host oluþturup kullanýcýyý bu host’ a set edebiliriz.
 
4.	Yukarýdaki iþlemleri bitirdikten sonra, artýk farklý lokasyonlardan ve bilgisayardan Server da bulunan RabbitMQ management uygulamasýna eriþebiliriz. Ayný zamanda kodlama yapmak için bir Connection oluþturmuþ olduk.
 
5.	Policies, Limits, Cluster vb. gibi ayarlamalarýda yine Admin penceresi altýndan yapabiliriz.
6.	Default olarak gelen “/” Virtual host yerine kendimizde istersek bir Virtusl host oluþturabiliriz.
 
Artýk istediðimiz takdirde Admin kullanýcýsý arvato Virtusl host’ u ile sisteme baðlanabilir, ve kodlama yapabilir.

RabbitMQ Örnek Kodlar.
Direct Exchange
?	Producer
var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Direct, true, false, null);

                    //QUEUE CREATED
                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue2Name, true, false, false, null);
                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, CL_ConstModel.queue1RouteKey);
                    channel.QueueBind(CL_ConstModel.queue2Name, CL_ConstModel.ExchangeName, CL_ConstModel.queue2RouteKey);

                    //QUEUE MESSAGE SEND
                    var publicationAddress = new PublicationAddress(ExchangeType.Direct, CL_ConstModel.ExchangeName, CL_ConstModel.queue1RouteKey);

                    string message = JsonConvert.SerializeObject(UserService.Load());

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            Console.WriteLine("Mesaj publish edildi, Direct Exchange' e baðlý Route Key' e göre mesaj iletildi 2999.");
            Console.ReadLine();
?	Consumer
Console.WriteLine("Direct Consumer 1");

            var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) =>
                    {
                        index++;
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);

                        User user = new User();

                        user = JsonConvert.DeserializeObject<User>(message);

                        Console.WriteLine(index + " Queue1 üzerinden mesaj alýndý: {0} , {1} , {2}", user.Id, user.Name, user.Surname);
                    };

                    channel.BasicConsume(CL_ConstModel.queue1Name, false, consumer);
                    Console.ReadLine();
                }
            }

Fanout Exchange
?	Producer
var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Fanout, true, false, null);

                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue2Name, true, false, false, null);

                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "");
                    channel.QueueBind(CL_ConstModel.queue2Name, CL_ConstModel.ExchangeName, "");

                    var publicationAddress = new PublicationAddress(ExchangeType.Fanout, CL_ConstModel.ExchangeName, "");

                    string message = JsonConvert.SerializeObject(UserService.Load());

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            Console.WriteLine("Mesaj publish edildi, Fanout Exchange' e baðlý tüm Queue lere mesaj iletildi.");
            Console.ReadLine();

?	Consumer
Console.WriteLine("Fanout Consumer 1");
            var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) =>
                    {
                        index++;
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        User user = JsonConvert.DeserializeObject<User>(message);

                        Console.WriteLine(index + " Queue1 üzerinden mesaj alýndý: {0} , {1} , {2}", user.Id, user.Name, user.Surname);
                    };

                    channel.BasicConsume(CL_ConstModel.queue1Name, false, consumer);
                    Console.ReadLine();
                }
            }

Header Exchange
?	Producer
var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Headers, true, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);

                    Dictionary<string, object> headerOptionsWithAll = new Dictionary<string, object>();
                    headerOptionsWithAll.Add("x-match", "all");
                    headerOptionsWithAll.Add("category", "animal");
                    headerOptionsWithAll.Add("type", "mammal");
                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "", headerOptionsWithAll);

                    //Dictionary<string, object> headerOptionsWithAny = new Dictionary<string, object>();
                    //headerOptionsWithAny.Add("x-match", "any");
                    //headerOptionsWithAny.Add("category", "plant");
                    //headerOptionsWithAny.Add("type", "tree");
                    //channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "", headerOptionsWithAny);

                    Dictionary<string, object> messageHeaders = new Dictionary<string, object>();

                    IBasicProperties properties = channel.CreateBasicProperties();
                    messageHeaders = new Dictionary<string, object>();
                    messageHeaders.Add("category", "animal");
                    messageHeaders.Add("type", "mammal");
                    messageHeaders.Add("x-match", "all");
                    properties.Headers = messageHeaders;

                    var publicationAddress = new PublicationAddress(ExchangeType.Headers, CL_ConstModel.ExchangeName, "");
                    string message = JsonConvert.SerializeObject(UserService.Load());
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(publicationAddress, properties, body);
                }
            }
?	Consumer
Console.WriteLine("Header Consumer 2");

            var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        User user = JsonConvert.DeserializeObject<User>(message);

                        Console.WriteLine("Queue1 üzerinden mesaj alýndý: {0} , {1} , {2}", user.Id, user.Name, user.Surname);
                    };

                    channel.BasicConsume(CL_ConstModel.queue2Name, false, consumer);
                    Console.ReadLine();
                }
            }




Topix Exchange
?	Producer
var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Topic, true, false, null);

                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue2Name, true, false, false, null);

                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "*.bmw");
                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "serif.*");

                    channel.QueueBind(CL_ConstModel.queue2Name, CL_ConstModel.ExchangeName, "merc.*");

                    var publicationAddress = new PublicationAddress(ExchangeType.Headers, CL_ConstModel.ExchangeName, "merc");

                    string message = JsonConvert.SerializeObject(UserService.Load());

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

?	Consumer
Console.WriteLine("Topic Consumer 1");

            var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) =>
                    {
                        index++;

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        User user = JsonConvert.DeserializeObject<User>(message);

                        Console.WriteLine(index + " Queue1 üzerinden mesaj alýndý: {0} , {1} , {2}", user.Id, user.Name, user.Surname);
                    };

                    channel.BasicConsume(CL_ConstModel.queue1Name, false, consumer);
                    Console.ReadLine();
                }
            }



