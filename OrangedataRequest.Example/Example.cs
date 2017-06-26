using OrangedataRequest.DataService;
using OrangedataRequest.Models;
using OrangedataRequest.Enums;
using System;
using OrangedataRequest;

namespace TestLauncher
{
    public class Example
    {
        static void Main(string[] args)
        {
            var prKeyPath = "F:\\tmp\\API\\private_key.xml";
            var certPath = "F:\\tmp\\API\\client.pfx";
            var certPass = "1234";

            var dummyOrangeRequest = new OrangeRequest(prKeyPath, certPath, certPass);

            var dummyCreateCheckRequest = new ReqCreateCheck
            {
                Id = "66549876216",
                INN = "5001104058",
                Content = new Content
                {
                    Type = DocTypeEnum.In,
                    CheckClose = new CheckClose
                    {
                        Payments = new Payment[]
                        {
                            new Payment
                            {
                                //Amount = 132.35m,
                                Amount = 1.35m,
                                Type = PaymentTypeEnum.Cash
                            }
                        },
                        TaxationSystem = TaxationSystemEnum.Simplified
                    },
                    Positions = new Position[]
                    {
                        new Position
                        {
                            Price = 123.45m,
                            Quantity = 1m,
                            Tax = VATRateEnum.NONE,
                            Text = "Булка"
                        },
                        new Position
                        {
                            Price = 4.45m,
                            Quantity = 2m,
                            Tax = VATRateEnum.VAT110,
                            Text = "Спички"
                        }
                    },
                    CustomerContact = "foo@example.com"
                }
            };
            var res1 = dummyOrangeRequest.CreateCheck(dummyCreateCheckRequest);
            var res2 = dummyOrangeRequest.GetCheckState("5001104058", "12345678990");
            Console.ReadKey();
        }
    }
}