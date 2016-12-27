using NUnit.Framework;


namespace ModhosterTests.Tests
{
    [TestFixture]
    class Tests
    {
            private Steps.Steps steps = new Steps.Steps();
            private const string EMAIL = "nickpowell22@outlook.com";
            private const string USERNAME = "nickpowell22";
            private const string PASSWORD = "Manutd2016";
            private const string NEW_PASSWORD = "12Man3456";
            private const string REPEATPASSWORD = "12Man3456";
            private const string CLAAS = "Lexion";

        [SetUp]
            public void Init()
            {
                steps.InitBrowser();
            }

            [TearDown]

            public void Cleanup()
            {
                steps.CloseBrowser();
        }

        //1



        [Test]
        public void LoginModhoster()
        {
            steps.LoginModhoster(USERNAME, PASSWORD);

        }

        //2

            [Test]
        public void LogOffModhoster()
        {
            steps.LoginModhoster(USERNAME, PASSWORD);
            steps.LogOffModhoster();

        }
        // 3
        [Test]
        public void Mod2017select()
        {
            steps.Mod2017Modhoster();

        }


        //4
        [Test]
        public void Eurotruckselect()
        {
            steps.ModEurotruckModhoster();

        }

        //5

        [Test]
        public void Categoryselect()
        {
            steps.CatgoryImplModhoster();

        }

        //6
        [Test]
        public void Deutchselect()
        {
            steps.DeutchModhoster();

        }


        //7

        [Test]
        public void EditPassword()
        {
            steps.editpassModhoster(USERNAME, PASSWORD, NEW_PASSWORD, REPEATPASSWORD);

        }

        //8
        [Test]
        public void download()
        {
            steps.downloadModhoster();

        }


        //9

        [Test]
        public void SelectRate()
        {
            steps.rateModhoster();

        }

        //10
        [Test]
        public void GridView()
        {
            steps.gridModhoster();

        }
        //11
        [Test]
        public void vipmodsModhoster()
        {
            steps.LoginModhoster(USERNAME, PASSWORD);
            steps.vipModhoster();

        }
        //12
        [Test]
        public void searchtext()
        {

            steps.searchModhoster(CLAAS);
        }

    }
}