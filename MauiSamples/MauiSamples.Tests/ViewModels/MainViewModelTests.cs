using FakeItEasy;
using MauiSamples.Navigation;
using MauiSamples.Services.Device;
using MauiSamples.ViewModels;

namespace MauiSamples.Tests.ViewModels;

[TestFixture]
public class MainViewModelTests
{
    [Test]
    public void SetHighBrightness_SetScreenBrightnessCalled()
    {
        //arrange
        var deviceServiceMock = A.Fake<IDeviceService>();
        var vm = new MainViewModel(deviceServiceMock, null);

        //act
        vm.SetHighBrightness();

        //assert
        A.CallTo(() => deviceServiceMock.SetScreenBrightness(A<float>._)).MustHaveHappenedOnceExactly();
    }

    [Test]
    public void SetLowBrightness_SetScreenBrightnessCalled()
    {
        //arrange
        var deviceServiceMock = A.Fake<IDeviceService>();
        var vm = new MainViewModel(deviceServiceMock, null);

        //act
        vm.SetLowBrightness();

        //assert
        A.CallTo(() => deviceServiceMock.SetScreenBrightness(A<float>._)).MustHaveHappenedOnceExactly();
    }

    [Test]
    public async Task GoToGraphicsPageAsync_NavigationServiceCalled()
    {
        //arrange
        var navigationServiceMock = A.Fake<INavigationService>();
        var vm = new MainViewModel(null, navigationServiceMock);

        //act
        await vm.GoToGraphicsPageAsync();

        //assert
        A.CallTo(() => navigationServiceMock.GoToAsync(A<ShellNavigationState>._)).MustHaveHappenedOnceExactly();
    }
}