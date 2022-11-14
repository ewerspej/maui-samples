using MauiSamples.Services.Device;
using MauiSamples.ViewModels;
using Moq;

namespace MauiSamples.Tests.ViewModels;

[TestFixture]
public class MainViewModelTests
{
    [Test]
    public void SetHighBrightness_SetScreenBrightnessCalled()
    {
        //arrange
        var deviceServiceMock = new Mock<IDeviceService>();
        var vm = new MainViewModel(deviceServiceMock.Object);

        //act
        vm.SetHighBrightness();

        //assert
        deviceServiceMock.Verify(service => service.SetScreenBrightness(It.IsAny<float>()), Times.Once);
    }

    [Test]
    public void SetLowBrightness_SetScreenBrightnessCalled()
    {
        //arrange
        var deviceServiceMock = new Mock<IDeviceService>();
        var vm = new MainViewModel(deviceServiceMock.Object);

        //act
        vm.SetLowBrightness();

        //assert
        deviceServiceMock.Verify(service => service.SetScreenBrightness(It.IsAny<float>()), Times.Once);
    }
}