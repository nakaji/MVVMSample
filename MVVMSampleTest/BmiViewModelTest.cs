using System;
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

            Assert.That(viewModel.Bmi, Is.EqualTo(22.30));
        }
    }
}
