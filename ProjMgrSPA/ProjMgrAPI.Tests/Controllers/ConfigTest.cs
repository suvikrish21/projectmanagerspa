using System;

using System.Web.Optimization;
using System.Web.Mvc;
using System.Web.Routing;
using NUnit.Framework;
using System.Web.Http;

namespace ProjMgrAPI.Tests.Controllers
{
    [TestFixture]
    public class ConfigTest
    {
        [TestCase]
        public void BundleConfigTest()
        {
            var bundles = new BundleCollection();
            BundleConfig.RegisterBundles(bundles);


            Assert.AreEqual(4, bundles.Count);
           
        }



        [TestCase]
        public void FilterConfigTest()
        {
            var filter = new GlobalFilterCollection();
            FilterConfig.RegisterGlobalFilters(filter);


            Assert.AreEqual(1, filter.Count);

        }



        [TestCase]
        public void RouteConfigTest()
        {
            var routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);


            Assert.AreEqual(2, routes.Count);

        }



        [TestCase]
        public void WebApiConfigTest()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);


            Assert.AreEqual(4, config.Formatters.Count);

        }
    }
}
