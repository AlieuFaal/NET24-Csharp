Publisher publisher = new Publisher();

Subscriber subscriber1 = new Subscriber("Kalle");
Subscriber subscriber2 = new Subscriber("Pelle");
Subscriber subscriber3 = new Subscriber("Eva");

publisher.Message += subscriber1.OnMessageReceived;
publisher.Message += subscriber2.OnMessageReceived;
publisher.Message += subscriber3.OnMessageReceived;


publisher.SendMessage();

System.Console.WriteLine();
publisher.Message -= subscriber2.OnMessageReceived;

publisher.SendMessage();

Console.ReadKey();
