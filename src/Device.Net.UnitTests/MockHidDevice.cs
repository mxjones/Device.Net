﻿namespace Device.Net.UnitTests
{
    public class MockHidDevice : MockDeviceBase, IDevice
    {
        public const uint ProductId = 1;
        public const uint VendorId = 1;
        public const string MockedDeviceId = "123";

        public MockHidDevice()
        {
            DeviceId = MockedDeviceId;
            ConnectedDeviceDefinition = new ConnectedDeviceDefinition(DeviceId) { ProductId = ProductId, VendorId = VendorId };
            Logger = new DebugLogger { LogToConsole = true };
        }
    }
}
