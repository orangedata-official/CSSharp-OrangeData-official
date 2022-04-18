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
            var prKeyPath = "C:\\Development\\Aqsi\\OrangeData\\files\\files_for_test\\private_key_test.xml";
            var certPath = "C:\\Development\\Aqsi\\OrangeData\\files\\files_for_test\\client.pfx";
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
                    Positions = new[]
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
                Id = "66649876216",
                INN = "5001104058",
                Content = new CorrectionContent
                {
                    Type = DocTypeEnum.In,
                    CashSum = 2000,
                    TaxationSystem = TaxationSystemEnum.Common,
                    Tax4Sum = 2000,
                    CauseDocumentDate = DateTime.UtcNow.Date,
                    CauseDocumentNumber = "21"
                }
            };

            var dummyCreateCheckRequest12 = new ReqCreateCheck
            {
                Id = "12345678990",
                INN = "7725327863",
                Group = "Main_2",
                Key = "1234567",
                Content = new Content {
                    Type = DocTypeEnum.In,
                    Positions = new Position[] {

                    new Position{
                        Quantity = 1.000M,
                Price=123.45M,
                Tax= VATRateEnum.NONE,
                Text="Булка",
                PaymentMethodType = PaymentMethodTypeEnum.Full,
                PaymentSubjectType= PaymentSubjectTypeEnum.Product,
                AgentType= AgentTypeEnum.Other,
                AgentInfo=new AgentInfo {
                            PaymentTransferOperatorPhoneNumbers= new string[] {"+79200000001", "+74997870001"},
                  PaymentAgentOperation= "Какая-то операция 1",
                  PaymentAgentPhoneNumbers= new string[] { "+79200000003" },
                  PaymentOperatorPhoneNumbers= new string[] { "+79200000002", "+74997870002" },
                  PaymentOperatorName= "ООО \"Атлант\"",
                  PaymentOperatorAddress= "Воронеж, ул. Недогонная, д. 84",
                  PaymentOperatorINN= "7727257386"
                        },
                AdditionalAttribute= "Доп. атрибут и все тут",
                ManufacturerCountryCode= "643",
                CustomsDeclarationNumber= "АД 11/77 от 01.08.2018",
                Excise= (decimal)23.45,
                UnitTaxSum= (decimal)0.23,
                ItemCode= "010460406000600021N4N57RSCBUZTQ\u001d2403004002910161218\u001d1724010191ffd0\u001d92tIAF/YVoU4roQS3M/m4z78yFq0fc/WsSmLeX5QkF/YVWwy8IMYAeiQ91Xa2z/fFSJcOkb2N+uUUmfr4n0mOX0Q==",
                PlannedStatus= 2,
                FractionalQuantity= new System.Collections.Generic.Dictionary<string, ulong>{
                            { "numerator", 1},
                            { "denominator", 2}
                        },
                IndustryAttribute=new System.Collections.Generic.Dictionary<string, string> {
                            { "foivId", "012"},
                            { "causeDocumentDate", "12.08.2021"},
                            { "causeDocumentNumber", "666"},
                            { "value", "position industry"}
                        },
                Barcodes=new System.Collections.Generic.Dictionary<string, string> {
                            { "ean8", "46198532"},
                            { "ean13", "4006670128002"},
                            { "itf14", "14601234567890"},
                            { "gs1", "010460043993125621JgXJ5.T"},
                  { "mi", "RU-401301-AAA0277031"},
                  { "egais20", "NU5DBKYDOT17ID980726019"},
                  { "egais30", "13622200005881"},
                  { "f1", null},
                  { "f2", null},
                  { "f3", null},
                  { "f4", null},
                  { "f5", null},
                  { "f6", null}
                }
             },
          new Position{
                    Quantity= 2.000M,
            Price= 4.45M,
            Tax= VATRateEnum.VAT110,
            Text= "Спички",
            PaymentMethodType= PaymentMethodTypeEnum.Advance,
            PaymentSubjectType= PaymentSubjectTypeEnum.Other,
            SupplierINN= "9715225506",
            SupplierInfo= new SupplierInfo {
                        PhoneNumbers= new string[] { "+79266660011", "+79266660022" },
              Name= "ПАО \"Адамас\""
                    },
            QuantityMeasurementUnit= 10
                }
        },
                    CheckClose = new CheckClose {
                        Payments = new Payment[] {
                        new Payment{Type= PaymentTypeEnum.Cash,Amount= 123.45M},
                        new Payment{Type= PaymentTypeEnum.Emoney,Amount= 8.90000M}
                    },
                        TaxationSystem = TaxationSystemEnum.Simplified
                    },
                    CustomerContact = "foo@example.com",
                    AdditionalUserAttribute = new System.Collections.Generic.Dictionary<string, string> {
            { "name", "Любимая цитата"},
            { "value", "В здоровом теле здоровый дух, этот лозунг еще не потух!"}
        },
                    AutomatNumber = "123456789",
                    SettlementAddress = "г.Москва, Красная площадь, д.1",
                    SettlementPlace = "Палата №6",
                    AdditionalAttribute = "Доп атрибут чека",
                    Cashier = "Кассир",
                    SenderEmail = "ru@example.mail",
                    CustomerInfo = new System.Collections.Generic.Dictionary<string, string> {
            { "name", "Кузнецов Иван Петрович"},
            { "inn", "7725327863"},
            { "birthDate", "15.09.1988"},
            { "citizenship", "643"},
            { "identityDocumentCode", "01"},
            { "identityDocumentData", "multipassport"},
            { "address", "Басеенная 36"}
        },
                    OperationalAttribute = new OperationalAttribute {
                        Date = "2021-08-12T18:36:16",
                        Id = 0,
                        Value = "operational"
                    },
                    IndustryAttribute = new System.Collections.Generic.Dictionary<string, string> {
                    { "foivId", "010"},
                    { "causeDocumentDate", "11.08.2021"},
                    { "causeDocumentNumber", "999"},
                    { "value", "industry"}
                    },
        FfdVersion= 4
        },
        Meta= "some meta",
        CallbackUrl= "http://call.back/?doc=2",
        IgnoreItemCodeCheck= false
            };

            var dummyCreateCorrectionCheckRequest12 = new ReqCreateCorrectionCheck12
            {
                Id = "66649876217",
                INN = "7725327863",
                Group = "Main_2",
                Key = "1234567",
                Content = new CorrectionContent12
                {
                    FfdVersion = 4,
                    Type = DocTypeEnum.In,
                    Positions = new Position[] {
                        new Position{
                            Quantity = 1.000M,
                            Price=123.45M,
                            Tax= VATRateEnum.NONE,
                            Text="Булка",
                            PaymentMethodType = PaymentMethodTypeEnum.Full,
                            PaymentSubjectType= PaymentSubjectTypeEnum.Product,
                            AgentType= AgentTypeEnum.Other,
                            AgentInfo=new AgentInfo {
                                PaymentTransferOperatorPhoneNumbers= new string[] {"+79200000001", "+74997870001"},
                                  PaymentAgentOperation= "Какая-то операция 1",
                                  PaymentAgentPhoneNumbers= new string[] { "+79200000003" },
                                  PaymentOperatorPhoneNumbers= new string[] { "+79200000002", "+74997870002" },
                                  PaymentOperatorName= "ООО \"Атлант\"",
                                  PaymentOperatorAddress= "Воронеж, ул. Недогонная, д. 84",
                                  PaymentOperatorINN= "7727257386"
                            },
                            AdditionalAttribute= "Доп. атрибут и все тут",
                            ManufacturerCountryCode= "643",
                            CustomsDeclarationNumber= "АД 11/77 от 01.08.2018",
                            Excise= (decimal)23.45,
                            UnitTaxSum= (decimal)0.23,
                            ItemCode= "010460406000600021N4N57RSCBUZTQ\u001d2403004002910161218\u001d1724010191ffd0\u001d92tIAF/YVoU4roQS3M/m4z78yFq0fc/WsSmLeX5QkF/YVWwy8IMYAeiQ91Xa2z/fFSJcOkb2N+uUUmfr4n0mOX0Q==",
                            PlannedStatus= 2,
                            FractionalQuantity= new System.Collections.Generic.Dictionary<string, ulong>{
                                { "numerator", 1},
                                { "denominator", 2}
                            },
                            IndustryAttribute=new System.Collections.Generic.Dictionary<string, string> {
                                { "foivId", "012"},
                                { "causeDocumentDate", "12.08.2021"},
                                { "causeDocumentNumber", "666"},
                                { "value", "position industry"}
                            },
                            Barcodes=new System.Collections.Generic.Dictionary<string, string> {
                                { "ean8", "46198532"},
                                { "ean13", "4006670128002"},
                                { "itf14", "14601234567890"},
                                { "gs1", "010460043993125621JgXJ5.T"},
                                { "mi", "RU-401301-AAA0277031"},
                                { "egais20", "NU5DBKYDOT17ID980726019"},
                                { "egais30", "13622200005881"},
                            }
                        }
                    },
                    CheckClose = new CheckClose
                    {
                        Payments = new Payment[] {new Payment{Type= PaymentTypeEnum.Cash,Amount= 123.45M}},
                        TaxationSystem = TaxationSystemEnum.Simplified
                    },
                    CustomerContact = "foo@example.com",
                    CorrectionType = CorrectionTypeEnum.OnPrescription,
                    CauseDocumentDate = "2021-08-13T00:00:00",
                    CauseDocumentNumber = "42/666",
                    AdditionalUserAttribute = new System.Collections.Generic.Dictionary<string, string> {
                        { "name", "Любимая цитата"},
                        { "value", "В здоровом теле здоровый дух, этот лозунг еще не потух!"}
                    },
                    AutomatNumber = "123456789",
                    SettlementAddress = "г.Москва, Красная площадь, д.1",
                    SettlementPlace = "Палата №6",
                    AdditionalAttribute = "Доп атрибут чека",
                    Cashier = "Кассир",
                    SenderEmail = "ru@example.mail",
                    CustomerInfo = new System.Collections.Generic.Dictionary<string, string> {
                        { "name", "Кузнецов Иван Петрович"},
                        { "inn", "7725327863"},
                        { "birthDate", "15.09.1988"},
                        { "citizenship", "643"},
                        { "identityDocumentCode", "01"},
                        { "identityDocumentData", "multipassport"},
                        { "address", "Басеенная 36"}
                    },
                    OperationalAttribute = new OperationalAttribute
                    {
                        Date = "2021-08-12T18:36:16",
                        Id = 0,
                        Value = "operational"
                    },
                    IndustryAttribute = new System.Collections.Generic.Dictionary<string, string> {
                        { "foivId", "010"},
                        { "causeDocumentDate", "11.08.2021"},
                        { "causeDocumentNumber", "999"},
                        { "value", "industry"}
                    },
                }
            };
            var checkAccess = await dummyOrangeRequest.GetAccessStateAsync(new ReqAccessStatus { INN = "7725327863", Group = "Main_2", Key = "1234567" });
            var res1 = await dummyOrangeRequest.CreateCheckAsync(dummyCreateCheckRequest);
            var res2 = await dummyOrangeRequest.GetCheckStateAsync("5001104058", "12345678990");
            var res3 = await dummyOrangeRequest.CreateCorrectionCheckAsync(dummyCreateCorrectionCheckRequest);
            var res4 = await dummyOrangeRequest.GetCorrectionCheckStateAsync("5001104058", "12345678990");

            var res5 = await dummyOrangeRequest.CreateCheckAsync(dummyCreateCheckRequest12);
            var res6 = await dummyOrangeRequest.GetCheckStateAsync("7725327863", "12345678990");
            var res61 = await dummyOrangeRequest.GetKKTDevicesStateAsync("7725327863", "Main_2");
            var res7 = await dummyOrangeRequest.CreateCorrectionCheckAsync12(dummyCreateCorrectionCheckRequest12);
            var res8 = await dummyOrangeRequest.GetCorrectionCheckStateAsync12("7725327863", "66649876217");
            var res9 = await dummyOrangeRequest.CreateItemCodeCheckAsync12(new ReqItemCodeCheck {
                Id = "66649876218",
                INN = "7725327863",
                Group = "Main_2",
                Key = "1234567",
                Content = new ItemCodeContent {
                    PlannedStatus=1,
                    ItemCode = "00000046210654eK7fYtcAAModGVz"
                }
            });
            var res10 = await dummyOrangeRequest.GetItemCodeStateAsync("7725327863", "66649876218");
            Console.ReadKey();
        }
    }
}