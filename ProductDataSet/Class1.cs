namespace ProductDataSet
{
    public class Data
    {
        public class Product
        {
            public string name { get; set; }
            public bool isAvailable { get; set; }
        }

        public List<Product> DataSet = new List<Product>()
        {
            new Product(){name = "Sony a6600 #1", isAvailable = true},
            new Product(){name = "Sony a6600 #2", isAvailable = true},
            new Product(){name = "Sony a6400", isAvailable = true},
            new Product(){name = "Sony a7 ii", isAvailable = true},
            new Product(){name = "Sony 50mm F1.8 #1", isAvailable = true},
            new Product(){name = "Sony 50mm F1.8 #2", isAvailable = true},
            new Product(){name = "Sigma 16mm F1.4", isAvailable = true},
            new Product(){name = "Sony 28-70 F3.5-5.6", isAvailable = true},
            new Product(){name = "Sony 16-50 F3.5-5.6", isAvailable = true},
            new Product(){name = "Sony 18-135 F3.5-5.6", isAvailable = true},
            new Product(){name = "DJI RSC 2", isAvailable = true},
            new Product(){name = "SDHC Lexar Pro 128 GB #1", isAvailable = true},
            new Product(){name = "SDHC Lexar Pro 128 GB #2", isAvailable = true},
            new Product(){name = "Tripod Takara Rover 66v #1", isAvailable = true},
            new Product(){name = "Zhiyun Crane Plus", isAvailable = true},
            new Product(){name = "Lighting Yongnuo #1", isAvailable = true},
            new Product(){name = "Lighting Yongnuo #2", isAvailable = true},
            new Product(){name = "Lighting Yongnuo #3", isAvailable = true},
            new Product(){name = "RGB Studio Light #1", isAvailable = true},
            new Product(){name = "Drone DJI Phantom 4 PRO", isAvailable = true},
            new Product(){name = "Mic Rode Shotgun", isAvailable = true},
            new Product(){name = "Mic Audiotechnica AT2020 #1", isAvailable = true},
            new Product(){name = "Mic Audiotechnica AT2020 #2", isAvailable = true},
            new Product(){name = "Mic Rode Wireless Go II", isAvailable = true},
            new Product(){name = "Saramonic Blink 500 B2 #1", isAvailable = true},
            new Product(){name = "Saramonic Blink 500 B2 #2", isAvailable = true},
            new Product(){name = "Video Transmitter Hollyland Mars 300 PRO HDMI #1", isAvailable = true},
            new Product(){name = "Video Transmitter Hollyland Mars 300 PRO HDMI #2", isAvailable = true},
            new Product(){name = "Green Screen", isAvailable = true},
            new Product(){name = "Batre NP-FW50 #1", isAvailable = true},
        };

        public List<Product> LimitDataSet(int numberOfItem)
        {
            List<Product> LimitedData = new List<Product>();
            for (int i = 0; i < numberOfItem; i++)
            {
                LimitedData[i] = DataSet[i];
            }
            return LimitedData;
        }
    }
}