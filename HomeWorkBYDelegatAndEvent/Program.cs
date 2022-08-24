using HomeWorkBYDelegatAndEvent;

CreditCard card = new (2000);
Client client = new ();

card.RegisterHandler(client.Method); // Использование метода регистрации
card.Put(200);
card.Get(300);
card.Put(400);
card.Get(2400);


Console.WriteLine(new String('-',30));

CreaditCard2 card2 = new (2000);
Client client2 = new ();
card2.Event += client.Method; // Использование собития 
card2.Put(200);
card2.Get(300);
card2.Put(400);
card2.Get(2400);

Console.WriteLine(new String('-', 30));

card2.Event -= client.Method;
card2.Event += delegate (string massage) { Console.WriteLine(massage); };
card2.Put(200);
card2.Get(300);
card2.Put(400);
card2.Get(2400);
card2.Event +=  massage =>  Console.WriteLine(massage);
card2.Put(200);
card2.Get(300);
card2.Put(400);
card2.Get(2400);
// Лямбда выроженияи,аннонимные методы не возможно отписать из события поэтому в консоли выводиться два раза!!!