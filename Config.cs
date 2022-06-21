namespace OptoCloud.DotNetBug
{
    public struct Config
    {
        static Config? s_config;
        public static Config GetConfig()
        {
            if (!s_config.HasValue)
            {
                s_config = new Config
                {
                    Username = "test"
                };
            }

            return s_config.Value;
        }

        public string Username { get; set; }
    }
}
