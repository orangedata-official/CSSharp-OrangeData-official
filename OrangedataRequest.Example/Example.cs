using System;
using System.Threading.Tasks;
using OrangedataRequest;
using OrangedataRequest.DataService;
using OrangedataRequest.Models;
using OrangedataRequest.Enums;

namespace TestLauncher
{
    public class Example
    {
        static async Task Main(string[] args)
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
                    AgentType = AgentTypeEnum.PayingAgent,
                    CheckClose = new CheckClose
                    {
                        Payments = new[]
                        {
                            new Payment
                            {
                                Amount = 132.35m,
                                //Amount = 1.35m,
                                Type = PaymentTypeEnum.Cash
                            }
                        },
                        TaxationSystem = TaxationSystemEnum.Simplified
                    },
                    Positions = new []
                    {
                        new Position
                        {
                            Price = 123.45m,
                            Quantity = 1m,
                            Tax = VATRateEnum.NONE,
                            Text = "Булка",
                            PaymentMethodType = PaymentMethodTypeEnum.Full,
                            PaymentSubjectType = PaymentSubjectTypeEnum.Product
                        },
                        new Position
                        {
                            Price = 4.45m,
                            Quantity = 2m,
                            Tax = VATRateEnum.VAT110,
                            Text = "Спички",
                            PaymentMethodType = PaymentMethodTypeEnum.Full,
                            PaymentSubjectType = PaymentSubjectTypeEnum.Product
                        }
                    },
                    CustomerContact = "foo@example.com"
                }
            };

            var dummyCreateCorrectionCheckRequest = new ReqCreateCorrectionCheck
            {
                Id = "66549876216",
                INN = "5001104058",
                Content = new CorrectionContent
                {
                    Type = DocTypeEnum.In,
                    CashSum = 2000,
                    TaxationSystem = TaxationSystemEnum.Common,
                    Tax4Sum = 2000,
                    Description = "Тестовая коррекция",
                    CauseDocumentDate = DateTime.UtcNow.Date,
                    CauseDocumentNumber = "21"
                }
            };
            var res1 = await dummyOrangeRequest.CreateCheckAsync(dummyCreateCheckRequest);
            var res2 = await dummyOrangeRequest.GetCheckStateAsync("5001104058", "12345678990");
            var res3 = await dummyOrangeRequest.CreateCorrectionCheckAsync(dummyCreateCorrectionCheckRequest);
            var res4 = await dummyOrangeRequest.GetCorrectionCheckStateAsync("5001104058", "12345678990");
            Console.ReadKey();
        }
    }
}