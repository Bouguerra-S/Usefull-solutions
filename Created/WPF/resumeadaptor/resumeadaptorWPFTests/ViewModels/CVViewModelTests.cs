using Microsoft.VisualStudio.TestTools.UnitTesting;
using resumeadaptorWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.ViewModels.Tests
{
    [TestClass()]
    public class CVViewModelTests
    {
        [TestMethod()]
        public void CVViewModelTest()
        {
            CVViewModel testcvvm = new CVViewModel();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AddSectionTest()
        {
            CVViewModel testcvvm = new CVViewModel();
            testcvvm.AddSection();
            Assert.IsTrue(true);
        }
    }
}