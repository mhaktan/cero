using System;
using Xunit;
using FluentAssertions;
using cero.Entities;

namespace cero.Tests.PurchaseRequests
{
    public class PurchaseRequestEntityTests
    {
        [Fact]
        public void PurchaseRequest_ShouldBeCreatable()
        {
            // Act
            var entity = new PurchaseRequest();

            // Assert
            entity.Should().NotBeNull();
        }

        [Fact]
        public void PurchaseRequest_ShouldHaveDefaultValues()
        {
            // Act
            var entity = new PurchaseRequest();

            // Assert
            entity.Id.Should().Be(default(long));

        }

        [Fact]
        public void PurchaseRequest_RequestNo_ShouldAcceptValue()
        {
            var entity = new PurchaseRequest { RequestNo = "Test Value" };
            entity.RequestNo.Should().Be("Test Value");
        }

        [Fact]
        public void PurchaseRequest_Justification_ShouldAcceptValue()
        {
            var entity = new PurchaseRequest { Justification = "Test Value" };
            entity.Justification.Should().Be("Test Value");
        }

    }
}
