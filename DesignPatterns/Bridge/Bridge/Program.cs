using Bridge.ConcreteImplementor;
using Bridge.Implementor;
using Bridge.RefinedAbstraction;

// Make instances of the refined abstractions
CardPayment cardPayment = new CardPayment();
InternetPayment internetPayment = new InternetPayment();

// Make an instance of the Implementor interface and assign it a concrete implementor (in this case HSBC)
IPaymentSystem ps = new HSBCPaymentSystem();

cardPayment._paymentSystem = ps;
internetPayment._paymentSystem = ps;

// Make payments
cardPayment.MakePayment();
internetPayment.MakePayment();

// Change payment system implementor to Santander
ps = new SantanderPaymentSystem();

cardPayment._paymentSystem = ps;
internetPayment._paymentSystem = ps;

// Make payments
cardPayment.MakePayment();
internetPayment.MakePayment();

