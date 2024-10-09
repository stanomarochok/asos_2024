﻿using DesignPatternsDemo.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemoTests.PatternsTests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void Builder_Demo()
        {
            var productBuilder = new ProductBuilder();

            var product = productBuilder.Build();

            Assert.That(product, Is.Not.Null);
            Assert.That(product.Name, Is.Null);
            Assert.That(product.Description, Is.Null);
            Assert.That(product.Category, Is.Null);

            product = productBuilder
                .SetName("name")
                .SetDescription("description")
                .SetCategory("category")
                .Build();

            Assert.That(product, Is.Not.Null);
            Assert.That(product.Name, Is.EqualTo("name"));
            Assert.That(product.Description, Is.EqualTo("description"));
            Assert.That(product.Category, Is.EqualTo("category"));
        }
    }
}
