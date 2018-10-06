using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JSONToEntity
    {
        public class Info
        {
            public string name { get; set; }
            public string regNum { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
            public string sum { get; set; }
            public string currencySum { get; set; }
            public string currencyName { get; set; }
            public string currencyCode { get; set; }
            public string code { get; set; }
            public string numAgreem { get; set; }
            public string dateAgreem { get; set; }
            public string numberNpa { get; set; }
            public string dateReg { get; set; }
            public string nameNpa { get; set; }
            public string rate { get; set; }
            public string dateUpdate { get; set; }
            public string sumMba { get; set; }
            public string sumMbamo { get; set; }
            public string regnumRgz { get; set; }
            public string mfCode { get; set; }
            public string mfName { get; set; }
            public string npaKind { get; set; }
            public string sumSubFzFb { get; set; }
            public string outerSystem { get; set; }
            public string internaldocnum { get; set; }
            public string loaddate { get; set; }
        }

        public class Grbs
        {
            public string okopf { get; set; }
            public string fullName { get; set; }
            public string shortName { get; set; }
            public string inn { get; set; }
            public string kpp { get; set; }
            public string location { get; set; }
            public string dateAccount { get; set; }
            public string kbkInput { get; set; }
            public string grbsAccount { get; set; }
            public string codeReestr { get; set; }
            public string countryCode { get; set; }
            public string countryName { get; set; }
            public string regionCode { get; set; }
            public string regionName { get; set; }
            public string districtName { get; set; }
            public string settleName { get; set; }
            public string postIndex { get; set; }
            public string locationOktmo { get; set; }
            public string localCode { get; set; }
            public string localName { get; set; }
            public string structType { get; set; }
            public string streetType { get; set; }
            public string objectType { get; set; }
            public string buildingType { get; set; }
            public string roomType { get; set; }
            public string tofkcode { get; set; }
            public string tofkname { get; set; }
        }

        public class Plan
        {
            public string purpose { get; set; }
            public string kbk { get; set; }
            public int sumTotal { get; set; }
            public List<string> sumMonth { get; set; }
            public string code { get; set; }
            public string sumYear { get; set; }
            public string sumFtYear { get; set; }
            public string sumSkYear { get; set; }
            public string sumTrYear { get; set; }
            public string sumFrYear { get; set; }
            public string sumOtherYear { get; set; }
            public string date { get; set; }
            public string analyticalCode { get; set; }
            public string sumLastYrExec { get; set; }
            public string sumLastYrNexec { get; set; }
            public string note { get; set; }
        }

        public class Document
        {
            public string name { get; set; }
            public string date { get; set; }
            public string contentType { get; set; }
            public string id { get; set; }
        }

        public class Change
        {
            public string num { get; set; }
            public string text { get; set; }
            public string date { get; set; }
            public DateTime docdate { get; set; }
        }

        public class LocalAddress
        {
            public string regionCode { get; set; }
            public string regionName { get; set; }
            public string postIndex { get; set; }
            public string localCode { get; set; }
            public string localName { get; set; }
            public string oktmo { get; set; }
            public string @struct { get; set; }
            public string street { get; set; }
            public string @object { get; set; }
            public string countryCode { get; set; }
            public string countryName { get; set; }
            public string districtName { get; set; }
            public string settleName { get; set; }
            public string buildingType { get; set; }
            public string roomType { get; set; }
            public string streetType { get; set; }
        }

        public class ForeignAddress
        {
            public string regionCode { get; set; }
            public string regionName { get; set; }
            public string postIndex { get; set; }
            public string localCode { get; set; }
            public string localName { get; set; }
            public string oktmo { get; set; }
            public string @struct { get; set; }
            public string street { get; set; }
            public string @object { get; set; }
            public string countryCode { get; set; }
            public string countryName { get; set; }
            public string districtName { get; set; }
            public string settleName { get; set; }
            public string buildingType { get; set; }
            public string roomType { get; set; }
            public string streetType { get; set; }
        }

        public class Receiver
        {
            public string budgetName { get; set; }
            public string fullName { get; set; }
            public string shortName { get; set; }
            public string okopf { get; set; }
            public string inn { get; set; }
            public string kpp { get; set; }
            public string oktmo { get; set; }
            public string fullNameLat { get; set; }
            public string dateAccount { get; set; }
            public string codeRecipient { get; set; }
            public LocalAddress localAddress { get; set; }
            public ForeignAddress foreignAddress { get; set; }
            public string shortNameLat { get; set; }
            public string codeReestr { get; set; }
            public string accountNum { get; set; }
            public string accountOrgCode { get; set; }
            public string regCountryCode { get; set; }
            public string regCountryName { get; set; }
            public string admelement { get; set; }
            public string phoneNumber { get; set; }
            public string email { get; set; }
            public string codeReestrGrbs { get; set; }
            public string grbsFullName { get; set; }
            public string detached { get; set; }
            public string institutetype { get; set; }
            public string institutetypename { get; set; }
        }

        public class Datum
        {
            public Info info { get; set; }
            public Grbs grbs { get; set; }
            public List<Plan> plans { get; set; }
            public List<object> payments { get; set; }
            public List<Document> documents { get; set; }
            public List<Change> changes { get; set; }
            public List<Receiver> receiver { get; set; }
            public List<object> faip { get; set; }
            public List<object> marks { get; set; }
            public List<object> npa { get; set; }
            public List<object> bo { get; set; }
            public List<object> construct { get; set; }
            public List<object> subjectNpa { get; set; }
            public List<object> plansSubject { get; set; }
            public List<object> faipSubject { get; set; }
            public List<object> infosub { get; set; }
            public List<object> infocost { get; set; }
            public List<object> indicatorvalue { get; set; }
            public List<object> infoind { get; set; }
            public List<object> addagreement { get; set; }
            public string id { get; set; }
        }

        public class Limits
        {
        }

        public class RootObject
        {
            public int pageCount { get; set; }
            public int pageNum { get; set; }
            public int pageSize { get; set; }
            public int recordCount { get; set; }
            public List<Datum> data { get; set; }
            public string order { get; set; }
            public string orderDirection { get; set; }
            public int offset { get; set; }
            public Limits limits { get; set; }
            public string version { get; set; }
        }
    }
}
