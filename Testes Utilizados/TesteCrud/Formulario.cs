using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteCrud
{
    public class Formulario : Begin
    {
        string numero = "(79) 99882-4259";
        string cpf = "123.456.789-99";

        [Test]
        public void TestCadastroValido()
        {

            driver.FindElement(By.Id("nomeCompletoUsuario")).SendKeys("Maria Eduarda");
            driver.FindElement(By.Id("nascimentoUsuario")).SendKeys("20122008");
            driver.FindElement(By.Id("cpf")).SendKeys(cpf);
            driver.FindElement(By.Id("usuarioUsuario")).SendKeys("Duda");
            driver.FindElement(By.Id("emailUsuario")).SendKeys("eduarda@gmail.com");
            driver.FindElement(By.Id("telefone")).SendKeys(numero);
            driver.FindElement(By.Id("senha")).SendKeys("duda1234");
            driver.FindElement(By.Id("confirmarSenha")).SendKeys("duda1234");
            driver.FindElement(By.Id("cadastrar")).Click();
        }

        [Test]
        public void TestCamposVazios()
        {
            driver.FindElement(By.Id("cadastrar")).Click();

            Assert.That(driver.FindElement(By.Id("nomeCompletoUsuario-error")).Text.Contains("required"), Is.True);
            Assert.That(driver.FindElement(By.Id("nascimentoUsuario-error")).Text.Contains("required"), Is.True);
            Assert.That(driver.FindElement(By.Id("cpf-error")).Text.Contains("required."), Is.True);
            Assert.That(driver.FindElement(By.Id("usuarioUsuario-error")).Text.Contains("required"), Is.True);
            Assert.That(driver.FindElement(By.Id("emailUsuario-error")).Text.Contains("required"), Is.True);
            Assert.That(driver.FindElement(By.Id("telefone-error")).Text.Contains("required"), Is.True);
            Assert.That(driver.FindElement(By.Id("senha-error")).Text.Contains("required"), Is.True);
        }

        [Test]
        public void TestCamposIncorretos()
        {
            driver.FindElement(By.Id("nomeCompletoUsuario")).SendKeys("Maria Eduarda");
            driver.FindElement(By.Id("nascimentoUsuario")).SendKeys("20122008");
            driver.FindElement(By.Id("cpf")).SendKeys(cpf);
            driver.FindElement(By.Id("usuarioUsuario")).SendKeys("Duda");
            driver.FindElement(By.Id("emailUsuario")).SendKeys("eduarda");
            driver.FindElement(By.Id("telefone")).SendKeys(numero);
            driver.FindElement(By.Id("senha")).SendKeys("duda1234");
            driver.FindElement(By.Id("confirmarSenha")).SendKeys("duda123");
            driver.FindElement(By.Id("cadastrar")).Click();

            Assert.That(driver.FindElement(By.Id("emailUsuario-error")).Text.Contains("O email inserido não é válido"), Is.True);
            Assert.That(driver.FindElement(By.Id("erroSenha")).Text.Contains("As senhas não coincidem."), Is.True);
        }

        [Test]
        public void TestValidarMask()
        {
            driver.FindElement(By.Id("nascimentoUsuario")).SendKeys("20122008");
            driver.FindElement(By.Id("cpf")).SendKeys(cpf);
            driver.FindElement(By.Id("telefone")).SendKeys(numero);

            Assert.That(driver.FindElement(By.Id("nascimentoUsuario")).Text.Contains("20/12/2008"), Is.True);
            Assert.That(driver.FindElement(By.Id("cpf")).Text.Contains(cpf), Is.True);
            Assert.That(driver.FindElement(By.Id("telefone")).Text.Contains(numero), Is.True);
        }
    }
}
