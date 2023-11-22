using ah4cClientApp.Services;
using System.Runtime.CompilerServices;

namespace AuthTesters
{

    public class Tests
    {
        private AuthService service;


        [SetUp]
        public void Setup()
        {
            service = new AuthService();
        }

        [Test]
        public void TestNullNull()
        {
            var result = service.AuthCheck("", "");
            Assert.That(result, Is.EqualTo("CheckFault"), "��������� ��� ����!");
        }

        [Test]
        public void TestComplete()
        {
            var result = service.AuthCheck("���������16", "dsfk234ml;");
            Assert.That(result, Is.EqualTo("CheckComplete"), "�����");
        }

        [Test]
        public void TestLoginNull()
        {
            var result = service.AuthCheck("", "dsfk234ml;");
            Assert.That(result, Is.EqualTo("LoginCheckFault"), "����� �� ����� ���� ������");
        }

        [Test]
        public void TestPasswordNull()
        {
            var result = service.AuthCheck("���������16", "");
            Assert.That(result, Is.EqualTo("PasswordCheckFault"), "������ �� ����� ���� ������");
        }
    }
}