using System;
using Xunit;
using FluentAssertions;
using cero.Entities;

namespace cero.Tests.PurchaseOrders
{
    public class PurchaseOrderEntityTests
    {
        [Fact]
        public void PurchaseOrder_ShouldBeCreatable()
        {
            // Act
            var entity = new PurchaseOrder();

            // Assert
            entity.Should().NotBeNull();
        }

        [Fact]
        public void PurchaseOrder_ShouldHaveDefaultValues()
        {
            // Act
            var entity = new PurchaseOrder();

            // Assert
            entity.Id.Should().Be(default(long));

        }

        [Fact]
        public void PurchaseOrder_OrderNo_ShouldAcceptValue()
        {
            var entity = new PurchaseOrder { OrderNo = "Test Value" };
            entity.OrderNo.Should().Be("Test Value");
        }

    }
}
