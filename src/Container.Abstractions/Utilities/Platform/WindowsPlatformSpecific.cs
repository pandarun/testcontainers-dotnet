namespace TestContainers.Container.Abstractions.Utilities.Platform
{
    /// <inheritdoc />
    public class WindowsPlatformSpecific : IPlatformSpecific
    {
        /// <summary>
        /// 
        /// </summary>
        public static IPlatformSpecific Instance { get; } = new WindowsPlatformSpecific();

        /*
         * AppVeyor still uses a sac 2016 image and running any higher version docker
         * image will result in error
         * https://github.com/appveyor/ci/issues/1885
         * https://github.com/appveyor/ci/issues/1885
         *
         * https://github.com/isen-ng/testcontainers-dotnet/issues/14
         * Todo: Upgrade image to "mcr.microsoft.com/windows/nanoserver:1809"
         */
        /// <inheritdoc />
        public string TinyDockerImage { get; } = "mcr.microsoft.com/windows/nanoserver:sac2016";

        /// <inheritdoc />
        public string RyukImage { get; } = "ryuk:0.2.3-nanoserver-sac2016";

        private WindowsPlatformSpecific()
        {
        }
    }
}