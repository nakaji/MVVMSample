using System;
using System.ComponentModel;
using MVVMSample;
using NUnit.Framework;

namespace MVVMSampleTest
{
    [TestFixture]
    public class BmiViewModelTest
    {
        [Test]
        public void 正常()
        {
            var viewModel = new BmiViewModel();

            viewModel.Height = 172;
            viewModel.Weight = 66;

            viewModel.Calc();

            Assert.That(viewModel.Bmi, Is.EqualTo(22.30));
        }

        [Test]
        public void プロパティの変更通知確認()
        {
            var viewModel = new BmiViewModel();
            String propertyName = "";

            viewModel.PropertyChanged += new PropertyChangedEventHandler((s, e) => { propertyName = e.PropertyName; });
            viewModel.Height = 172;
            viewModel.Weight = 66;

            Assert.That(propertyName, Is.EqualTo(""));

            viewModel.Calc();

            Assert.That(propertyName, Is.EqualTo("Bmi"));
        }
    }
}
