// <image url="C:\Users\Eduardo\Pictures\mediator.png" scale="0.6" />

ConcreteMediator m = new ConcreteMediator();

ConcreteColleague1 c1 = new ConcreteColleague1(m);
ConcreteColleague2 c2 = new ConcreteColleague2(m);

m.Colleague1 = c1;
m.Colleague2 = c2;

// Sending a message from colleague 1 to 2
c1.Send("How are you?");
// Sending a message from colleague 2 to 1
c2.Send("Fine, thanks");